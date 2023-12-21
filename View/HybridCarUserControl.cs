using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class HybridCarUserControl : UserControl, IAddVehicles
    {
        public HybridCarUserControl()
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
            var vehiclesSalary = new HybridCar();

            vehiclesSalary.Distance =
                Checks.CheckNumber(textBox1.Text);
            vehiclesSalary.FuelConsumptionPerKm =
                Checks.CheckNumber(textBox2.Text);
            vehiclesSalary.СoefficientOfHybridity =
                Checks.CheckNumber(textBox3.Text);
            return vehiclesSalary;
        }
    }
}
