namespace WindowsEmpleados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Legajo = c.Int(nullable: false),
                        Departamento_DepartamentoId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamentoes", t => t.Departamento_DepartamentoId)
                .Index(t => t.Departamento_DepartamentoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleadoes", "Departamento_DepartamentoId", "dbo.Departamentoes");
            DropIndex("dbo.Empleadoes", new[] { "Departamento_DepartamentoId" });
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Departamentoes");
        }
    }
}
