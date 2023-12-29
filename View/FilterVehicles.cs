using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View
{
    //TODO: XML
    /// <summary>
    /// Класс для создания фильтра транспортных средств
    /// </summary>
    public partial class FilterVehicles : Form
    {

        /// <summary>
        /// Лист транспортных средств
        /// </summary>
        private readonly BindingList<VehiclesBase> _listVehicles;

        /// <summary>
        /// Лист отфильтрованных транспортных средств
        /// </summary>
        private BindingList<VehiclesBase> _listVehiclesFilter;

        /// <summary>
        /// Обработчик события
        /// </summary>
        public EventHandler<EventArgs> VehiclesFiltered;

        /// <summary>
        /// Стоимость топлива
        /// </summary>
        private double _spentFuel;


        /// <summary>
        /// Форма для фильтрации
        /// </summary>
        /// <param name="vehicles">Транспортные средства</param>
        public FilterVehicles(BindingList<VehiclesBase> vehicles)
        {
            InitializeComponent();
            _listVehicles = vehicles;
        }

        /// <summary>
        /// Обработчик события изменения текста в текстовом поле фильтрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (textBoxFilter.Text != "")
                {
                    _spentFuel = Checks.CheckNumber(textBoxFilter.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введено некорректное число", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Контроль ввода значений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Checks.CheckInput(e);
        }

        /// <summary>
        /// Активация поля ввода зарплаты для поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxInput_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxInput.Checked)
            {
                textBoxFilter.Enabled = true;
            }
            else
            {
                textBoxFilter.Enabled = false;
            }
        }


        /// <summary>
        /// Кнопка поиска по созданному фильтру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            _listVehiclesFilter = new BindingList<VehiclesBase>();

            int count = 0;
            if (!checkBoxCar.Checked
                && !checkBoxHelicopter.Checked
                && !checkBoxHybridCar.Checked
                && !checkBoxInput.Checked)
            {
                MessageBox.Show("Критерии для поиска не введены!",
                    "Внимание", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            foreach (VehiclesBase types in _listVehicles)
            {

                switch (types)
                {
                    case Car when checkBoxCar.Checked:
                    case Helicopter when checkBoxHelicopter.Checked:
                    case HybridCar when checkBoxHybridCar.Checked:
                        {
                            if (checkBoxInput.Checked)
                            {
                                if (types.SpentFuelValue == _spentFuel)
                                {
                                    count++;
                                    _listVehiclesFilter.Add(types);
                                    break;
                                }
                                break;
                            }
                            else
                            {
                                count++;
                                _listVehiclesFilter.Add(types);
                                break;
                            }
                        }
                }

                if (!checkBoxCar.Checked
                    && !checkBoxHelicopter.Checked
                    && !checkBoxHybridCar.Checked)
                {
                    if (checkBoxInput.Checked && types.SpentFuelValue == _spentFuel)
                    {
                        count++;
                        _listVehiclesFilter.Add(types);
                    }
                }
            }

            VehicleListEventArgs eventArgs;

            if (count > 0)
            {
                eventArgs = new VehicleListEventArgs(_listVehiclesFilter);
            }
            else
            {
                MessageBox.Show("Стоимости топлива с такими параметрами не" +
                    " существует", "Введите другие параметры",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                eventArgs = new VehicleListEventArgs(_listVehiclesFilter);
                return;
            }

            VehiclesFiltered?.Invoke(this, eventArgs);
            Close();
        }
    }
}