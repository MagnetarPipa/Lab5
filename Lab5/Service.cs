using System;
using System.Text.RegularExpressions;

namespace Lab5
{
    /// <summary>
    /// Класс Service,содержащий свойства Service и наследующий класс BusinessInfo
    /// </summary>
    internal class Service : BusinessInfo
    {
        private double _rating;
        private string _contactInformation;
        private string _category;
        private const byte MIN_RATING = 0;
        private const int MAX_RATING = 5;
        private readonly Regex stringRegCheck = new Regex(@"^\+\d{12}$");

        /// <summary>
        /// Сеттер и геттер поля _rating
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                if (value >= MIN_RATING && value <= MAX_RATING)
                {
                    _rating = value;
                }
                else
                {
                    throw new FormatException("Неверный рейтинг");
                }
            }

        }

        /// <summary>
        /// Сеттер и геттер поля _contactInformation
        /// Номер телефона пишется в формате "+************"
        /// </summary>
        public string ContactInformation
        {
            get => _contactInformation;
            set
            {
                if (!string.IsNullOrEmpty(value) && !stringRegCheck.IsMatch(value))
                {
                    _contactInformation = value.Trim();
                }
                else
                {
                    throw new FormatException("Неверно введенные контактные данные");
                }
            }
        }

        /// <summary>
        /// Сеттер и геттер поля _category
        /// </summary>
        public string Category
        {

            get => _category;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _category = value.Trim();
                }
                else
                {
                    throw new FormatException("Неправильная категория");
                }
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса Service и наследует свойства BusinessInfo.
        /// </summary>
        /// <param name="rating">Рейтинг услуги</param>
        /// <param name="contactinformation">Номер телефона</param>
        /// <param name="category">Категория услуги</param>
        /// <param name="name">Название услуги</param>
        /// <param name="price">Цена услуги</param>
        /// <param name="isAvailable">Наличие услуги</param>
        /// <param name="location">Местонахождение услуги</param>
        public Service(double rating, string contactinformation, string category, string name, double price, bool isAvailable, string location) : base(name, price, isAvailable, location)
        {
            Rating = rating;
            ContactInformation = contactinformation;
            Category = category;
        }

        public override string ToString()
        {
            return "Услуга:\n" + base.ToString() + $"\nРейтинг товара: {Rating};\nНомер телефона: {ContactInformation};\nКатегория: {Category}\n\n";
        }
    }
}
