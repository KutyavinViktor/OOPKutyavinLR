// TODO: Общие атрибуты вынести в базовый класс
namespace Model
{
    /// <summary>
    /// Класс для расчёта затраченного топлива
    /// </summary>
    public abstract class VehiclesBase
    {
        /// <summary>
        /// Расстояние в км
        /// </summary>
        protected double _distance;

        /// <summary>
        /// Расход топлива на км
        /// </summary>
        protected double _fuelConsumptionPerKm;

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
                _distance = CheckPositiveNumber(value);
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
                _fuelConsumptionPerKm = CheckPositiveNumber(value);
            }
        }

        /// <summary>
        /// Вычисление затраченного топлива
        /// </summary>
        public abstract double SpentFuel();

        // TODO: Уточнить Exception
        /// <summary>
        /// Проверка на отрицательные числа
        /// </summary>
        /// <param name="number">путь и расход топлива</param>
        /// <returns>путь и расход топлива</returns>
        /// <exception cref="ArgumentOutOfRangeException">В случае введения
        /// отрицательного числа произойдет вывод исключения</exception>
        public double CheckPositiveNumber(double number)
        {
            return number < 0
                ? throw new ArgumentOutOfRangeException("Введённые числа " +
                    "не могут быть отрицательными!")
                : number;
        }

    }
}
