using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchIsEasy.UI.Wpf.Model.Data
{
    public class AccountDBContext : DbContext
    {

        public DbSet<Accounts> Accounts { get; set; }


        public AccountDBContext()
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile(@"Model\Data\appsettings.json", optional: true, reloadOnChange: true);

            var config = builder.Build();

            string connectingString = config.GetConnectionString(@"DefaultConnection");

            var options = optionsBuilder.UseMySql(connectingString, new MySqlServerVersion(new Version(8, 0, 28)));

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Map entities to tables


            modelBuilder.Entity<Accounts>().ToTable("Accounts");


            #endregion


            #region Configure Primary Keys


            modelBuilder.Entity<Accounts>().HasKey(patient => patient.Id).HasName("PK_Id");

            modelBuilder.Entity<Accounts>().HasCharSet("Utf8");

           


            #endregion


            #region Configure indexes

            
            modelBuilder.Entity<Accounts>().HasIndex(patient => patient.Id).HasDatabaseName("Idx_Primary").IsUnique();

            modelBuilder.Entity<Accounts>().HasIndex(patient => patient.Login).HasDatabaseName("Login").IsFullText();

            modelBuilder.Entity<Accounts>().HasIndex(patient => patient.Password).HasDatabaseName("Password").IsFullText();

            modelBuilder.Entity<Accounts>().HasIndex(patient => patient.Name).HasDatabaseName("Name").IsFullText();

            modelBuilder.Entity<Accounts>().HasIndex(patient => patient.Surname).HasDatabaseName("Surname").IsFullText();


            #endregion


            #region Configure columns table Patient


            modelBuilder.Entity<Accounts>().Property(patient => patient.Id).HasColumnType("INT UNSIGNED NOT NULL").IsRequired();

            modelBuilder.Entity<Accounts>().Property(patient => patient.Login).HasColumnType("varchar(64)").IsRequired();

            modelBuilder.Entity<Accounts>().Property(patient => patient.Password).HasColumnType("varchar(64)").IsRequired();

            modelBuilder.Entity<Accounts>().Property(patient => patient.Name).HasColumnType("varchar(64)").IsRequired();

            modelBuilder.Entity<Accounts>().Property(patient => patient.Surname).HasColumnType("varchar(64)").IsRequired();

            modelBuilder.Entity<Accounts>().Property(patient => patient.Telephone).HasColumnType("INT UNSIGNED NOT NULL").IsRequired();


            #endregion




        }



    }
}
