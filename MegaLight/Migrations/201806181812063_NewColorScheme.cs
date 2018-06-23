namespace ContactList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColorScheme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Light", "Brightness", c => c.Single(nullable: false));
            DropColumn("dbo.Light", "Color_A");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Light", "Color_A", c => c.Single(nullable: false));
            AlterColumn("dbo.Light", "Brightness", c => c.Int(nullable: false));
        }
    }
}
