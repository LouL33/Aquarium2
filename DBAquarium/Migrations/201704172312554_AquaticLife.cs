namespace DBAquarium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AquaticLife : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AquaticLives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        DateAddedToTank = c.DateTime(nullable: false),
                        IsInQuarentine = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AquaticLives");
        }
    }
}
