namespace ContactList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutoIncrement : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Amount");
            DropPrimaryKey("dbo.Average");
            DropPrimaryKey("dbo.Battery");
            DropPrimaryKey("dbo.Light");
            AlterColumn("dbo.Amount", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Average", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Battery", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Light", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Amount", "Id");
            AddPrimaryKey("dbo.Average", "Id");
            AddPrimaryKey("dbo.Battery", "Id");
            AddPrimaryKey("dbo.Light", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Light");
            DropPrimaryKey("dbo.Battery");
            DropPrimaryKey("dbo.Average");
            DropPrimaryKey("dbo.Amount");
            AlterColumn("dbo.Light", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Battery", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Average", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Amount", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Light", "Id");
            AddPrimaryKey("dbo.Battery", "Id");
            AddPrimaryKey("dbo.Average", "Id");
            AddPrimaryKey("dbo.Amount", "Id");
        }
    }
}
