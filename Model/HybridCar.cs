
namespace Model
{
    /// <summary>
    /// Класс для расчёта потраченного машиной-гибридом топлива
    /// </summary>
    public class HybridCar : VehiclesBase
    {
        /// <summary>
        /// Расстояние в км
        /// </summary>
        private double _distance;

        /// <summary>
        /// Расход топлива на км
        /// </summary>
        private double _fuelConsumptionPerKm;

        /// <summary>
        /// Расстояние в км
        /// </summary>
        public double Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                CheckPositiveNumber(value);
                _distance = value;
            }
        }

        /// <summary>
        /// Расход топлива на км
        /// </summary>
        public double FuelConsumptionPerKm
        {
            get
            {
                return _fuelConsumptionPerKm;
            }
            set
            {
                CheckPositiveNumber(value);
                _fuelConsumptionPerKm = value;
            }
        }

        // TODO: Коэффициент как отдельный параметр
        /// <summary>
        /// Вычисление затраченного топлива
        /// </summary>
        /// <returns></returns>
        public override double SpentFuel()
        {
            return 0.9 * _distance * _fuelConsumptionPerKm;
        }

    }
}
