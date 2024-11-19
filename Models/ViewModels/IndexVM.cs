using System.ComponentModel.DataAnnotations;

namespace EmployeesMVC.Models.ViewModels
{
    public class IndexVM
    {
        [Required(ErrorMessage = "Enter a name")]
        public required string Name { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Fel format på mailadressen")]
        //[Required(ErrorMessage = "Måste fyllas i")]
        public required string Email { get; set; }
        public int Id { get; set; }

        public bool ShowAsHighlighted { get; set; }
    }
}
