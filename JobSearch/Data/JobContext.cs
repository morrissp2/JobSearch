using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearch.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.Entity;

namespace JobSearch.Data
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;UserId=root;Password=July!17th;database=jobsearch");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().ToTable("Job");
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<Note>().ToTable("Note");
        }
    }
}
