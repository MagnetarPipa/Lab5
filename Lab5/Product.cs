using System;

namespace Lab5
{
    /// <summary>
    /// Класс Product,содержащий свойства Product и наследующий класс BusinessInfo
    /// </summary>
    internal class Product : BusinessInfo
    {

        private string _productID;
        private int _stockQuantity;
        private string _manufacturer;
        private const byte MIN_QUANTITY = 0;
        private const int MAX_QUANTITY = 500;
        private const byte MIN_ID_LENGHT = 5;
        private const byte MAX_ID_LENGHT = 20;

        /// <summary>
        /// Сеттер и геттер поля _productID
        /// </summary>
        public string ProductID
        {
            get => _productID;
            set
            {

                if (!string.IsNullOrEmpty(value) && value.Length >= MIN_ID_LENGHT && value.Length <= MAX_ID_LENGHT)
                {
                    _productID = (value.ToUpper()).Trim();
                }
                else
                {
                    throw new FormatException("Неправильный id");
                }
            }
        }

        /// <summary>
        /// Сеттер и геттер поля _stockQuantity
        /// </summary>
        public int StockQuantity
        {
            get => _stockQuantity;
            set
            {
                if (value >= MIN_QUANTITY && value <= MAX_QUANTITY)
                {
                    _stockQuantity = value;
                }
                else
                {
                    throw new FormatException("Неверное количество");
                }
            }
        }

        /// <summary>
        /// Сеттер и геттер поля _manufacturer
        /// </summary>
        public string Manufacturer
        {

            get => _manufacturer;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    _manufacturer = value.Trim();
                }
                else
                {
                    throw new FormatException("Неверная производитель");
                }
            }
        }

        /// <summary>
        ///  Создает новый экземпляр класса Product и наследует свойства BusinessInfo.
        /// </summary>
        /// <param name="productID">ID товара</param>
        /// <param name="stockQuantity">Количество товара на складе</param>
        /// <param name="manufacturer">Производитель товара</param>
        /// <param name="name">Название товара</param>
        /// <param name="price">Цена товара</param>
        /// <param name="isAvailable">Наличие товара на складе</param>
        /// <param name="location">Местанахождение товара</param>
        public Product(string productID, int stockQuantity, string manufacturer, string name, double price, bool isAvailable, string location) : base(name, price, isAvailable, location)
        {
            ProductID = productID;
            StockQuantity = stockQuantity;
            Manufacturer = manufacturer;
        }
        public override string ToString()
        {
            return "Товар:\n" + base.ToString() + $"\nID товара: {ProductID};\nКоличество товара на складе: {StockQuantity};\nПроизводитель: {Manufacturer}\n\n";
        }
    }
}
