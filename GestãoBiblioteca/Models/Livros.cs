using System.ComponentModel.DataAnnotations;

namespace GestãoBiblioteca.Models
{
    public class Livros
    {
    
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        [Display(Name = "Título")]
        public string? Titulo { get; set; }
        [MaxLength(100)]
        [Required]
        public string? Editora { get; set; }
        [MaxLength(100)]
        [Required]
        public string? Autor { get; set; }
        [Display(Name = "Número de registro")]
        [Required]
        public long NumeroRegistro { get; set; }
        [Required]
        public bool Emprestado { get; set; }
    
    }
}
