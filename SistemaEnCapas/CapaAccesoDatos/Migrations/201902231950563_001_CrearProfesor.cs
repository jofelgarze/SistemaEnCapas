namespace CapaAccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001_CrearProfesor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profesor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 150),
                        Apellidos = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Curso", "ProfesorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Curso", "ProfesorId");
            AddForeignKey("dbo.Curso", "ProfesorId", "dbo.Profesor", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Curso", "ProfesorId", "dbo.Profesor");
            DropIndex("dbo.Curso", new[] { "ProfesorId" });
            DropColumn("dbo.Curso", "ProfesorId");
            DropTable("dbo.Profesor");
        }
    }
}
