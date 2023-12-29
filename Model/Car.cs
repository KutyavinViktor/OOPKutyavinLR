
namespace Model
{
    /// <summary>
    /// Машина
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

        /// <summary>
        /// Параметры для расчёта объёма топлива
        /// </summary>
        public override string Parameters
        {
            get
            {
                return "Отсутствуют";
            }
        }

        /// <summary>
        /// Тип транспортного средства
        /// </summary>
        public override string VehicleType => "Автомобиль";
    }
}
