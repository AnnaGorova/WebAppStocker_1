namespace WebAppStocker_1.Entities
{
    /// <summary>
    /// Модель, що представляє секцію швидких посилань у футері
    /// </summary>
    public class FooterQuickLinks
    {
        /// <summary>
        /// Заголовок секції швидких посилань
        /// </summary>
        /// <example>"Quick Links"</example>
        public string Title { get; set; }

        /// <summary>
        /// Список швидких посилань для відображення
        /// </summary>
        public List<QuickLink> Links { get; set; } = new List<QuickLink>();
    }

}