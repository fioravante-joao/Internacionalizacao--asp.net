namespace MvcAzure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludeEntdadeMedco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CRM = c.String(),
                        Modalidade = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicos");
        }
    }
}
