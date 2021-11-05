using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseAPI.DataInit
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pessoas> Pessoass {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Pessoas>()
                .Property(p => p.NomeDoCliente)
               .HasMaxLength(70);






           // modelBuilder.Entity<Pessoas>()
             //   .HasData(

            //new Pessoas { Id=1,NomeDoCliente="Americo Alves",DataDeCadastro=DateTime.Today},
            //new Pessoas { Id=2, NomeDoCliente="Ana Carolina", DataDeCadastro = DateTime.Today },
            //new Pessoas { Id=3, NomeDoCliente="Ricardo Young", DataDeCadastro = DateTime.Today }

            //);
        }
    }
              
}
