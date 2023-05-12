// TODO: Общие атрибуты вынести в базовый класс
namespace Model
{
    /// <summary>
    /// Класс для расчёта затраченного топлива
    /// </summary>
    public abstract class VehiclesBase
    {
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
        /// <exception cref="Exception">В случае введения
        /// отрицательного числа произойдет вывод исключения</exception>
        public double CheckPositiveNumber(double number)
        {
            return number < 0
                ? throw new Exception("Ввелённые числа " +
                    "не могут быть отрицательными!")
                : number;
        }

    }
}
