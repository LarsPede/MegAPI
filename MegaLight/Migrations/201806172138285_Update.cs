namespace ContactList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Light", "Brightness", c => c.Int(nullable: false));
            DropColumn("dbo.Battery", "Current");
            DropColumn("dbo.Battery", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Battery", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Battery", "Current", c => c.Boolean());
            AlterColumn("dbo.Light", "Brightness", c => c.Single(nullable: false));
        }
    }
}
