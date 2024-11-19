using System.ComponentModel.DataAnnotations;
namespace EmployeesMVC.Models.ViewModels

{
    public class CreateVM
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(4, 4, ErrorMessage = "Svar rätt på 'What is 2 + 2?'")]
        public int BotCheck { get; set; }
        [Required]
        [Display(Name = "Company ID")]
        public int CompanyId { get; set; }


    }
}
