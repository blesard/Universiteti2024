using System.ComponentModel.DataAnnotations;
using Universiteti2024.Validime;

namespace Universiteti2024.Models
{
    public class Kursi
    {
        [Required(ErrorMessage = "Emri i kursit eshte i detyrueshem.")]
        [SimbolFillimi("Kursi-", ErrorMessage = "Emri i kursit duhet te filloje me Kursi-")]
        [Display(Name = "Emri i Kursit")]
        public string EmriKursit { get; set; }

        [Required(ErrorMessage = "Pershkrimi eshte i detyrueshem.")]
        public string Pershkrimi { get; set; }
    }
}