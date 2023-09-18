using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapievent_.Domains
{
    public class Evento
    {
        [Key]

        public Guid GuidId { get; set; } = Guid.NewGuid();

        [Column(TypeName= " DATE")]
        [Required(ErrorMessage = "Dat do evento obrigatoria!")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName= "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do Evento Obrigatorio!")]
        public string? NomeEvento { get; set; }


        [Column(TypeName= "TEXT")]
        [Required(ErrorMessage = "A descricao e obrigatoria!")]
        public string? Descricao { get; set; }

        //ref tabela intituicao 
        [Required(ErrorMessage = "Instituicao obrigatoria!")]
        public Guid IdInstituicao { get; set; }


        [ForeignKey(nameof(IdInstituicao))]
        public Instituicao? Instituicao { get; set; }

    }
}
