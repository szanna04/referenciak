using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace cherry_P20QE5.JokeModels
{
    public partial class FunnyDatabaseContext : DbContext
    {
        public FunnyDatabaseContext()
        {
        }

        public FunnyDatabaseContext(DbContextOptions<FunnyDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Band> Bands { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<ColorsAndMeaning> ColorsAndMeanings { get; set; } = null!;
        public virtual DbSet<Film> Films { get; set; } = null!;
        public virtual DbSet<HauntedPlace> HauntedPlaces { get; set; } = null!;
        public virtual DbSet<HistoricalLeader> HistoricalLeaders { get; set; } = null!;
        public virtual DbSet<Joke> Jokes { get; set; } = null!;
        public virtual DbSet<MythicalCreature> MythicalCreatures { get; set; } = null!;
        public virtual DbSet<ShortQuote> ShortQuotes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=FunnyDatabase;User ID=vendeg;Password=12345;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Band>(entity =>
            {
                entity.Property(e => e.BandId).HasColumnName("BandID");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Author).HasMaxLength(255);

                entity.Property(e => e.Genre).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<ColorsAndMeaning>(entity =>
            {
                entity.HasKey(e => e.ColorId)
                    .HasName("PK__ColorsAn__8DA7676D6CD8439B");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Culture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Meaning)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HauntedPlace>(entity =>
            {
                entity.HasKey(e => e.PlaceId)
                    .HasName("PK__HauntedP__D5222B4EF7CCB38F");

                entity.Property(e => e.PlaceId).HasColumnName("PlaceID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricalLeader>(entity =>
            {
                entity.HasKey(e => e.LeaderId)
                    .HasName("PK__Historic__FCCA65F617A96891");

                entity.Property(e => e.LeaderId).HasColumnName("LeaderID");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Joke>(entity =>
            {
                entity.HasKey(e => e.JokeSk);

                entity.ToTable("Joke");

                entity.Property(e => e.JokeSk).HasColumnName("JokeSK");
            });

            modelBuilder.Entity<MythicalCreature>(entity =>
            {
                entity.HasKey(e => e.CreatureId)
                    .HasName("PK__Mythical__ED0E7D524E52AA86");

                entity.Property(e => e.CreatureId).HasColumnName("CreatureID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShortQuote>(entity =>
            {
                entity.HasKey(e => e.QuoteId)
                    .HasName("PK__ShortQuo__AF9688E15B209E53");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.Author)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quote)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
