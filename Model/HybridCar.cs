
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
        
        /// <summary>
        /// Вычисление затраченного топлива
        /// </summary>
        /// <returns>Количество затраченного топлива.</returns>
        public override double SpentFuel()
        {
            return СoefficientOfHybridity * Distance * FuelConsumptionPerKm;
        }

    }
}
