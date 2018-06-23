namespace ContactList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDateTimes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Battery", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Battery", "DateTime");
        }
    }
}
