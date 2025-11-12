namespace WebAppStocker_1.Entities
{
    /// <summary>
    /// Модель окремого посилання підтримки
    /// </summary>
    public class SupportLink
    {
        /// <summary>
        /// Текст посилання
        /// </summary>
        /// <example>"Privacy Policy"</example>
        public string Text { get; set; }

        /// <summary>
        /// URL-адреса посилання
        /// </summary>
        /// <example>"/privacy"</example>
        public string Url { get; set; }

        /// <summary>
        /// CSS-клас іконки Font Awesome
        /// </summary>
        /// <example>"fas fa-angle-right"</example>
        public string Icon { get; set; }
    }
}
