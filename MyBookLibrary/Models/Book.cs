using System.ComponentModel.DataAnnotations;

namespace MyBookLibrary.Models
{
    public class Book
    {
    
        public int ID { get; set; }
        [Required]
        [Display(Name = "Título")]
        [MaxLength(100)]
        public string? Titulo { get; set; }
        [Required]
        [Display(Name = "Gênero")]
        [MaxLength(50)]
        public string? Genero { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        [Required]
        public DateTime DateLancamento { get; set; }
        [Required]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        [Required]
        public int Nota { get; set; }
    
    }
}
