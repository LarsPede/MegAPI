namespace ContactList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Newest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Amount", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Average", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Average", "DateTime");
            DropColumn("dbo.Amount", "DateTime");
        }
    }
}
