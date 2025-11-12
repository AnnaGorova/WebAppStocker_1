namespace WebAppStocker_1.Entities
{
    /// <summary>
    /// Представляє посилання на магазин додатків (App Store, Google Play тощо)
    /// Використовується для відображення кнопок завантаження додатків у футері та інших секціях
    /// </summary>
    public class StoreLink
    {
        /// <summary>
        /// URL-адреса для переходу до магазину
        /// </summary>
        /// <example>"https://apps.apple.com/app/id123456"</example>
        public string Url { get; set; }

        /// <summary>
        /// CSS-клас іконки Font Awesome для візуального представлення магазину
        /// </summary>
        /// <example>"fas fa-apple-alt" - для App Store</example>
        /// <example>"fas fa-play" - для Google Play</example>
        public string Icon { get; set; }

        /// <summary>
        /// Невеликий текст, що розміщується над назвою магазину
        /// Зазвичай використовується для текстів типу "Download on", "Get it on"
        /// </summary>
        /// <example>"Download on the"</example>
        /// <example>"Get it on"</example>
        public string SmallText { get; set; }

        /// <summary>
        /// Назва магазину додатків для відображення
        /// </summary>
        /// <example>"App Store"</example>
        /// <example>"Google Play"</example>
        public string StoreName { get; set; }
    }
}