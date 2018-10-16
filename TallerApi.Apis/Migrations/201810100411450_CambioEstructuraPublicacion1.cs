namespace TallerApi.Apis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioEstructuraPublicacion1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Publiacion", newName: "Publicacion");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Publicacion", newName: "Publiacion");
        }
    }
}
