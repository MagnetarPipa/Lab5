using System;

namespace Lab5
{
    /// <summary>
    /// Класс BusinessInfo содержащий общую информацию об коммерции
    /// </summary>
    internal class BusinessInfo
    {

        private string _name;
        private double _price;
        private bool _isAvailable;
        private string _location;

        /// <summary>
        /// Сеттер и геттер поля _name
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value.Trim();
                }
                else
                {
                    throw new FormatException("Неправильное название");
                }
            }

        }

        /// <summary>
        /// Сеттер и геттер поля _price
        /// </summary>
        public double Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException("Цена не может быть отрицательной.");
                }

            }
        }

        /// <summary>
        /// Сеттер и геттер поля _isAvailable
        /// </summary>
        public bool IsAvailable { get => _isAvailable; set => _isAvailable = value; }

        /// <summary>
        /// Сеттер и геттер поля _location
        /// </summary>
        public string Location
        {
            get => _location;
            set
            {

                if (!string.IsNullOrEmpty(value))
                {

                    _location = value.Trim();
                }
                else
                {
                    throw new FormatException("Неверная локация");
                }
            }

        }

        /// <summary>
        ///  Создает новый экземпляр класса Commerce с заданными значениями.
        /// </summary>
        /// <param name="name">Название комерческих услуг и т.д.</param>
        /// <param name="price">Цена</param>
        /// <param name="isAvailable">Наличие</param>
        /// <param name="location">Местонахождение</param>
        public BusinessInfo(string name, double price, bool isAvailable, string location)
        {
            Name = name;
            Price = price;
            IsAvailable = isAvailable;
            Location = location;
        }


        public override string ToString()
        {
            return $"Название: {Name};\nЦена: {Price};\nНаличие:{IsAvailable};\nАдресс: {Location};";
        }
    }
}
