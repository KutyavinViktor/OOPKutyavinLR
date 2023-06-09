
using System.Globalization;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Класс описывающий человека.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя человека.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст человека.
        /// </summary>
        private int _age;

        /// <summary>
        /// Пол человека.
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Минимальный возраст человека.
        /// </summary>
        private const int MinAge = 0;

        /// <summary>
        /// Максимальный возраст человека.
        /// </summary>
        private const int MaxAge = 100;

        /// <summary>
        /// Метод проверок ввода имени и фамилии
        /// </summary>
        /// <param name="value"></param>
        private string CheckingNameSurname(string value, string comparison)
        {
            CheckNull(value);
            CheckString(value);
            ChekingSamenessLanguage(value);
            CheckToLanguage(value, comparison);
            return ChangeRegister(value);
        }

        /// <summary>
        /// Проверка на пустой ввод имни и фамилии
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="NullReferenceException"></exception>
        private void CheckNull(string value)

        {
            if (value == null)
            {
                throw new NullReferenceException
                    ("Вы ничего не ввели.");
            }
        }

        /// <summary>
        /// Ввод имени человека.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = CheckingNameSurname(value, _surname);
            }
        }

        /// <summary>
        /// Ввод фамилии человека.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = CheckingNameSurname(value, _name);
            }
        }

        /// <summary>
        /// Ввод возраста человека.
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > MinAge && value < MaxAge)
                {
                    _age = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Возраст человека" +
                        $" должен находиться в диапазоне от {MinAge} до" +
                        $" {MaxAge} лет");
                }
            }
        }

        /// <summary>
        /// Ввод пола человека.
        /// </summary>
        public Gender Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия человека.</param>
        /// <param name="age">Возраст человека.</param>
        /// <param name="gender">Пол человека.</param>
        public Person(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// Метод, который конвертирует значение полей класса
        /// в строковый формат.
        /// </summary>
        /// <returns>Строка, содержащая информацию о человеке.</returns>
        public string PrintPerson()
        {
            return $"{Name} {Surname}; Возраст - {Age}; Пол - {Gender}";
        }

        /// <summary>
        /// Метод для генерации человека со случайными  именем, фамилией,
        /// возрастом и полом. 
        /// </summary>
        /// <returns>Объект Person cо случайными значениями атрибутов имя,
        /// фамилия, возраст и пол.</returns>
        public static Person GetRandomAvenger()
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

            var randPerson = new Random();


            //Генерация случайной личности.
            Gender randomGender = randPerson.Next(0, 2) == 0
                ? Gender.Male
                : Gender.Female;

            string randomName = randomGender == Gender.Male
                ? maleNames[randPerson.Next(maleNames.Length)]
                : femaleNames[randPerson.Next(femaleNames.Length)];

            var randomSurname = surnames[randPerson.Next(surnames.Length)];

            var randomAge = randPerson.Next(MinAge, MaxAge);

            return new Person(randomName, randomSurname, randomAge, randomGender);
        }

        /// <summary>
        /// Проверка введённых слов пользователем
        /// </summary>
        /// <param name="value">введённое имя/фамилия.</param>
        /// <returns>return имя/фамлию.</returns>
        /// <exception cref="ArgumentException">error output.</exception>
        private void CheckString(string value)
        {
            Regex word = new(@"(^[А-яA-z]*(-)?[А-яA-z]*$)");

            if (!word.IsMatch(value))
            {
                throw new ArgumentException("Разрешено вводить только" +
                    " буквы и один дефис.");
            }
        }

        /// <summary>
        /// Метод, определяющий и возвращающий язык
        /// </summary>
        /// <param name="word">Строка.</param>
        /// <returns>Язык передаваемой строки.</returns>
        private static Languages DefinitionLanguage(string word)
        {
            var engLanguage = new Regex
                (@"^[A-z]+(-)?[A-z]*$");
            var ruLanguage = new Regex
                (@"^[А-я]+(-)?[А-я]*$");

            if (string.IsNullOrEmpty(word) == false)
            {
                if (engLanguage.IsMatch(word))
                {
                    return Languages.Eng;
                }
                if (ruLanguage.IsMatch(word))
                {
                    return Languages.Ru;
                }
            }
            return Languages.Unknown;
        }

        /// <summary>
        /// Метод соответствия языка в имени и фамилии
        /// </summary>
        /// <param name="word">Имя и фамилия</param>
        private void ChekingSamenessLanguage(string word)
        {
            if (DefinitionLanguage(word) == Languages.Unknown)
            {
                throw new ArgumentException("Некоректный ввод. " +
                        "Пожалуйста, используйте только" +
                        " символы одного языка.");
            }
        }

        /// <summary>
        /// Проверка имени и фамилии на одинаковый язык
        /// </summary>
        /// <param name="name">//TODO: XML</param>
        /// <param name="surname">//TODO: XML</param>
        /// <exception cref="FormatException">Проверка имени и фамилии на одинаковый язык</exception>
        private void CheckToLanguage(string name, string surname)
        {
            if (!string.IsNullOrEmpty(name)
                && !string.IsNullOrEmpty(surname))
            {
                var nameLanguage = DefinitionLanguage(name);
                var surnameLanguage = DefinitionLanguage(surname);

                if (nameLanguage != surnameLanguage)
                {
                    throw new FormatException("Имя и фамилия должны" +
                        " быть на одинаковом языке");
                }
            }
        }

        /// <summary>
        /// Метод для преобразования регистра:
        /// Первая буква - заглавная;
        /// Остальные - строчные.
        /// </summary>
        /// <param name="word">Строка (имя или фамилия).</param>
        /// <returns>Строка с преобразованным регистром.</returns>
        private static string ChangeRegister(string word)
        {
            return CultureInfo.CurrentCulture.TextInfo.
                ToTitleCase(word.ToLower());
        }
    }
}
