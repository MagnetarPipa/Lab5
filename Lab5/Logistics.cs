using System;

namespace Lab5
{
    /// <summary>
    /// Класс Loqistics,содержащий свойства Logistics и наследующий класс Commerce
    /// </summary>
    internal class Logistics : Commerce
    {
        private string _transportType;
        private string _departureLocation;
        private string _destinationLocation;

        /// <summary>
        /// Сеттер и геттер поля _transportType в котором хранится тип транспорта
        /// </summary>
        public string TransportType
        {
            get => _transportType;
            set
            {
                //Идет проверка является указанная строка является строкой null или пустой строкой (""). 
                if (!string.IsNullOrEmpty(value))
                {
                    _transportType = value.Trim();
                }
                else
                {
                    throw new FormatException("Неверный транспорт");
                }
            }
        }

        /// <summary>
        /// Сеттер и геттер поля _departureLocation в котором хранится место отбытия транспорта
        /// </summary>
        public string DepartureLocation
        {
            get => _departureLocation;
            set
            {
                //Идет проверка является указанная строка является строкой null или пустой строкой (""). 
                if (!string.IsNullOrEmpty(value))
                {
                    _departureLocation = value.Trim();
                }
                else
                {
                    throw new FormatException("Неправильное место отправления");
                }
            }
        }

        /// <summary>
        /// Сеттер и геттер поля _destinationLocation в котором хранится место доставки
        /// </summary>
        public string DestinationLocation
        {
            get => _destinationLocation;
            set
            {
                //Идет проверка является указанная строка является строкой null или пустой строкой (""). 
                if (!string.IsNullOrEmpty(value))
                {
                    _destinationLocation = value.Trim();
                }
                else
                {
                    throw new FormatException("Неправильное место назначения");
                }
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса Logistics и наследует свойства Commerce.
        /// </summary>
        /// <param name="transportType">Транспорт который будет везти товар</param>
        /// <param name="departureLocation">Место отправления со склада</param>
        /// <param name="destinationLocation">Место назаначения</param>
        /// <param name="name">Название товара</param>
        /// <param name="price">Цена товара</param>
        /// <param name="isAvailable">Наличе товара</param>
        /// <param name="location">Местонахождение склада</param>
        public Logistics(string transportType, string departureLocation, string destinationLocation, string name, double price, bool isAvailable, string location) : base(name, price, isAvailable, location)
        {
            TransportType = transportType;
            DepartureLocation = departureLocation;
            DestinationLocation = destinationLocation;
        }

        public override string ToString()
        {
            return "Логистика:\n" + base.ToString() + $"\nТип транспорта: {TransportType};\nМесто отправления: {DepartureLocation};\nМесто назначения: {DestinationLocation}\n\n";
        }
    }
}
