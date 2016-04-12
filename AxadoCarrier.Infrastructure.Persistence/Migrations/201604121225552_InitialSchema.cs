namespace AxadoCarrier.Infrastructure.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSchema : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Votes", newName: "Rates");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Rates", newName: "Votes");
        }
    }
}
