namespace AxadoCarrier.Infrastructure.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carriers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CarrierId = c.Guid(nullable: false),
                        Username = c.String(),
                        RateValue = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carriers", t => t.CarrierId, cascadeDelete: true)
                .Index(t => t.CarrierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rates", "CarrierId", "dbo.Carriers");
            DropIndex("dbo.Rates", new[] { "CarrierId" });
            DropTable("dbo.Rates");
            DropTable("dbo.Carriers");
        }
    }
}
