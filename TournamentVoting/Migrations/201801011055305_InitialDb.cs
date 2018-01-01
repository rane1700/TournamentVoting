namespace TournamentVoting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PreTestingExperimenterRankings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Gender = c.String(nullable: false),
                        Education = c.String(nullable: false),
                        Image1Rank = c.Int(nullable: false),
                        Image2Rank = c.Int(nullable: false),
                        Image3Rank = c.Int(nullable: false),
                        Image4Rank = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PreTestingExperimenterRankings");
        }
    }
}
