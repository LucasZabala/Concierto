using Concierto.Logic.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto.Logic.Data
{
    public class ConciertoDbContext : IdentityDbContext<User, Rol, string>
    {
        public ConciertoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Lugar> Lugares { get; set; }
        public DbSet<Cantante> Cantantes { get; set; }
        public DbSet<Boleto> Boletos { get; set; }
        //Table union
        public DbSet<EventoCantante> EventosCantantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Evento y Lugar
            modelBuilder.Entity<Evento>()
                .HasOne(e => e.Lugar)
                .WithMany(l => l.Eventos)
                .HasForeignKey(e => e.IdLugar)
                .IsRequired();

            //Evento y Boleto
            modelBuilder.Entity<Evento>()
                .HasMany(e => e.Boletos)
                .WithOne(b => b.Evento)
                .HasForeignKey(b => b.IdEvento);

            //Evento y Cantante
            modelBuilder.Entity<EventoCantante>()
                .HasKey(ec => new { ec.IdEvento, ec.IdCantante });

            modelBuilder.Entity<EventoCantante>()
                .HasOne(ec => ec.Evento)
                .WithMany(e => e.EventoCantantes)
                .HasForeignKey(ec => ec.IdEvento);

            modelBuilder.Entity<EventoCantante>()
                .HasOne(ec => ec.Cantante)
                .WithMany(c => c.EventosCantante)
                .HasForeignKey(ec => ec.IdCantante);

            //Usuario y Boleto
            modelBuilder.Entity<User>()
                .HasMany(u => u.Boletos)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.IdUser);

        }
    }
}
