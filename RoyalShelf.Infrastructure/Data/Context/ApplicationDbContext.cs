using Microsoft.EntityFrameworkCore;
using RoyalShelf.Domain.Entities;

namespace RoyalShelf.Infrastructure.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Livro>(entity =>
            {
                entity.ToTable("Livros");

                entity.HasKey(l => l.Id);
                entity.Property(l => l.Id)
                      .ValueGeneratedOnAdd();

                entity.Property(l => l.Titulo)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(l => l.Autor)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(l => l.Isbn)
                      .IsRequired()
                      .HasMaxLength(20);

                entity.Property(l => l.AnoPublicacao)
                      .IsRequired();

                entity.HasIndex(l => l.Isbn)
                      .IsUnique();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");

                entity.HasKey(u => u.Id);
                entity.Property(u => u.Id)
                      .ValueGeneratedOnAdd();

                entity.Property(u => u.Nome)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(u => u.Email)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.HasIndex(u => u.Email)
                      .IsUnique();
            });

            modelBuilder.Entity<Emprestimo>(entity =>
            {
                entity.ToTable("Emprestimos");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioId)
                      .IsRequired();

                entity.Property(e => e.LivroId)
                      .IsRequired();

                entity.Property(e => e.DtEmprestimo)
                      .IsRequired();

                entity.HasOne<User>()
                      .WithMany()
                      .HasForeignKey(e => e.UsuarioId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<Livro>()
                      .WithMany()
                      .HasForeignKey(e => e.LivroId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}

