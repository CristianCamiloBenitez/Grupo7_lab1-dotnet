using System.ComponentModel.DataAnnotations;

namespace Grupo7_lab1_dotnet.Models.ViewModels
{
    public class estudioViewModel
    {
        [Required]
        [Display(Name = "Profesion")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nom { get; set; }
    }
}
