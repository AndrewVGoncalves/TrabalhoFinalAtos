using System.ComponentModel.DataAnnotations;

namespace TrabalhoFinalAndrew.Models
{
    public class Pessoa_Fotos
    {
        [Key]
        public int idFotos { get; set; }

        [Key]
        public int idPessoa { get; set; }
    }
}
