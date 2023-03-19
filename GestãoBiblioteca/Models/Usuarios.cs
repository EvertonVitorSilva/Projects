using System.ComponentModel.DataAnnotations;

namespace GestãoBiblioteca.Models
{
    public class Usuarios
    {
    
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string? Nome { get; set; }
        [MaxLength(100)]
        [Display(Name = "Endereço")]
        [Required]
        public string? Endereco { get; set;}
        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Data de inscrição")]
        public DateTime DataInscricao { get; set; }
        [MaxLength(100)]
        [Required]
        public string? Login { get; set; }
        [MinLength(8)]
        [Required]
        public string? Password { get; set; }
        [MaxLength(11)]
        [MinLength(11)]
        [Required]
        public string? CPF { get; set;}
    
    }
}
