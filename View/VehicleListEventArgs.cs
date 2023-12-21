using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace View
{
    /// <summary>
    /// Класс событий
    /// </summary>
    internal class VehicleListEventArgs : EventArgs
    {
        /// <summary>
        /// Список зарплат
        /// </summary>
        public BindingList<VehiclesBase> VehicleListValue { get; private set; }

        /// <summary>
        /// Конструктор союытия добавления в список зарплат.
        /// </summary>
        /// <param name="wages"></param>
        public VehicleListEventArgs(BindingList<VehiclesBase> wages)
        {
            VehicleListValue = wages;
        }
    }
}
