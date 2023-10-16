using System;

namespace Lab5
{
    /// <summary>
    /// Базовый класс Commerce содержащий общую информацию об коммерции
    /// </summary>
    internal class Commerce
    {

        private string _name;
        private double _price;
        private bool _isAvailable;
        private string _location;

        /// <summary>
        /// Сеттер и геттер поля _name в котором хранится название товарной услуги
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                //Идет проверка является указанная строка является строкой null или пустой строкой ("").
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
        /// Сеттер и геттер поля _price в котором хранится цена 
        /// </summary>
        public double Price
        {
            get => _price;
            set
            {
                //Идет проверка является ли значение отрицательным,тк цена не может быть таковой.
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
        /// Сеттер и геттер поля _isAvailable в котором хранится наличие товара(true-товар есть в наличии,false-товар закончился).
        /// </summary>
        public bool IsAvailable { get => _isAvailable; set => _isAvailable = value; }

        /// <summary>
        /// Сеттер и геттер поля _location в котором хранится местонахождение товарной услуги.
        /// </summary>
        public string Location
        {
            get => _location;
            set
            {
                //Идет проверка является указанная строка является строкой null или пустой строкой ("").
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
        public Commerce(string name, double price, bool isAvailable, string location)
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
