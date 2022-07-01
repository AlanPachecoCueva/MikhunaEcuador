namespace MikhunaAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Calificacions", "RecetaID", "dbo.Recetas");
            DropForeignKey("dbo.Favoritos", "RecetaID", "dbo.Recetas");
            DropForeignKey("dbo.Calificacions", "UsuarioID", "dbo.Usuarios");
            DropForeignKey("dbo.Comentarios", "RecetaID", "dbo.Recetas");
            DropForeignKey("dbo.Comentarios", "UsuarioID", "dbo.Usuarios");
            DropForeignKey("dbo.RecetasTerminadas", "RecetaID", "dbo.Recetas");
            CreateTable(
                "dbo.Calificacions",
                c => new
                    {
                        CalificacionID = c.Int(nullable: false, identity: true),
                        NumeroEstrellas = c.Single(nullable: false),
                        RecetaID = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CalificacionID)
                .ForeignKey("dbo.Recetas", t => t.RecetaID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioID);
            
            CreateTable(
                "dbo.Recetas",
                c => new
                    {
                        RecetaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Duracion = c.Single(nullable: false),
                        UrlImagen = c.String(maxLength: 400),
                        CalificacionPromedio = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.RecetaID);
            
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        ComentarioID = c.Int(nullable: false, identity: true),
                        Contenido = c.String(),
                        RecetaID = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ComentarioID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioID)
                .ForeignKey("dbo.Recetas", t => t.RecetaID);
            
            AddForeignKey("dbo.Favoritos", "RecetaID", "dbo.Recetas", "RecetaID");
            AddForeignKey("dbo.RecetasTerminadas", "RecetaID", "dbo.Recetas", "RecetaID");
            DropTable("dbo.Calificacions");
            DropTable("dbo.Recetas");
            DropTable("dbo.Comentarios");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        ComentarioID = c.Int(nullable: false, identity: true),
                        Contenido = c.String(),
                        RecetaID = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ComentarioID);
            
            CreateTable(
                "dbo.Recetas",
                c => new
                    {
                        RecetaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Duracion = c.Single(nullable: false),
                        UrlImagen = c.String(maxLength: 400),
                        CalificacionPromedio = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.RecetaID);
            
            CreateTable(
                "dbo.Calificacions",
                c => new
                    {
                        CalificacionID = c.Int(nullable: false, identity: true),
                        NumeroEstrellas = c.Single(nullable: false),
                        RecetaID = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CalificacionID);
            
            DropForeignKey("dbo.RecetasTerminadas", "RecetaID", "dbo.Recetas");
            DropForeignKey("dbo.Favoritos", "RecetaID", "dbo.Recetas");
            DropForeignKey("dbo.Comentarios", "RecetaID", "dbo.Recetas");
            DropForeignKey("dbo.Comentarios", "UsuarioID", "dbo.Usuarios");
            DropForeignKey("dbo.Calificacions", "UsuarioID", "dbo.Usuarios");
            DropForeignKey("dbo.Calificacions", "RecetaID", "dbo.Recetas");
            DropTable("dbo.Comentarios");
            DropTable("dbo.Recetas");
            DropTable("dbo.Calificacions");
            AddForeignKey("dbo.RecetasTerminadas", "RecetaID", "dbo.Recetas", "RecetaID");
            AddForeignKey("dbo.Comentarios", "UsuarioID", "dbo.Usuarios", "UsuarioID");
            AddForeignKey("dbo.Comentarios", "RecetaID", "dbo.Recetas", "RecetaID");
            AddForeignKey("dbo.Calificacions", "UsuarioID", "dbo.Usuarios", "UsuarioID");
            AddForeignKey("dbo.Favoritos", "RecetaID", "dbo.Recetas", "RecetaID");
            AddForeignKey("dbo.Calificacions", "RecetaID", "dbo.Recetas", "RecetaID");
        }
    }
}
