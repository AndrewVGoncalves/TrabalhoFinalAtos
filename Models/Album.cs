using System.ComponentModel.DataAnnotations;

namespace TrabalhoFinalAndrew.Models
{
    public class Album
    {
        [Key]
        public int idAlbum { get; set; }


        [Display]

        public string? descricao { get; set; }


        [Required,StringLength(72)]
        public string? nome { get; set; }
    }
}
