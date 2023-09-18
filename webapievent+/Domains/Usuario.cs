using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapievent_.Domains
{

    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        private const bool V = true;

        [Key] 

        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName= "VARCHAR(100)")]
        [Required(ErrorMessage ="Nome do usuario obrigatorio!")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do email obrigatorio!")]
        public string? Email { get; set; }

        [Column(TypeName= "CHAR(60)")]
        [Required(ErrorMessage ="Senha obrigatoria!")]
        [StringLength(60, MinimumLength =6, ErrorMessage = "Senha deve conter de 6 a 60 caracteres!")]
        public string? Senha { get; set;}

        //ref. table TipoUsuario = FK
        [Required(ErrorMessage ="Informe o tipo de usuario!")]
        public string? IdTipoUsuario { get; set;}

        [ForeignKey(nameof(IdTipoUsuario))]
        public TiposUsuario? TiposUsuario { get; set;}

        private static object CNPJ()
        {
            throw new NotImplementedException();
        }

        private static string[] IsUnique()
        {
            throw new NotImplementedException();
        }
    }
}
