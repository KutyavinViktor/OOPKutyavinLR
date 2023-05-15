
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
        /// <returns>Количество затраченного топлива.</returns>
        public override double SpentFuel()
        {
            return Distance * FuelConsumptionPerKm;
        }

    }
}
