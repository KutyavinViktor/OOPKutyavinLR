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
            //Добавление первых трёх игроков в список CSKA
            var listCska = new PersonList();
            var legend = new Person("Igor", "Akinfeev", 36, Gender.Male);
            var fortress = new Person("Igor", "Diveev", 23, Gender.Male);
            var forward = new Person("Fedor", "Chalov", 24, Gender.Male);
            listCska.AddPerson(legend);
            listCska.AddPerson(fortress);
            listCska.AddPerson(forward);

            //Добавление вторых трёх игроков в список Spartak
            var listSpartak = new PersonList();
            var zoba = new Person("Roman", "Zobnin", 29, Gender.Male);
            var antoha = new Person("Quincy", "Promes", 31, Gender.Male);
            var cap = new Person("George", "Dzhikiya", 29, Gender.Male);
            listSpartak.AddPerson(zoba);
            listSpartak.AddPerson(antoha);
            listSpartak.AddPerson(cap);

            // Вывод информации о списке людей
            _ = Console.ReadKey();
            Console.WriteLine("Список членов команды listCska:");
            PrintList(listCska);
            Console.WriteLine("\nСписок членов команды listSpartak:");
            PrintList(listSpartak);

            // Добавление нового игрока в список listCska
            _ = Console.ReadKey();
            var top = new Person("Leonel", "Messi", 35, Gender.Male);
            listCska.AddPerson(top);
            Console.WriteLine("\nВ Cska успешно добавлен" +
                $" новый игрок {top.Name} {top.Surname}\n");

            // Копирование второго игрока из listCska в конец
            // списка listSpartak
            _ = Console.ReadKey();
            Person copyPerson = listCska.FindPersonByIndex(1);
            listSpartak.AddPerson(copyPerson);
            Console.WriteLine($"\nВторой игрок" +
                $" {copyPerson.Name} {copyPerson.Surname} успешно" +
                $" копирован из списка Cska в конец списка Spartak\n");

            // Вывод информации о списке людей
            Console.WriteLine("Список членов клуба Cska:");
            PrintList(listCska);
            Console.WriteLine("\nСписок членов клуба Spartak:");
            PrintList(listSpartak);

            // Удаление второго игрока из списка Cska
            _ = Console.ReadKey();
            listCska.DeletePersonByIndex(1);
            Console.WriteLine("\nВторой игрок из списка Cska " +
                              "успешно удален\n");

            // Вывод информации о списке людей
            Console.WriteLine("Список членов команды Cska:");
            PrintList(listCska);
            Console.WriteLine("\nСписок членов команды Spartak:");
            PrintList(listSpartak);

            // Очистка списка Spartak
            _ = Console.ReadKey();
            listSpartak.ClearList();
            Console.WriteLine("\nСписок Spartak успешно очищен\n");

            // Вывод информации о списке людей
            Console.WriteLine("\nСписок членов группы Spartak:");
            PrintList(listSpartak);

            //Чтение персоны с клавиатуры
            Console.WriteLine("\nПроверка ввода человека" +
                              " с клавиатуры\n");

            Person inputPerson = InputPersonByConsole();
            Console.WriteLine("\nВы ввели следующего человека:\n" +
                              $"{inputPerson.PrintPerson()}\n");

            var randomPerson = Person.GetRandomAvenger();
            Console.WriteLine(randomPerson.PrintPerson());
        }

        /// <summary>
        /// Вывод на консоль информации о каждом человеке
        /// в списке людей.
        /// </summary>
        /// <param name="listOfPersons">Список людей</param>
        /// <exception cref="NullReferenceException">
        /// Список людей не должен принимать значение Null</exception>
        private static void PrintList(PersonList listOfPersons)
        {
            if (listOfPersons == null)
            {
                throw new NullReferenceException
                    ("Значение списка людей - Null.");
            }

            if (listOfPersons.CountPersons != 0)
            {
                for (int i = 0; i < listOfPersons.CountPersons; i++)
                {
                    var person = listOfPersons.FindPersonByIndex(i);
                    Console.WriteLine(person.PrintPerson());
                }
            }
            else
            {
                Console.WriteLine("Список людей пуст");
            }
        }

        /// <summary>
        /// Метод, который позволяет вводить информацию с помощью консоли.
        /// </summary>
        /// <returns>Экземпляр класса Person.</returns>
        public static Person InputPersonByConsole()
        {
            var person = new Person();

            var actionList = new List<(Action, string)>
            {
                (
                new Action(() =>
                {
                    Console.Write($"Введите имя человека: ");
                    person.Name = Console.ReadLine();
                }), "name"),

                (new Action(() =>
                {
                    Console.Write($"Введите фамилию человека: ");
                    person.Surname = Console.ReadLine();
                }), "surname"),

                (new Action(() =>
                {
                    Console.Write($"Введите возраст человека: ");
                    _ = int.TryParse(Console.ReadLine(), out int tmpAge);
                    person.Age = tmpAge;
                }), "age"),

                (new Action(() =>
                {
                    Console.Write ("Введите пол человека (1 - Мужчина or" +
                                   " 2 - Женщина): ");
                    _ = int.TryParse(Console.ReadLine(), out int tmpGender);
                    if (tmpGender < 1 || tmpGender > 2)
                    {
                        throw new IndexOutOfRangeException
                           ("Необходимо ввести цифру в диапазоне от 1 до 2");
                    }

                    var realGender = tmpGender == 1
                        ? Gender.Male
                        : Gender.Female;
                    person.Gender = realGender;
                }), "gender")
            };

            foreach (var action in actionList)
            {
                ActionHandler(action.Item1);
            }

            return person;
        }

        /// <summary>
        /// Метод, обрабатывающий исключения
        /// </summary>
        /// <param name="action"></param>
        /// <param name="propertyName"></param>
        private static void ActionHandler(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    break;
                }
                catch (Exception exception)
                {
                    if (exception.GetType()
                        == typeof(IndexOutOfRangeException)
                        || exception.GetType() == typeof(FormatException)
                        || exception.GetType() == typeof(ArgumentException))
                    {
                        Console.WriteLine($"\nОшибка!!! {exception.Message}" +
                            $" Повторите ввод заново.\n");
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }
    }
}