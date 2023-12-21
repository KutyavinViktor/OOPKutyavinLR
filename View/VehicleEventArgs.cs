using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace View
{
    /// <summary>
    /// Класс для передачи данных о транспортном средстве
    /// </summary>
    internal class VehicleEventArgs : EventArgs
    {
        /// <summary>
        /// Отправка значения
        /// </summary>
        public VehiclesBase WageValue { get; private set; }

        /// <summary>
        /// Конструктор для передачи значения
        /// </summary>
        /// <param name="sendingValue">Передача</param>
        public VehicleEventArgs(VehiclesBase wageValue)
        {
            WageValue = wageValue;
        }
    }
}
