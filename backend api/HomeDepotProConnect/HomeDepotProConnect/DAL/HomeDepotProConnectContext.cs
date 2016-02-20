using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HomeDepotProConnect.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HomeDepotProConnect.DAL
{
    public class HomeDepotProConnectContext : DbContext
    {
        public HomeDepotProConnectContext() : base("HomeDepotProConnect")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

       

        public DbSet<Pros> Pros { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<AreaOfExpertise> AreaOfExpertise { get; set; }

        public DbSet<QuestionAndAnswers> QuestionAndAnswers { get; set; }

        public DbSet<RelatedQuestionAnswer> RelatedQuestionAnswer { get; set; }

        public DbSet<LeaderBoard> LeaderBoard { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


    }
}