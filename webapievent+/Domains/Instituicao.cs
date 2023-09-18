using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapievent_.Domains
{
    [Table ("Instituicao")]
    [Index(nameof(CNPJ), IsUnique = true )]
    public class Instituicao
    {
        private const bool V = true;

        [Key]
        public Guid IdInstituicao { get; set; } = Guid.NewGuid();

        [Column(TypeName ="CHAR(14)")]
        [Required(ErrorMessage ="Cnpj obrigatorio!")]
        [StringLength(14)]
        public string? CNPJ { get; set; }


        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage ="O endereco e obrigatorio!")]
        public string?  Endereco { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome fantasia e obrigatorio!")]
        public string? NomeFantasia { get; set; }
    }
}
