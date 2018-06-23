namespace ContactList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Amount",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Up = c.Single(nullable: false),
                        Down = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Average",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Up = c.Single(nullable: false),
                        Down = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Battery",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BatteryId = c.String(),
                        Voltage = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Battery");
            DropTable("dbo.Average");
            DropTable("dbo.Amount");
        }
    }
}
