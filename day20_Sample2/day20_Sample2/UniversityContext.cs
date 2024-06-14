using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace day20_Sample2;

public partial class UniversityContext : DbContext
{
    public UniversityContext()
    {
    }

    public UniversityContext(DbContextOptions<UniversityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblGender> TblGenders { get; set; }

    public virtual DbSet<TblPerson> TblPeople { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=098C01D87E98538;Initial Catalog=University;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblEmplo__3214EC07E76C0222");

            entity.ToTable("tblEmployee");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TblGender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblGende__3214EC076898B9F6");

            entity.ToTable("tblGender");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Gender).HasMaxLength(50);
        });

        modelBuilder.Entity<TblPerson>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPerson");

            entity.Property(e => e.Email).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
