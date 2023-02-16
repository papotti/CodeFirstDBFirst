using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDBFirst.DB;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tabella1> Tabella1 { get; set; }

    public virtual DbSet<Tabella2> Tabella2 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MSI;Database=provaCFDF;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tabella1>(entity =>
        {
            entity.HasKey(e => e.Pk);

            entity.Property(e => e.Pk)
                .ValueGeneratedNever()
                .HasColumnName("PK");
            entity.Property(e => e.Descr)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("DESCR");
        });

        modelBuilder.Entity<Tabella2>(entity =>
        {
            entity.HasKey(e => e.Pk);

            entity.ToTable("tabella2");

            entity.Property(e => e.Pk)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("pk");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("descrizione");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
