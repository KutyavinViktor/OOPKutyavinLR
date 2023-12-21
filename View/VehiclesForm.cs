using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;
using Model;
namespace View
{
    public partial class VehiclesForm : Form
    {
        public VehiclesForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Список зарплат
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
        /// <param name="vehicles"></param>
        /// <param name="dataGridView"></param>
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
        }


        /// <summary>
        /// Добавление нового транспортного средства.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var addWageForm = new AddVehiclesForm();

            addWageForm.AddingVehicles += (sender, wageEventArgs) =>
            {
                _vehiclesList.Add(((VehicleEventArgs)wageEventArgs).WageValue);
            };
            addWageForm.ShowDialog();

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
                // Создаем список для хранения индексов строк для удаления
                List<int> indexesToRemove = new List<int>();

                // Получаем индексы выбранных строк
                foreach (DataGridViewCell cell in dataGridViewFuel.SelectedCells)
                {
                    if (!indexesToRemove.Contains(cell.RowIndex))
                    {
                        indexesToRemove.Add(cell.RowIndex);
                    }
                }
                // Удаляем строки из коллекции _vehiclesList по индексам
                foreach (int index in indexesToRemove.OrderByDescending(i => i))
                {
                    _vehiclesList.RemoveAt(index);
                }
            }
        }

        /// <summary>
        /// Очистка списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            _vehiclesList.Clear();
        }

        /// <summary>
        /// Функция случайноого транспортного средства
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            _vehiclesList.Add(RandomVehicles.GetRandomWages());
        }



        /// <summary>
        /// Кнопка для открытия фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var newFilterWages = new FilterVehicles(_vehiclesList);
            newFilterWages.Show();
            newFilterWages.VehiclesFiltered += (sender, wageEventArgs) =>
            {
                dataGridViewFuel.DataSource =
                ((VehicleListEventArgs)wageEventArgs).VehicleListValue;
                _listVehiclesFilter = ((VehicleListEventArgs)wageEventArgs).VehicleListValue;

            };
        }

        /// <summary>
        /// Сброс найтроек фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCleanFilter_Click(object sender, EventArgs e)
        {
            CreateTable(_vehiclesList, dataGridViewFuel);
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
                Filter = "Файлы (*.zp)|*.zp|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                using (FileStream file = File.Create(path))
                {
                    _serializer.Serialize(file, _vehiclesList);
                }
                MessageBox.Show("Файл успешно сохранён.",
                    "Сохранение завершено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Filter = "Файлы (*.zp)|*.zp|Все файлы (*.*)|*.*"
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
                    "Файл повреждён или не соответствует формату.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}