using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Context
{
    public class VideoRentalContext : DbContext
    {

        public VideoRentalContext(): base("name=VideoRentalContext")
        {
        }

        public DbSet<Aktorzy> Aktorzy { get; set; }
        public DbSet<Cennik> Cennik { get; set; }
        public DbSet<Filmy> Filmy { get; set; }
        public DbSet<FilmyAktorzy> FilmyAktorzy { get; set; }
        public DbSet<Gatunki> Gatunki { get; set; }
        public DbSet<Klienci> Klienci { get; set; }
        public DbSet<Plyty> Plyty { get; set; }
        public DbSet<RodzajeRol> RodzajeRol { get; set; }
        public DbSet<Wypozyczenia> Wypozyczenia { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Aktorzy>()
        //        .Property(e => e.NazwiskoAktora)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Aktorzy>()
        //        .Property(e => e.ImieAktora)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Aktorzy>()
        //        .HasMany(e => e.FilmyAktorzy)
        //        .WithRequired(e => e.Aktorzy)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Cennik>()
        //        .Property(e => e.RodzajFilmu)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Cennik>()
        //        .Property(e => e.OplataZa1Dzien)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<Filmy>()
        //        .Property(e => e.TytulFilmu)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Filmy>()
        //        .Property(e => e.RokProdukcji)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Filmy>()
        //        .Property(e => e.RodzajFilmu)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Filmy>()
        //        .HasMany(e => e.Gatunki)
        //        .WithMany(e => e.Filmy)
        //        .Map(m => m.ToTable("FilmyGatunki").MapLeftKey("IdFilmu").MapRightKey("Gatunek"));

        //    modelBuilder.Entity<FilmyAktorzy>()
        //        .Property(e => e.Rola)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Gatunki>()
        //        .Property(e => e.Gatunek)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Klienci>()
        //        .Property(e => e.NrDowodu)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Klienci>()
        //        .Property(e => e.NazwiskoKlienta)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Klienci>()
        //        .Property(e => e.ImieKlienta)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Klienci>()
        //        .Property(e => e.Plec)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Klienci>()
        //        .Property(e => e.Ulica)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Klienci>()
        //        .Property(e => e.KodPocztowy)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Klienci>()
        //        .Property(e => e.Miejscowosc)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Klienci>()
        //        .Property(e => e.Haslo)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RodzajeRol>()
        //        .Property(e => e.Rola)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Wypozyczenia>()
        //        .Property(e => e.OplataZa1Dzien)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<Wypozyczenia>()
        //        .Property(e => e.Doplata)
        //        .HasPrecision(10, 4);
        //}
    }
}