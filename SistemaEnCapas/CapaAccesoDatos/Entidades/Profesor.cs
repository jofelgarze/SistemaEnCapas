using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Entidades
{
    [Table("Profesor")]
    public class Profesor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(150)]
        public string Apellidos { get; set; }

        public virtual ICollection<Curso> Curso { get; set; }
    }
}
