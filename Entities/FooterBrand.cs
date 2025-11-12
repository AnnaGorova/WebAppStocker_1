namespace WebAppStocker_1.Entities
{

    /// <summary>
    /// Модель, що представляє брендову секцію футера сайту
    /// Включає логотип, опис компанії та посилання на мобільні додатки
    /// </summary>
    /// <remarks>
    /// Ця модель використовується для відображення першої колонки футера з інформацією про бренд
    /// </remarks>
    public class FooterBrand
    {
        /// <summary>
        /// Текст логотипу компанії, що відображається поряд з іконкою
        /// </summary>
        /// <example>"Stocker"</example>
        /// <example>"MyCompany"</example>
        public string LogoText { get; set; }

        /// <summary>
        /// CSS-клас іконки Font Awesome для логотипу компанії
        /// </summary>
        /// <example>"fas fa-search-dollar" - іконка пошуку з доларом</example>
        /// <example>"fas fa-rocket" - іконка ракети</example>
        public string LogoIcon { get; set; }

        /// <summary>
        /// Короткий опис компанії або сервісу для відображення у футері
        /// Зазвичай містить 1-2 речення про діяльність компанії
        /// </summary>
        /// <example>"Dolor amet sit justo amet elitr clita ipsum elitr est. Lorem ipsum dolor sit amet, consectetur adipiscing..."</example>
        public string Description { get; set; }

        /// <summary>
        /// Посилання та інформація для завантаження додатку з Apple App Store
        /// </summary>
        /// <seealso cref="StoreLink"/>
        public StoreLink AppStore { get; set; }

        /// <summary>
        /// Посилання та інформація для завантаження додатку з Google Play Store
        /// </summary>
        /// <seealso cref="StoreLink"/>
        public StoreLink GooglePlay { get; set; }
    }
}