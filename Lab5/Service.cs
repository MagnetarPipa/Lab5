using System;
using System.Text.RegularExpressions;

namespace Lab5
{
    /// <summary>
    /// Класс Service,содержащий свойства Service и наследующий класс Commerce
    /// </summary>
    internal class Service : Commerce
    {
        private double _rating;
        private string _contactInformation;
        private string _category;
        private const byte MIN_RATING = 0;
        private const int MAX_RATING = 5;
        private readonly Regex stringRegCheck = new Regex(@"^[A-Za-z0-9._%+-]+@gmail\.com$");


        /// <summary>
        /// Сеттер и геттер поля _rating в котором хранится рейтинг услуги
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                //Идет проверка на то,что рейтинг не может быть ниже 0(отрицательным) или выше максимальной оценки 5.
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
        /// Сеттер и геттер поля _contactInformation в котором хранится адрес электронной почты услуги 
        /// </summary>
        public string ContactInformation
        {
            get => _contactInformation;
            set
            {
                // Идет проверка является указанная строка является строкой null или пустой строкой("").
                // А также на то,что адрес пишется в формате "sometext@gmail.com" с помощью регулярного выражения.
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
        /// Сеттер и геттер поля _category в котором хранится категория услуги
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
        /// Создает новый экземпляр класса Service и наследует свойства Commerce.
        /// </summary>
        /// <param name="rating">Рейтинг услуги</param>
        /// <param name="contactinformation">Адрес электронной почты</param>
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
