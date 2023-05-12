
namespace Model
{
    /// <summary>
    /// Класс для расчёта потраченного вертолётом топлива
    /// </summary>
    public class Helicopter : VehiclesBase
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
        /// Расход топлива на км
        /// </summary>
        private double _cargoWeight;

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

        /// <summary>
        /// Масса груза
        /// </summary>
        public double CargoWeight
        {
            get
            {
                return _cargoWeight;
            }
            set
            {
                CheckPositiveNumber(value);
                _cargoWeight = value;
            }
        }

        /// <summary>
        /// Вычисление затраченного топлива
        /// </summary>
        /// <returns></returns>
        public override double SpentFuel()
        {
            return _distance * _fuelConsumptionPerKm *
                _cargoWeight;
        }


    }
}
