namespace TournamentVoting.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    internal sealed class Configuration : DbMigrationsConfiguration<TournamentVoting.Models.TournamentVotingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TournamentVoting.Models.TournamentVotingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.PreTestingExperimenterRankings.AddOrUpdate(
                new PreTestingExperimenterRanking {Id = 1 , Age= 0, Education = "null",
                    Gender = "Male", Image1Rank = 0, Image2Rank = 0, Image3Rank = 0, Image4Rank = 0}
                );
            context.PreTestingExperimenterRankings.AddOrUpdate(
            new PreTestingExperimenterRanking {Id = 1 , Age= 0, Education = "null",
                    Gender = "Female", Image1Rank = 0, Image2Rank = 0, Image3Rank = 0, Image4Rank = 0}
                );
        }
    }
}
