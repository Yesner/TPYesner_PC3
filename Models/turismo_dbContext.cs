using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TPYesner_PC3.Models
{
    public partial class turismo_dbContext : DbContext
    {
        public turismo_dbContext()
        {
        }

        public turismo_dbContext(DbContextOptions<turismo_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Registro> Registros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySql("server=localhost;port=3306;database=turismo_db;uid=root;password=1234", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.35-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Registro>(entity =>
            {
                entity.HasKey(e => e.Idregistro)
                    .HasName("PRIMARY");

                entity.ToTable("registro");

                entity.Property(e => e.Idregistro).HasColumnName("idregistro");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Pais)
                    .HasMaxLength(45)
                    .HasColumnName("pais");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(45)
                    .HasColumnName("telefono");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
