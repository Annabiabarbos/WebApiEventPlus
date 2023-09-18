﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapievent_.Domains
{
    [Table ("TiposUsuario")]
    public class TiposUsuario
    {
        [Key]

        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column (TypeName = "VARCHAR(100)")]
        [Required (ErrorMessage = "Titulo do tipo usuario obrigatorio!")]

        public string? Titulo { get; set; }
    }
}
