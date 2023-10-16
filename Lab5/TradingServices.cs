using System;

namespace Lab5
{
    /// <summary>
    ///  Класс TradingServices представляет собой массив из информационных вспомогательных классов товаров и услуг
    ///  и содержит общую информацию об торговых услугах.
    /// </summary>
    internal class TradingServices
    {
        
        private Commerce[] _trading_services;

        public TradingServices()
        {
            _trading_services = new Commerce[0];
        }

        /// <summary>
        /// Добавление объекта в массив.
        /// </summary>
        /// <param name="business">Экземпляр класса Commerce или производных от него классов.</param>
        public void AddBusiness(Commerce business)
        {
            Array.Resize(ref _trading_services, _trading_services.Length + 1);
            _trading_services[_trading_services.Length - 1] = business;
        }


        /// <summary>
        /// Удаление объекта из массива.
        /// </summary>
        /// <param name="personId">Индекс элемента который необходимо удалить.</param>
        public void DeleteBusiness(int businessId)
        {
            if (businessId >= 0 && businessId < _trading_services.Length)
            {
                Array.Copy(_trading_services, businessId + 1, _trading_services, businessId, _trading_services.Length - businessId - 1);
                Array.Resize(ref _trading_services, _trading_services.Length - 1);
            }
        }

        /// <summary>
        /// Редактирование элемента массива заменой одного на переданный новый.
        /// </summary>
        /// <param name="index">Индекс заменяемого элемента.</param>
        /// <param name="element">Новый отредактированый элемент.</param>
        public void EditBusiness(uint index, Commerce element)
        {
            if (index >= 0 && index < _trading_services.Length)
            {
                _trading_services[index] = element;
            }
            else
            {
                throw new FormatException("Такого идекса в массиве не существует");
            }
        }
        
        public Commerce[] BusinessInfo => _trading_services;


    }
}
