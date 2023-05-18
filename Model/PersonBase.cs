
using System.Globalization;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Класс описывающий человека.
    /// </summary>
    public abstract class PersonBase
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
        protected const int MinAge = 0;

        /// <summary>
        /// Максимальный возраст человека.
        /// </summary>
        protected const int MaxAge = 100;

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
        /// Проверка на пустую строку
        /// </summary>
        /// <param name="value">Подаваемая строка</param>
        /// <exception cref="NullReferenceException">Пустая строка</exception>
        private void CheckNull(string value)
        {
            if (value == null)
            {
                //TODO: переписать информационную строку
                throw new NullReferenceException("Пустая строка.");
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
            get => _age;
            set
            {
                CheckAge(value);
                _age = value;
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
        public PersonBase(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PersonBase()
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
        /// Проверка введённых слов пользователем
        /// </summary>
        /// <param name="value">введённое имя/фамилия.</param>
        /// <returns>return имя/фамлию.</returns>
        /// <exception cref="ArgumentException">генерируется, если в метод
        /// для параметра передается некорректное значение.</exception>
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
        /// <exception cref="ArgumentException">генерируется, если в метод
        /// для параметра передается некорректное значение.</exception>
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
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <exception cref="FormatException">Сравниваемые
        /// строки должны совпадать</exception>
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

        /// <summary>
        /// Метод, формирует информацию о человеке.
        /// </summary>
        public abstract string GetInfo();

        /// <summary>
        /// Метод преобразует значения полей имени и фамилии
        /// в строковый формат.
        /// </summary>
        /// <returns>Фамилия и имя человека.</returns>
        public string GetNameSurname()
        {
            return $"{Name} {Surname}";
        }

        /// <summary>
        /// Проверка возраста человека.
        /// </summary>
        /// <param name="age">Возраст человека.</param>
        public virtual void CheckAge(int age)
        {

        }
    }
}
