using System.ComponentModel;
using System.Xml.Serialization;

namespace Model
{
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Helicopter))]
    [XmlInclude(typeof(HybridCar))]
    /// <summary>
    /// Класс для расчёта затраченного топлива
    /// </summary>
    public abstract class VehiclesBase
    {
        /// <summary>
        /// Тип транспортного средства
        /// </summary>
        [DisplayName("Тип транспортного средства")]
        public virtual string VehicleType { get; }

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
        [DisplayName("Расстояние в км")]
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
        [DisplayName("Расход топлива на км")]
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
        /// Дополнительные аараметры для расчёта стоимости топлива
        /// </summary>
        [DisplayName("Доп параметры")]
        public virtual string Parameters { get; }

        /// <summary>
        /// Вычисление затраченного топлива
        /// </summary>
        public abstract double SpentFuel();

        /// <summary>
        /// Получение значения стоимости топлива
        /// </summary>
        [DisplayName("Стоимость топлива")]
        public double SpentFuelValue
        {
            get { return SpentFuel(); }
        }

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
