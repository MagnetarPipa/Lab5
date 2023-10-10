using System;

namespace Lab5
{
    /// <summary>
    /// Класс Loqistics,содержащий свойства Logistics и наследующий класс BusinessInfo
    /// </summary>
    internal class Logistics : BusinessInfo
    {
        private string _transportType;
        private string _departureLocation;
        private string _destinationLocation;

        /// <summary>
        /// Сеттер и геттер поля _transportType
        /// </summary>
        public string TransportType
        {
            get => _transportType;
            set
            {
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
        /// Сеттер и геттер поля _departureLocation
        /// </summary>
        public string DepartureLocation
        {
            get => _departureLocation;
            set
            {
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
        /// Сеттер и геттер поля _destinationLocation
        /// </summary>
        public string DestinationLocation
        {
            get => _destinationLocation;
            set
            {
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
        /// Создает новый экземпляр класса Logistics и наследует свойства BusinessInfo.
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
