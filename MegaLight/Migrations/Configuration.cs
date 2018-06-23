namespace ContactList.Migrations
{
    using MegaLight.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MegaLight.DAL.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MegaLight.DAL.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Settings.AddOrUpdate(new Setting() { Id = 1, Name = "Current Battery", Value = "Echo" });
            context.Settings.AddOrUpdate(new Setting() { Id = 2, Name = "Sms Send for battery", Value = null });
            context.Settings.AddOrUpdate(new Setting() { Id = 3, Name = "Raspberry Pi restarted", Value = "False" });
            context.Settings.AddOrUpdate(new Setting() { Id = 4, Name = "Minus Up Value", Value = "0" });
            context.Settings.AddOrUpdate(new Setting() { Id = 5, Name = "Minus Down Value", Value = "0" });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
