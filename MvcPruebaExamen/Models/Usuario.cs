﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPruebaExamen.Models
{
    [Table("USERS")]
    public class Usuario
    {
        [Key]
        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("PASS")]
        public byte[] Password { get; set; }

        [Column("SALT")]
        public string Salt { get; set; }

        [Column("IMAGEN")]
        public string Imagen { get; set; }

        
    }
}
