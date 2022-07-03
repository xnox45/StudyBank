using ClassLibrarySBank.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySBank.Data
{
        public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<HistoricTransfer> TransfBanks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Colocando a conexão ConectionString aqui usando o banco DESKTOP-LDJ6DU0\\SQLEXPRESS

            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=StudyBankApp;Data Source=DESKTOP-LDJ6DU0\\SQLEXPRESS");
            
        }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HistoricTransfer>(entity =>
            {
                entity.HasKey(e => new { e.ID});

            });
        }
       
    }
}
