namespace INFRAESTRUCTURE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Codigo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Codigo");
        }
    }
}
