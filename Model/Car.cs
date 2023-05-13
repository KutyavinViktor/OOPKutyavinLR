
namespace Model
{
    /// <summary>
    /// Класс для расчёта потраченного машиной топлива
    /// </summary>
    public class Car : VehiclesBase
    {
        /// <summary>
        /// Вычисление затраченного топлива
        /// </summary>
        /// <returns></returns>
        public override double SpentFuel()
        {
            return _distance * _fuelConsumptionPerKm;
        }

    }
}
