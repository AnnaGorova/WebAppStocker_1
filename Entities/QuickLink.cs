namespace WebAppStocker_1.Entities
{
    /// <summary>
    /// Модель окремого швидкого посилання
    /// </summary>
    public class QuickLink
    {
        /// <summary>
        /// Текст посилання
        /// </summary>
        /// <example>"About Us"</example>
        public string Text { get; set; }

        /// <summary>
        /// URL-адреса посилання
        /// </summary>
        /// <example>"/about"</example>
        public string Url { get; set; }

        /// <summary>
        /// CSS-клас іконки Font Awesome
        /// </summary>
        /// <example>"fas fa-angle-right"</example>
        public string Icon { get; set; }
    }
}