namespace CapaAccesoDatos.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Curso")]
    public partial class Curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            Estudiante = new HashSet<Estudiante>();
        }

        public int Id { get; set; }

        public int MateriaId { get; set; }

        public int ProfesorId { get; set; }

        public DateTime? HorarioInicio { get; set; }

        public DateTime? HorarioFin { get; set; }

        public virtual Materia Materia { get; set; }

        public virtual Profesor Profesor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estudiante> Estudiante { get; set; }
    }
}
