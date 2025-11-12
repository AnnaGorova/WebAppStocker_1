using System.ComponentModel.DataAnnotations;

namespace WebAppStocker_1.Entities
{
    public class DashboardNavItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Назва")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        [Display(Name = "URL")]
        public string Url { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "Іконка")]
        public string Icon { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Порядок")]
        public int Order { get; set; }

        [Display(Name = "Активний")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Видимий")]
        public bool IsVisible { get; set; } = true;

        [StringLength(50)]
        [Display(Name = "Роль")]
        public string? RequiredRole { get; set; } // Для контролю доступу

        [Display(Name = "Батьківський елемент")]
        public int? ParentId { get; set; }

        // Навігаційна властивість
        public DashboardNavItem? Parent { get; set; }
        public ICollection<DashboardNavItem> Children { get; set; } = new List<DashboardNavItem>();
    }
}
