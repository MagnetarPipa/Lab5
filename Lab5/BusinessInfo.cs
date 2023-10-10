using System;

namespace Lab5
{
    /// <summary>
    /// Класс содержащий массив коммерции
    /// </summary>
    internal class BusinessInfo
    {

        private BusinessInfo[] _business;
        private Commerce _commerce;

        public BusinessInfo[] BusinessCommerce => _business;

        public Commerce Commerce => _commerce;

        /// <summary>
        /// Создает новый экземпляр класса BusinessInfo, объединяющий экземпляр класса Commerce.
        /// </summary>
        /// <param name="name">Название комерческих услуг и т.д.</param>
        /// <param name="price">Цена</param>
        /// <param name="isAvailable">Наличие</param>
        /// <param name="location">Местонахождение</param>
        public BusinessInfo(string name, double price, bool isAvailable, string location)
        {
            _commerce = new Commerce(name, price, isAvailable, location);
        }
        public BusinessInfo()
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
            if (index >= 0 && index < BusinessCommerce.Length)
            {
                BusinessCommerce[index] = element;
            }
            else
            {
                throw new FormatException("Такого идекса в массиве не существует");
            }
        }
        public override string ToString()
        {
            return $"Название: {_commerce.Name};\nЦена: {_commerce.Price};\nНаличие:{_commerce.IsAvailable};\nАдресс: {_commerce.Location};";
        }
    }
}
