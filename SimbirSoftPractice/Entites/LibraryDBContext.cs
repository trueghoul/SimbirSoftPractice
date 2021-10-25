using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SimbirSoftPractice.Entites
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("author");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name");

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middle_name");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.AuthorId)
                    .IsRequired()
                    .HasColumnName("author_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId);
            });

            modelBuilder.Entity<BookGenre>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.GenreId });

                entity.ToTable("book_genre");

                entity.Property(e => e.BookId)
                    .HasColumnName("book_id");

                entity.Property(e => e.GenreId)
                    .HasColumnName("genre_id");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookGenres)
                    .HasForeignKey(d => d.BookId);

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.BookGenres)
                    .HasForeignKey(d => d.GenreId);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genre");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasColumnName("genre_name");
            });

            modelBuilder.Entity<LibraryCard>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.PersonId });

                entity.ToTable("library_card");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.LibraryCards)
                    .HasForeignKey(d => d.BookId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.LibraryCards)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.BirhDate)
                    .HasColumnType("date")
                    .HasColumnName("birh_date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name");

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middle_name");
            });
        }
    }
}
