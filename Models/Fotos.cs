using System.ComponentModel.DataAnnotations;

namespace TrabalhoFinalAndrew.Models
{
    public class Fotos
    {
        [Key]
        public int idFotos { get; set; }

        [Key]
        public int idAlbum { get; set; }

        [Display]
        public string? descricao { get; set; }
        
        [Required,Display]
        public string? foto { get; set; }

        [Required,StringLength(72)]
        public string? nome { get; set; }

        [Required]
        public string? datafotos { get; set; }
        
    }
}