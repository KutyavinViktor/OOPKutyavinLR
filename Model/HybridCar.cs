
namespace Model
{
    /// <summary>
    /// Класс для расчёта потраченного машиной-гибридом топлива
    /// </summary>
    public class HybridCar : VehiclesBase
    {

        /// <summary>
        /// Коэффициент гибридности
        /// </summary>
        private double _coefficientOfHybridity;

        /// <summary>
        /// Коэффициент гибридности
        /// </summary>
        public double СoefficientOfHybridity
        {
            get
            {
                return _coefficientOfHybridity;
            }
            set
            {
                _coefficientOfHybridity = CheckPositiveNumber(value);
            }
        }

        // TODO: Коэффициент как отдельный параметр
        /// <summary>
        /// Вычисление затраченного топлива
        /// </summary>
        /// <returns></returns>
        public override double SpentFuel()
        {
            return _coefficientOfHybridity * _distance
                * _fuelConsumptionPerKm;
        }

    }
}
