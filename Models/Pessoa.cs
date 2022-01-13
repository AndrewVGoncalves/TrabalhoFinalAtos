using System.ComponentModel.DataAnnotations;

namespace TrabalhoFinalAndrew.Models
{
    public class Pessoa
    {
        [Key]
        public int idPessoa { get; set; }


        [Display]

        public string? descricao { get; set; }


        [Required, StringLength(72)]
        public string? nome { get; set; }

        [Required, StringLength(72)]
        public string? cargo { get; set; }

        [Required,Range(0,1)]
        public string? cargoadmin { get; set; }
    }
}
