using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebAppStocker_1.Entities
{
    public class TopBarItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Назва")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        [Display(Name = "Значення")]
        public string Value { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "Тип")]
        public string Type { get; set; } = string.Empty; // "contact", "dashboard", "auth"

        [Required]
        [StringLength(50)]
        [Display(Name = "Підтип")]
        public string SubType { get; set; } = string.Empty; // "phone", "email", "address", "menu-item"

        [Required]
        [Display(Name = "Порядок")]
        public int Order { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Активний")]
        public bool IsActive { get; set; } = true;

        [StringLength(200)]
        [Display(Name = "Href")]
        public string? Href{ get; set; }

        [StringLength(50)]
        [Display(Name = "Іконка")]
        public string? Icon { get; set; }
    }
}