using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Model;
namespace View
{
    //TODO: XML
    /// <summary>
    /// ����� ��� �������� ������� �����
    /// </summary>
    public partial class VehiclesForm : Form
    {
        /// <summary>
        /// �����������
        /// </summary>
        public VehiclesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ������ ������������ �������
        /// </summary>
        private BindingList<VehiclesBase> _vehiclesList = new();

        /// <summary>
        /// ���� ��������������� ������������ �������
        /// </summary>
        private BindingList<VehiclesBase> _listVehiclesFilter = new();

        /// <summary>
        /// ��� ������ 
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<VehiclesBase>));

        /// <summary>
        /// �������� ����� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            _vehiclesList = new BindingList<VehiclesBase>();
            CreateTable(_vehiclesList, dataGridViewFuel);
        }

        /// <summary>
        /// �������� ������� DataGrid.
        /// </summary>
        /// <param name="vehicles">������ ������������ �������</param>
        /// <param name="dataGridView">������� ����������</param>
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
        /// ���������� ������ ������������� ��������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var addWageForm = new AddVehiclesForm();

            addWageForm.AddingVehicles += (sender, vehicleEventArgs) =>
            {
                _vehiclesList.Add(((VehicleEventArgs)vehicleEventArgs).VehicleValue);
            };
            addWageForm.ShowDialog();
        }

        /// <summary>
        /// �������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuel.SelectedCells.Count != 0)
            {
                List<int> indexesToRemove = new List<int>();

                foreach (DataGridViewCell cell in dataGridViewFuel.SelectedCells)
                {
                    if (!indexesToRemove.Contains(cell.RowIndex))
                    {
                        indexesToRemove.Add(cell.RowIndex);
                    }
                }

                foreach (int index in indexesToRemove.OrderByDescending(i => i))
                {
                    _vehiclesList.RemoveAt(index);
                }
            }
            else
            {
                MessageBox.Show("������� ��� �������� �� �������!");
            }
        }

        /// <summary>
        /// ������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuel.RowCount != 0)
            {
                _vehiclesList.Clear();
            }
            else
            {
                MessageBox.Show("������ ������������ ������� ����!");
            }
        }

        /// <summary>
        /// ������� ���������� ������������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            _vehiclesList.Add(RandomVehicles.GetRandomVehicles());
        }

        /// <summary>
        /// ������ ��� �������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuel.RowCount != 0)
            {
                var newFilterVehicles = new FilterVehicles(_vehiclesList);
                newFilterVehicles.ShowDialog();
                newFilterVehicles.VehiclesFiltered += (sender, vehicleEventArgs) =>
                {
                    dataGridViewFuel.DataSource =
                    ((VehicleListEventArgs)vehicleEventArgs).VehicleListValue;
                    _listVehiclesFilter = ((VehicleListEventArgs)vehicleEventArgs).VehicleListValue;

                };
            }
            else
            {
                MessageBox.Show("������ ������������ ������� ����");
            }
        }

        /// <summary>
        /// ����� �������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCleanFilter_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuel.RowCount != 0)
            {
                CreateTable(_vehiclesList, dataGridViewFuel);
            }
            else
            {
                MessageBox.Show("������ �� ��� �����!");
            }
        }

        /// <summary>
        /// ���������� ������ � ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_vehiclesList.Count == 0)
            {
                MessageBox.Show("����������� ������ ��� ����������.",
                    "������ �� ���������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "����� (*.vh)|*.vh|��� ����� (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                try
                {
                    using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                    using (StreamWriter writer = new StreamWriter(file, Encoding.UTF8))
                    {
                        _serializer.Serialize(writer, _vehiclesList);
                    }

                    MessageBox.Show("���� ������� �������.",
                        "���������� ���������",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� ���������� �����: {ex.Message}",
                        "������ ����������",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// �������� ����� �� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "����� (*.vh)|*.vh|��� ����� (*.*)|*.*"
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
                MessageBox.Show("���� ������� ��������.",
                    "�������� ���������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("�� ������� ��������� ����.\n" +
                    "���� �������� ��� �� ������������� �������.\n",
                    "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}