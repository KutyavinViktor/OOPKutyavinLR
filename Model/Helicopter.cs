
namespace Model
{
    /// <summary>
    /// Класс для расчёта потраченного вертолётом топлива
    /// </summary>
    public class Helicopter : VehiclesBase
    {

        /// <summary>
        /// Масса груза
        /// </summary>
        private double _cargoWeight;

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
                _cargoWeight = CheckPositiveNumber(value);
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