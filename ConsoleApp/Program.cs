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
            Console.WriteLine("If you want to add 7 random people" +
                " to the list, press any key\n");
            var listPeople = new PersonList();
            var rrandom = new Random();

            for (var i = 0; i < 7; i++)
            {
                PersonBase randomPerson = rrandom.Next(2) == 0
                    ? Adult.GetRandomPerson()
                    : Child.GetRandomPerson();
                listPeople.AddPerson(randomPerson);
            }

            _ = Console.ReadKey();

            Console.WriteLine("Information about generated people:\n");
            PrintList(listPeople);

            Console.WriteLine("To display additional information about" +
                " the fourth person, press any key\n");
            _ = Console.ReadKey();

            Console.Write("Additional information about the fourth person:");
            var person = listPeople.FindPersonByIndex(3);

            switch (person)
            {
                case Adult personAdult:
                    Console.WriteLine(personAdult.GetPosition());
                    break;
                case Child personChild:
                    Console.WriteLine(personChild.GetGrade());
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Метод, который выводит в консоль информацию о каждом человеке 
        /// в списке людей.
        /// </summary>
        /// <param name="personList">Экземпляр класса PersonList.</param>
        private static void PrintList(PersonList personList)
        {
            if (personList.CountPersons != 0)
            {
                for (int i = 0; i < personList.CountPersons; i++)
                {
                    var tmpPerson = personList.FindPersonByIndex(i);
                    Console.WriteLine(tmpPerson.GetInfo());
                }
            }
            else
            {
                Console.WriteLine("The list is empty");
            }
        }
    }
}