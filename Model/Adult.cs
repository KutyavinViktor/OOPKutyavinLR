
namespace Model
{
    /// <summary>
    /// Класс описывающий взрослого человека.
    /// </summary>
    public class Adult : PersonBase
    {

        /// <summary>
        /// Минимальный возраст взрослого человека.
        /// </summary>
        private const int MinAge = 18;

        /// <summary>
        /// Ввод паспортных данных.
        /// </summary>
        public string PassportInfo { get; set; }

        /// <summary>
        /// Ввод места работы человека.
        /// </summary>
        public string PlaceWork { get; set; }

        /// <summary>
        /// Ввод семейного статуса человека.
        /// </summary>
        public Adult Spouse { get; set; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия человека.</param>
        /// <param name="age">Возраст человека.</param>
        /// <param name="gender">Пол человека.</param>
        /// <param name="passportInfo">Информация о паспорте.</param>
        /// <param name="placeWork">Место работы.</param>
        /// <param name="familyStatus">Семейное положение.</param>
        public Adult(string name, string surname, int age,
            Gender gender, string passportInfo, Adult familyStatus,
            string placeWork) : base(name, surname, age, gender)
        {
            PassportInfo = passportInfo;
            PlaceWork = placeWork;
            Spouse = familyStatus;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Adult() : this("Unknown", "Unknown", 19,
            Gender.Male, "2247 876589", null, null)
        { }

        /// <summary>
        /// Преобразование значений полей класса в строковый формат.
        /// </summary>
        /// <returns>Информация о взрослом человеке.</returns>
        public override string GetInfo()
        {
            string familyStatusInfo = "Single";
            string workInfo = "Does not have a job";

            if (Gender.Equals(Gender.Male) && Spouse != null)
            {
                familyStatusInfo = $"Married to " +
                    $"{Spouse.GetNameSurname()}";
            }

            if (Gender.Equals(Gender.Female))
            {
                familyStatusInfo = Spouse == null
                    ? $"Not married"
                    : $"Married to " +
                    $"{Spouse.GetNameSurname()}";
            }

            if (!string.IsNullOrEmpty(PlaceWork))
            {
                workInfo = PlaceWork;
            }

            return $"{PrintPerson()};\n" +
                $"Passport series and number: {PassportInfo};\n" +
                $"Marital status: {familyStatusInfo};\n" +
                $"Place of work: {workInfo}\n ";
        }

        /// <summary>
        /// Метод генерирующий случайного взрослого человека.
        /// </summary>
        /// <returns>Экземпляр класса Adult.</returns>
        public static Adult GetRandomPerson
            (Gender gender = Gender.Unknown)
        {
            string[] maleNames =
            {
                "Anton", "Danil", "Pavel", "Ruslan", "Roman"
            };

            string[] femaleNames =
            {
                "Olya", "Natasha", "Vera", "Marina", "Ira",
            };

            string[] surnames =
            {
                "Zobnin", "Prutsev", "Zinkovsky", "Denisov", "Hlusevich",
                "Balde", "Meleshin", "Selihov", "Maksimenko", "Sobolev"
            };

            string[] workPlaces =
            {
                "RPL", "APL",
                "LaLiga",
                "SeriaA"
            };

            var random = new Random();

            if (gender is Gender.Unknown)
            {
                gender = random.Next(1, 100) > 50
                    ? Gender.Female
                    : Gender.Female;
            }


            string randomName = gender == Gender.Male
                ? maleNames[random.Next(maleNames.Length)]
                : femaleNames[random.Next(femaleNames.Length)];

            var randomSurname = surnames[random.Next(surnames.Length)];

            var randomAge = random.Next(MinAge, MaxAge);


            string randomSeriesPassport = GeneratingGandomNumbers(4);
            string randomNumberPassport = GeneratingGandomNumbers(6);

            var randomPassport = $"{randomSeriesPassport} " +
                                 $"{randomNumberPassport}";

            Adult randomHuman = null;
            var statusFamily = random.Next(1, 3);
            if (statusFamily == 1)
            {
                randomHuman = new Adult();

                randomHuman.Gender = gender == Gender.Female
                    ? Gender.Male
                    : Gender.Female;

                randomHuman.Name = gender == Gender.Female
                    ? maleNames[random.Next(maleNames.Length)]
                    : femaleNames[random.Next(femaleNames.Length)];

                randomHuman.Surname = surnames[random.Next(surnames.Length)];
            }

            var randonWorkPlace = random.Next(1, 3);
            string? randomWorkPlace = randonWorkPlace == 1
                ? workPlaces[random.Next(workPlaces.Length)]
                : null;

            return new Adult(randomName, randomSurname, randomAge, gender,
                randomPassport, randomHuman, randomWorkPlace);
        }

        /// <summary>
        /// Метод, генерирующий заданное количество рандомных цифр
        /// </summary>
        /// <param name="numberDigits">количество рандомных цифр.</param>
        /// <returns>рандомные цифры.</returns>
        public static string GeneratingGandomNumbers(int numberDigits)
        {
            string seriesOrNumer = "";
            Random random = new Random();
            for (int i = 0; i < numberDigits; i++)
            {
                seriesOrNumer += random.Next(1, 10).ToString();

            }
            return seriesOrNumer;
        }

        /// <summary>
        /// Метод проверяет допустимость возраста.
        /// </summary>
        /// <param name="age">Возраст взрослого человека.</param>
        /// <exception cref="IndexOutOfRangeException">Возраст должен
        /// находится в определнных пределах.</exception>
        public override void CheckAge(int age)
        {
            if (age is < MinAge or > MaxAge)
            {
                throw new IndexOutOfRangeException($"The age should " +
                    $"be in the range ({MinAge}...{MaxAge}).");
            }
        }

        /// <summary>
        /// Метод назначает позицию футболиста
        /// </summary>
        /// <returns>Информация о позиции футболиста.</returns>
        public string GetPosition()
        {
            var rnd = new Random();
            string[] positions =
            {
                "Forward", "Defender", "Goalkeeper", "Midfielders"
            };

            var chosenPosition = positions[rnd.Next(positions.Length)];

            return $"The position of a football player - {chosenPosition}";
        }

    }
}
