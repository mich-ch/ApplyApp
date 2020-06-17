using ApplyApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Repository
{
    public class CrmDbContext : DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<HRManager> HRManagers { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }

        public static readonly string connectionString = "Data Source=localhost;" +
                                                         "Initial Catalog = ApplyApp; " +
                                                         "Integrated Security = True;";

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
