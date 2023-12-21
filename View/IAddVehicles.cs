using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace View
{
    /// <summary>
    /// Интерфейс для добавления транспортного средства
    /// </summary>
    internal interface IAddVehicles
    {
        /// <summary>
        /// Метод для добавления транспортного средства
        /// </summary>
        /// <returns></returns>
        VehiclesBase AddingVehicles();
    }
}
