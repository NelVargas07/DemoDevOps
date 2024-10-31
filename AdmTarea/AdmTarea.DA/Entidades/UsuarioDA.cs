using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Entidades
{
    [Table("USUARIO")]
    public class UsuarioDA
    {

            [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Required]
            public long ID { get; set; }

            [Required]
            public string NOMBRE { get; set; }

            [Required]
            public string APELLIDOS { get; set; }

            public string CORREO { get; set; }

            public string PASSWORD { get; set; }

    }
}
