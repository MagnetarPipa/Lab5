using System;

namespace Lab5
{
    /// <summary>
    ///  Класс Commerce общую информацию об бизнесах, а так же содержит массив который хранит различные услуги или товары.
    /// </summary>
    internal class Commerce
    {
        
        private BusinessInfo[] _business;

        public Commerce()
        {
            _business = new BusinessInfo[0];
        }

        /// <summary>
        /// Добавление объекта в массив.
        /// </summary>
        /// <param name="business">Экземпляр класса BusinessInfo или производных от него классов.</param>
        public void AddBusiness(BusinessInfo business)
        {
            Array.Resize(ref _business, _business.Length + 1);
            _business[_business.Length - 1] = business;
        }


        /// <summary>
        /// Удаление объекта из массива.
        /// </summary>
        /// <param name="personId">Индекс элемента который необходимо удалить.</param>
        public void DeleteBusiness(int businessId)
        {
            if (businessId >= 0 && businessId < _business.Length)
            {
                Array.Copy(_business, businessId + 1, _business, businessId, _business.Length - businessId - 1);
                Array.Resize(ref _business, _business.Length - 1);
            }
        }

        /// <summary>
        /// Редактирование элемента массива заменой одного на переданный новый.
        /// </summary>
        /// <param name="index">Индекс заменяемого элемента.</param>
        /// <param name="element">Новый отредактированый элемент.</param>
        public void EditBusiness(uint index, BusinessInfo element)
        {
            if (index >= 0 && index < _business.Length)
            {
                _business[index] = element;
            }
            else
            {
                throw new FormatException("Такого идекса в массиве не существует");
            }
        }
        
        public BusinessInfo[] BusinessInfo => _business;


    }
}
