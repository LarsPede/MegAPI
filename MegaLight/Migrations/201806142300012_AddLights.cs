namespace ContactList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLights : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Light",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Controller = c.Boolean(nullable: false),
                        Animation = c.String(),
                        Brightness = c.Single(nullable: false),
                        Color_R = c.Int(nullable: false),
                        Color_G = c.Int(nullable: false),
                        Color_B = c.Int(nullable: false),
                        Color_A = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Light");
        }
    }
}
