using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmTarea.DA.Entidades
{
    [Table("Foto")]
    public class FotoDA
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public long Id { get; set; }
        [Required]
        public  byte[] Imagen { get; set; }
        [Required]
        public double Latitud { get; set; }
        [Required]
        public double Longitud { get; set; }
        [Required]
        public string FechaCreacion { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Etiquetas { get; set; }
        [Required]
        public bool Eliminada { get; set; }

    }
}
