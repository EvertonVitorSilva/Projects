using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class Automoveis
    {
    
        public int ID { get; set; }
        [MaxLength(100)]
        [Required]
        public string? Modelo { get; set; }
        [MaxLength(100)]
        [Required]
        public string? Montadora { get; set; }
        [MaxLength(100)]
        [Required]
        public string? Tipo { get; set; }
        [MaxLength(100)]
        [Required]
        public string? KM { get; set; }


    
    }
}
