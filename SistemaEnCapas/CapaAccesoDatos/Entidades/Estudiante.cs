namespace CapaAccesoDatos.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estudiante")]
    public partial class Estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiante()
        {
            Curso = new HashSet<Curso>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(150)]
        public string Apellidos { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        public bool Activo { get; set; }

        [Required]
        [StringLength(1)]
        public string Genero { get; set; }

        public double? Altura { get; set; }

        public decimal? Salario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Curso> Curso { get; set; }
    }
}
