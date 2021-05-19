using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CA.Application.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "The name is required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The description is required")]
        [MinLength(5)]
        [MaxLength(500)]
        [DisplayName("Name")]
        public string Description { get; set; }
    }
}