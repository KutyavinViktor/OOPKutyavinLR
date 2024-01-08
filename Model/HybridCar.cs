namespace Model
{
    /// <summary>
    /// Машина-гибрид
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
        public double CoefficientOfHybridity
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
            return CoefficientOfHybridity * Distance * FuelConsumptionPerKm;
        }

        /// <summary>
        /// Тип транспортного средства
        /// </summary>
        public override string VehicleType => "Гибрид";

        /// <summary>
        /// Дополнительные параметры для расчёта объёма топлива
        /// </summary>
        public override string Parameters
        {
            get
            {
                return $"Коэффициент гибридности: {CoefficientOfHybridity}";
            }
        }
    }
}
