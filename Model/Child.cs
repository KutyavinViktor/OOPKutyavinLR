
namespace Model
{
    /// <summary>
    /// Класс описывающий ребенка
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Отец ребенка.
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Мать ребенка.
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Наибольший возраст ребенка.
        /// </summary>
        private const int MaxAge = 16;

        /// <summary>
        /// Ввод информации о отце ребенка
        /// </summary>
        public Adult Father
        {
            get => _father;
            set
            {
                CheckParentGender(value, Gender.Male);
                _father = value;
            }
        }

        /// <summary>
        /// Ввод информации о матери ребенка
        /// </summary>
        public Adult Mother
        {
            get => _mother;
            set
            {
                CheckParentGender(value, Gender.Female);
                _mother = value;
            }
        }

        /// <summary>
        /// Ввод информации о школе ребенка.
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// Конструктор класса Child.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="father">Отец ребенка.</param>
        /// <param name="mother">Мать ребенка</param>
        /// <param name="school">Школа ребенка.</param>
        public Child(string name, string surname, int age,
            Gender gender, Adult father, Adult mother,
            string school) : base(name, surname, age, gender)
        {
            Father = father;
            Mother = mother;
            School = school;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Child() : this("Unknown", "Unknown", 11,
            Gender.Male, null, null, null)
        { }

        /// <summary>
        /// Проверка пола родителей ребенка
        /// </summary>
        /// <param name="parent">Один из родителей ребенка.</param>
        /// <param name="gender">Необходимый пол родителя.</param>
        /// <exception cref="ArgumentException">Недопустимый пол
        /// для данного родителя.</exception>
        private static void CheckParentGender
            (Adult parent, Gender gender)
        {
            if (parent != null && parent.Gender != gender)
            {
                throw new ArgumentException
                    ("Parent gender must be another");
            }
        }

        /// <summary>
        /// Конвертация полей класса Child в строковый формат.
        /// </summary>
        /// <returns>Информация о ребенке.</returns>
        public override string GetInfo()
        {
            var fatherStatus = Father != null
                ? Father.GetNameSurname()
                : "There is no information about the father";
            var motherStatus = Mother != null
                ? Mother.GetNameSurname()
                : "There is no information about the mother";

            var schoolStatus = "Not trained";
            if (!string.IsNullOrEmpty(School))
            {
                schoolStatus = $"Studies in ({School})";
            }

            return $"{PrintPerson()};\n" +
                $"Father: {fatherStatus};\n" +
                $"Mother: {motherStatus};\n" +
                $"School: {schoolStatus}\n";
        }

        /// <summary>
        /// Метод генерирующий случайного ребенка.
        /// </summary>
        /// <returns>Экземпляр класса Adult.</returns>
        public static Child GetRandomPerson
            (Gender randomGender = Gender.Male)
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

            string[] schools =
            {
                "Russia", "England",
                "Spain",
                "Italy"
            };

            var random = new Random();

            if (random.Next(1, 3) > 1)
            {
                randomGender = Gender.Female;
            }

            string randomName = randomGender == Gender.Male
                ? maleNames[random.Next(maleNames.Length)]
                : femaleNames[random.Next(femaleNames.Length)];

            var randomSurname = surnames[random.Next(surnames.Length)];

            var randomAge = random.Next(MinAge, MaxAge);

            Adult randomFather = GetRandomParent(Gender.Male);

            Adult randomMother = GetRandomParent(Gender.Female);


            var schoolRandom = random.Next(1, 3);
            string? randomSchool = schoolRandom == 1
                ? schools[random.Next(schools.Length)]
                : null;

            return new Child(randomName, randomSurname, randomAge,
                randomGender, randomFather, randomMother, randomSchool);
        }

        //TODO: почему public?
        /// <summary>
        /// Генерация случайного родителя
        /// </summary>
        /// <param name="a">Параметр случайного родителя.</param>
        /// <returns>Объект класса Adult.</returns>
        /// <exception cref="ArgumentException">
        /// Ожидается ввод цифры 1 или 2.</exception>
        private static Adult GetRandomParent(Gender gender)
        {
            var random = new Random();
            var parentStatus = random.Next(1, 3);
            return parentStatus == 1 ? null : Adult.GetRandomPerson(gender);
        }

        //TODO: почему protected?
        /// <summary>
        /// Проверка возраста ребенка.
        /// </summary>
        /// <param name="age">Возраст ребенка.</param>
        /// <exception cref="IndexOutOfRangeException">Возраст не входит
        /// в допустимый диапазон.</exception>
        public override void CheckAge(int age)
        {
            if (age is < MinAge or > MaxAge)
            {
                throw new IndexOutOfRangeException($"the child's age" +
                    $" is in the range [{MinAge}...{MaxAge}].");
            }
        }

        /// <summary>
        /// Метод, который показывает успеваемость ребенка.
        /// </summary>
        /// <returns>Выбранная оценка.</returns>
        public string GetGrade()
        {
            var rnd = new Random();

            string[] grades =
            {
                "Ladno", "3", "4", "5"
            };

            var preferredHouse = grades[rnd.Next(grades.Length)];

            return $"Child's academic performance: {preferredHouse}";
        }

    }
}