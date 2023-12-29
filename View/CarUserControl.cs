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
namespace View
{
    //TODO: XML
    /// <summary>
    /// Добавление параметров автомобиля
    /// </summary>
    public partial class CarUserControl : UserControl, IAddVehicles
    {

        //TODO: XML
        /// <summary>
        /// Конструктор
        /// </summary>
        public CarUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ввод чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Checks.CheckInput(e);
        }

        /// <summary>
        /// Метод добавления параметров транспортного средства
        /// </summary>
        /// <returns></returns>
        public VehiclesBase AddingVehicles()
        {
            var viheclesSalary = new Car();

            viheclesSalary.Distance =
                Checks.CheckNumber(textBoxDistance.Text);
            viheclesSalary.FuelConsumptionPerKm =
                Checks.CheckNumber(textBoxConsumptionPerKm.Text);

            return viheclesSalary;
        }
    }
}
