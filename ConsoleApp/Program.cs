using Model;
using System;

namespace Model
{
    /// <summary>
    /// Класс Program
    /// </summary>
    internal class Program
    {
        /// <summary> 
        /// Класс Main
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Здравствуйте, выберите " +
                "вид транспорта для покупки:");
            while (true)
            {
                Console.WriteLine("\n1 - Машина" +
                "\n2 - Машина-гибрид" +
                "\n3 - Вертолёт" +
                "\n4 - Завершить выбор");

                Console.Write("\nВведите цифру из представленного " +
                    "списка: ");
                var consoleKey = Console.ReadLine();
                switch (consoleKey)
                {
                    case "1":
                        {
                            Console.WriteLine("\tРасчёт для автомобиля");
                            PrintWages(EnteringCarData());
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("\tРасчёт для автомобиля-" +
                                "гибрида");
                            PrintWages(EnteringCarHybridData());
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("\tРасчёт для вертолёта");
                            PrintWages(EnteringHelicopterData());
                            break;
                        }
                    case "4":
                        {
                            Environment.Exit(4);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Попробуйте еще раз");
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Ввод данных для расчёта затраченного топлива
        /// машиной
        /// </summary>
        /// <returns>данные о затраченном топливе</returns>
        public static Car EnteringCarData()
        {
            Car car = new Car();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Расстояние, пройденное " +
                        "автомобилем: ");
                    car.Distance = ParseConsoleString();
                }),
                new Action(() =>
                {
                    Console.Write("Расход бензина на км: ");
                    car.FuelConsumptionPerKm = ParseConsoleString();
                })
            };
            actions.ForEach(SetInformationFromConsole);
            return car;
        }

        /// <summary>
        /// Ввод данных для расчёта затраченного топлива
        /// машиной-гибридом
        /// </summary>
        /// <returns>данные о затраченном топливе</returns>
        public static HybridCar EnteringCarHybridData()
        {
            HybridCar hybridcar = new HybridCar();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Расстояние, пройденное " +
                        "автомобилем-гибридом: ");
                    hybridcar.Distance = ParseConsoleString();
                }),
                new Action(() =>
                {
                    Console.Write("Расход бензина на км: ");
                    hybridcar.FuelConsumptionPerKm = ParseConsoleString();
                })
            };
            actions.ForEach(SetInformationFromConsole);
            return hybridcar;
        }

        /// <summary>
        /// Ввод данных для расчёта затраченного топлива
        /// вертолётом
        /// </summary>
        /// <returns>данные о затраченном топливе</returns>
        public static Helicopter EnteringHelicopterData()
        {
            Helicopter helicopter = new Helicopter();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Расстояние, пройденное " +
                        "вертолётом: ");
                    helicopter.Distance = ParseConsoleString();
                }),
                new Action(() =>
                {
                    Console.Write("Расход керосина на км: ");
                    helicopter.FuelConsumptionPerKm = ParseConsoleString();
                }),
                new Action(() =>
                {
                    Console.Write("Масса перевозимого груза, т: ");
                    helicopter.CargoWeight = ParseConsoleString();
                })
            };
            actions.ForEach(SetInformationFromConsole);
            return helicopter;
        }

        // TODO: Упадет, если ввести текст (не число)
        /// <summary>
        /// Чтение информации с консоли
        /// </summary>
        /// <returns>введенное слово</returns>
        public static double ParseConsoleString()
        {
            bool result = 
                double.TryParse(Console.ReadLine().Replace('.', ','), 
                out var number);
            if (result != true)
                throw new ArgumentException("Введите числовые значения!");
            return number;
        }

        /// <summary>
        /// Вывод полученной информации на консоль
        /// </summary>
        /// <param name="value">затраченное топливо</param>
        public static void PrintWages(VehiclesBase value)
        {
            Console.WriteLine($"Объём затраченного топлива: " +
                $" {value.SpentFuel()} литров.");
        }

        // TODO: Уточнить Exception
        /// <summary>
        /// Проверка введенной информации
        /// </summary>
        /// <param name="action">делегат</param>
        public static void SetInformationFromConsole(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }

                catch (Exception exception)
                {
                    if (exception.GetType()
                        == typeof(ArgumentOutOfRangeException)
                        || exception.GetType() == typeof(ArgumentException))
                    {
                        Console.WriteLine($"\n{exception.Message}\n");
                    }
                }
            }
        }

    }
}