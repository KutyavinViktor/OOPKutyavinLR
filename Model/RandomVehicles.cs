
namespace Model
{
    public class RandomVehicles
    {
        /// <summary>
        /// Рандомайзер
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Генерация случайного числа double через int
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static double GetRandomDouble(int minValue, int maxValue)
        {
            var randomValue = Convert.ToDouble(_random.Next(minValue,
                maxValue));
            return randomValue;
        }

        /// <summary>
        /// Генерация случайной зарплаты
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static VehiclesBase GetRandomWages()
        {
            var figureType = _random.Next(0, 3);

            switch (figureType)
            {
                case 0:
                    {
                        return RandomHelicopter();
                    }
                case 1:
                    {
                        return RandomHybridCar();
                    }
                case 2:
                    {
                        return RandomCar();
                    }
                default:
                    {
                        throw new ArgumentException("Тип транспортного средчтва " +
                            "отсутствует.");
                    }
            }
        }

        /// <summary>
        /// Генерация случайного вертолёта
        /// </summary>
        /// <returns></returns>
        public static VehiclesBase RandomHelicopter()
        {
            var helicopter = new Helicopter();
            {
                helicopter.CargoWeight = GetRandomDouble(1, 10000);
                helicopter.FuelConsumptionPerKm = GetRandomDouble(1, 100);
                helicopter.Distance = GetRandomDouble(1, 10000);
            };
            return helicopter;
        }

        /// <summary>
        /// Генерация случайного гибридного автомобиля
        /// </summary>
        /// <returns></returns>
        public static VehiclesBase RandomHybridCar()
        {
            var hybridCar = new HybridCar();
            {
                hybridCar.СoefficientOfHybridity = GetRandomDouble(1, 10000);
                hybridCar.FuelConsumptionPerKm = GetRandomDouble(1, 30);
                hybridCar.Distance = GetRandomDouble(1, 1000);
            };
            return hybridCar;
        }

        /// <summary>
        /// Генерация случайного автомобиля
        /// </summary>
        /// <returns></returns>
        public static VehiclesBase RandomCar()
        {
            var car = new Car();
            {
                car.Distance = GetRandomDouble(1, 10000);
                car.FuelConsumptionPerKm = GetRandomDouble(1, 50);
            };
            return car;
        }


    }
}


