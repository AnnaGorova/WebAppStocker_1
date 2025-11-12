namespace WebAppStocker_1.Entities
{
    /// <summary>
    /// Модель, що представляє секцію копірайту у футері
    /// </summary>
    public class FooterCopyright
    {
        /// <summary>
        /// Рік копірайту
        /// </summary>
        /// <example>2024</example>
        public int CopyrightYear { get; set; }

        /// <summary>
        /// Назва сайту
        /// </summary>
        /// <example>"Stocker"</example>
        public string SiteName { get; set; }

        /// <summary>
        /// Посилання на сайт
        /// </summary>
        /// <example>"/"</example>
        public string SiteUrl { get; set; }

        /// <summary>
        /// Інформація про дизайнера/шаблон
        /// </summary>
        public TemplateCredit TemplateCredit { get; set; }
        /// <summary>
        /// Модель кредитів шаблону
        /// </summary>
    }  
}
