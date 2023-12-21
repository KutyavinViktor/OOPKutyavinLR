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
        /// Список транспортных средств
        /// </summary>
        public BindingList<VehiclesBase> VehicleListValue { get; private set; }

        /// <summary>
        /// Конструктор союытия добавления в список траснпортных средств.
        /// </summary>
        /// <param name="vehicles"></param>
        public VehicleListEventArgs(BindingList<VehiclesBase> vehicles)
        {
            VehicleListValue = vehicles;
        }
    }
}
