namespace WebAppStocker_1.Entities
{
    /// <summary>
    /// Модель, що представляє секцію контактної інформації у футері
    /// </summary>
    public class FooterContact
    {
        /// <summary>
        /// Заголовок секції контактів
        /// </summary>
        /// <example>"Contact Info"</example>
        public string Title { get; set; }

        /// <summary>
        /// Контактна інформація (адреса, email, телефон тощо)
        /// </summary>
        public ContactInfo ContactInfo { get; set; }

        /// <summary>
        /// Список соціальних мереж
        /// </summary>
        public List<SocialLink> SocialLinks { get; set; } = new List<SocialLink>();
    }
    
}
