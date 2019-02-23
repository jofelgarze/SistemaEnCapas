namespace CapaAccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LineaBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MateriaId = c.Int(nullable: false),
                        HorarioInicio = c.DateTime(),
                        HorarioFin = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materia", t => t.MateriaId)
                .Index(t => t.MateriaId);
            
            CreateTable(
                "dbo.Estudiante",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 150, unicode: false),
                        Apellidos = c.String(nullable: false, maxLength: 150, unicode: false),
                        FechaNacimiento = c.DateTime(nullable: false, storeType: "date"),
                        Activo = c.Boolean(nullable: false),
                        Genero = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        Altura = c.Double(),
                        Salario = c.Decimal(precision: 10, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EstudianteCurso",
                c => new
                    {
                        CursoId = c.Int(nullable: false),
                        EstudianteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CursoId, t.EstudianteId })
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Estudiante", t => t.EstudianteId, cascadeDelete: true)
                .Index(t => t.CursoId)
                .Index(t => t.EstudianteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Curso", "MateriaId", "dbo.Materia");
            DropForeignKey("dbo.EstudianteCurso", "EstudianteId", "dbo.Estudiante");
            DropForeignKey("dbo.EstudianteCurso", "CursoId", "dbo.Curso");
            DropIndex("dbo.EstudianteCurso", new[] { "EstudianteId" });
            DropIndex("dbo.EstudianteCurso", new[] { "CursoId" });
            DropIndex("dbo.Curso", new[] { "MateriaId" });
            DropTable("dbo.EstudianteCurso");
            DropTable("dbo.Materia");
            DropTable("dbo.Estudiante");
            DropTable("dbo.Curso");
        }
    }
}
