using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Model;
namespace View
{
    //TODO(+): XML
    /// <summary>
    /// Создание главной формы
    /// </summary>
    public partial class VehiclesForm : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public VehiclesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Состояние фильтра
        /// </summary>
        private bool isFilterActive = false;

        /// <summary>
        /// Список транспортных средств
        /// </summary>
        private BindingList<VehiclesBase> _vehiclesList = new();

        /// <summary>
        /// Лист отфильтрованных транспортных средств
        /// </summary>
        private BindingList<VehiclesBase> _listVehiclesFilter = new();

        /// <summary>
        /// Для файлов 
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<VehiclesBase>));

        /// <summary>
        /// Загрузка формы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            _vehiclesList = new BindingList<VehiclesBase>();
            CreateTable(_vehiclesList, dataGridViewFuel);
        }

        /// <summary>
        /// Создание таблицы DataGrid.
        /// </summary>
        /// <param name="vehicles">Список транспортных средств</param>
        /// <param name="dataGridView">Элемент управления</param>
        public static void CreateTable(BindingList<VehiclesBase> vehicles,
              DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(vehicles, null);
            dataGridView.DataSource = source;
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Добавление нового транспортного средства.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var addVehicleForm = new AddVehiclesForm();

            addVehicleForm.AddingVehicles += (sender, vehicleEventArgs) =>
            {
                _vehiclesList.Add(((VehicleEventArgs)vehicleEventArgs).
                    VehicleValue);
            };
            addVehicleForm.ShowDialog();
        }

        /// <summary>
        /// Удаление позиций
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuel.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewFuel.SelectedRows)
                {
                    _vehiclesList.Remove(row.DataBoundItem as VehiclesBase);
                    _listVehiclesFilter.Remove(row.DataBoundItem
                        as VehiclesBase);
                }
            }
            else
            {
                MessageBox.Show("Не выбраны позиции для удаления!");
            }
        }

        /// <summary>
        /// Очистка списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            if (_vehiclesList.Count != 0)
            {
                _vehiclesList.Clear();
                _listVehiclesFilter.Clear();
            }
            else
            {
                MessageBox.Show("Список транспортных средств пуст!");
            }
        }

        /// <summary>
        /// Функция случайного транспортного средства
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            if (isFilterActive)
            {
                MessageBox.Show("Для добавления новых транспортных средств" +
                    " сбросьте фильтр.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _vehiclesList.Add(RandomVehicles.GetRandomVehicles());
        }

        /// <summary>
        /// Кнопка для открытия фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (_vehiclesList.Count != 0)
            {
                var newFilterVehicles = new FilterVehicles(_vehiclesList);
                newFilterVehicles.Show();
                newFilterVehicles.VehiclesFiltered +=
                    (sender, vehicleEventArgs) =>
                {
                    dataGridViewFuel.DataSource =
                    ((VehicleListEventArgs)vehicleEventArgs).VehicleListValue;
                    _listVehiclesFilter =
                    ((VehicleListEventArgs)vehicleEventArgs).VehicleListValue;
                    isFilterActive = true;
                };

                newFilterVehicles.FormClosed +=
                    (filterSender, filterEventArgs) =>
                {
                    buttonFilter.Enabled = true;
                };
                buttonFilter.Enabled = false;
            }
            else
            {
                MessageBox.Show("Добавьте транспортные средства!");
            }
        }

        /// <summary>
        /// Сброс настроек фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCleanFilter_Click(object sender, EventArgs e)
        {
            if (isFilterActive == true)
            {
                CreateTable(_vehiclesList, dataGridViewFuel);
                isFilterActive = false;
            }
            else
            {
                MessageBox.Show("Фильтр очищен!");
            }
        }

        /// <summary>
        /// Сохранение списка в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_vehiclesList.Count == 0)
            {
                MessageBox.Show("Отсутствуют данные для сохранения.",
                    "Данные не сохранены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*.vh)|*.vh|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                try
                {
                    using (FileStream file = new FileStream(path,
                                                            FileMode.Create,
                                                            FileAccess.Write,
                                                            FileShare.None))
                    using (StreamWriter writer = new StreamWriter(file,
                                                              Encoding.UTF8))
                    {
                        _serializer.Serialize(writer, _vehiclesList);
                    }

                    MessageBox.Show("Файл успешно сохранён.",
                        "Сохранение завершено",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении " +
                        $"файла: {ex.Message}", "Ошибка сохранения",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Открытие файла со списком
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.vh)|*.vh|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog.FileName.ToString();

            try
            {
                using (var file = new StreamReader(path))
                {
                    _vehiclesList = (BindingList<VehiclesBase>)
                        _serializer.Deserialize(file);

                }
                dataGridViewFuel.DataSource = _vehiclesList;
                dataGridViewFuel.CurrentCell = null;
                MessageBox.Show("Файл успешно загружен.",
                    "Загрузка завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить файл.\n" +
                    "Файл повреждён или не соответствует формату.\n",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}