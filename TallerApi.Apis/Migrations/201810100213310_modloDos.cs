namespace TallerApi.Apis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modloDos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Publicacions", "Usuario", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Publicacions", "Descripcion", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Publicacions", "Descripcion", c => c.String());
            AlterColumn("dbo.Publicacions", "Usuario", c => c.String());
        }
    }
}
