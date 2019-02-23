namespace CapaAccesoDatos.Entidades
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloDbEscuela : DbContext
    {
        public ModeloDbEscuela()
            : base("name=ModeloDbEscuela")
        {
        }

        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Estudiante)
                .WithMany(e => e.Curso)
                .Map(m => m.ToTable("EstudianteCurso").MapLeftKey("CursoId").MapRightKey("EstudianteId"));

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Genero)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Salario)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Materia>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Materia>()
                .HasMany(e => e.Curso)
                .WithRequired(e => e.Materia)
                .WillCascadeOnDelete(false);
        }
    }
}
