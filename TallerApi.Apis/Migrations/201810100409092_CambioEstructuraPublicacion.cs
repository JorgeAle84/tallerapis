namespace TallerApi.Apis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioEstructuraPublicacion : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Publicacions", newName: "Publiacion");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Publiacion", newName: "Publicacions");
        }
    }
}
