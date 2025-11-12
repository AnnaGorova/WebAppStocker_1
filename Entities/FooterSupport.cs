namespace WebAppStocker_1.Entities
{
    /// <summary>
    /// Модель, що представляє секцію підтримки та політик у футері
    /// </summary>
    public class FooterSupport
    {
        /// <summary>
        /// Заголовок секції підтримки
        /// </summary>
        /// <example>"Support"</example>
        public string Title { get; set; }

        /// <summary>
        /// Список посилань підтримки та політик
        /// </summary>
        public List<SupportLink> Links { get; set; } = new List<SupportLink>();
    }
}