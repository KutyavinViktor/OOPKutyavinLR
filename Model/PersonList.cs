
namespace Model
{
    /// <summary>
    /// Класс, который описывает группу людей.
    /// </summary>
    public class PersonList
    {

        private List<PersonBase> _listOfPersons = new List<PersonBase>();

        /// <summary>
        /// Количество людей в списке
        /// </summary>
        public int CountPersons => _listOfPersons.Count;

        /// <summary>
        /// Метод, который добавляет человека в список людей.
        /// </summary>
        /// <param name="person">Объект класса PersonBase</param>
        public void AddPerson(PersonBase person)
        {
            _listOfPersons.Add(person);
        }

        /// <summary>
        /// Метод, который удаляет указанного человека из списка людей.
        /// </summary>
        /// <param name="person">Объект класса PersonBase.</param>
        /// Пустой список людей.</exception>
        public void DeletePerson(PersonBase person)
        {
            _ = _listOfPersons.RemoveAll(_listOfPersons => _listOfPersons == person);
        }

        /// <summary>
        /// Метод, который находит индексы указанного человека
        /// в списке людей.
        /// </summary>
        /// <param name="person">Объект класса PersonBase.</param>
        /// <returns></returns>
        public List<int> FindIndexesOfPerson(PersonBase person)
        {
            List<int> listOfIndexes = new List<int>();

            for (int i = 0; i < _listOfPersons.Count; i++)
            {
                if (_listOfPersons[i] == person)
                {
                    listOfIndexes.Add(i);
                }
            }

            return listOfIndexes;
        }

        /// <summary>
        /// Метод удаления человека из списка по индексу
        /// </summary>
        /// <param name="index"></param>
        public void DeletePersonByIndex(int index)
        {
            IsIndexInArray(index);
            _listOfPersons.RemoveAt(index);
        }

        /// <summary>
        /// Метод, который находит человека в списке людей по индексу
        /// </summary>
        /// <param name="index">Индекс человека в списке.</param>
        /// <returns>Объект класса PersonBase.</returns>
        public PersonBase FindPersonByIndex(int index)
        {
            IsIndexInArray(index);

            return _listOfPersons[index];
        }

        /// <summary>
        /// Функция, которая позволяет проверять индекс в списке.
        /// </summary>
        /// <param name="index">Индекс человека.</param>
        /// <exception cref="IndexOutOfRangeException">Индекс
        /// вышел за пределелы.</exception>
        private void IsIndexInArray(int index)
        {
            if (index < 0 || index >= _listOfPersons.Count)
            {
                throw new IndexOutOfRangeException
                    ("Такого индекса не существует");
            }
        }

        /// <summary>
        /// Функция, которая позволяет очистить список.
        /// </summary>
        public void ClearList()
        {
            _listOfPersons.Clear();
        }
    }
}
