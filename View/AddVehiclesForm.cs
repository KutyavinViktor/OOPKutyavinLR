﻿using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace View
{
    /// <summary>
    /// Добавление нового транспортного средства
    /// </summary>
    public partial class AddVehiclesForm : Form
    {

        /// <summary>
        /// Делегат для добавления транспортного средства.
        /// </summary>
        public EventHandler<EventArgs> AddingVehicles;

        /// <summary>
        /// Переменная для словаря UserControl
        /// </summary>
        private readonly Dictionary<string, UserControl>
            _comboBoxToUserControl;

        /// <summary>
        /// Метка UserControl
        /// </summary>
        private UserControl _userControl;

        /// <summary>
        /// Конструктор добавления транспортных средств
        /// </summary>
        public AddVehiclesForm()
        {
            InitializeComponent();
            comboVehiclesSelection.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            string[] typeVehicles = { "Автомобиль",
                                      "Вертолёт",
                                      "Автомобиль гибрид" };

            comboVehiclesSelection.Items.AddRange(typeVehicles);

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {typeVehicles[0], carUserControl1 },
                {typeVehicles[1], helicopterUserControl1 },
                {typeVehicles[2], hybridCarUserControl1 },
            };
        }

        /// <summary>
        /// Действие при выборе слова из выпадающего списка
        /// Задает выбранный элемент в поле со списком ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxVehiclesSelection(object sender, EventArgs e)
        {
            string vehicleType = 
                comboVehiclesSelection.SelectedItem.ToString();
            foreach (var (vehicleValue, userControlTmp) in 
                _comboBoxToUserControl)
            {
                userControlTmp.Visible = false;
                if (vehicleType == vehicleValue)
                {
                    userControlTmp.Visible = true;
                    buttonOk.Enabled = true;
                    this._userControl = userControlTmp;
                }
            }
        }

        /// <summary>
        /// Обработчик события для кнопки "ОК"
        /// </summary>
        /// <param name="sender">Объект, вызывающий событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonOk(object sender, EventArgs e)
        {
            try
            {
                var vehicleControlName =
                    comboVehiclesSelection.SelectedItem.ToString();
                var vehicleControl = 
                    _comboBoxToUserControl[vehicleControlName];
                var vehicleEventArgs =
                    new VehicleEventArgs(((IAddVehicles)vehicleControl).
                    AddingVehicles());
                AddingVehicles?.Invoke(this, vehicleEventArgs);
                DialogResult = DialogResult.OK;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение либо ничего" +
                    " не введено!\n" +
                   "Введите одно положительное целое или десятичное число" +
                   " в каждое текстовое поле.",
                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка закрыть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClouse(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VehicleLoad(object sender, EventArgs e)
        {
            carUserControl1.Visible = false;
            helicopterUserControl1.Visible = false;
            hybridCarUserControl1.Visible = false;
        }
    }
}
