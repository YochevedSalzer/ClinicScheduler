using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Do;

public partial class ClinicContext : DbContext
{
    public ClinicContext()
    {
    }

    public ClinicContext(DbContextOptions<ClinicContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\Project\\Project\\DAL\\DB\\Clinic.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Doctor__3214EC0739CCFE9A");

            entity.ToTable("Doctor");

            entity.Property(e => e.Email).HasMaxLength(1);
            entity.Property(e => e.FirstName).HasMaxLength(1);
            entity.Property(e => e.LastName).HasMaxLength(1);

            entity.HasOne(d => d.DoctorTypeNavigation).WithMany(p => p.Doctors)
                .HasForeignKey(d => d.DoctorType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Doctor_Type");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Patient__3214EC07EE1D6EF2");

            entity.ToTable("Patient");

            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(1);
            entity.Property(e => e.FirstName).HasMaxLength(1);
            entity.Property(e => e.LastName).HasMaxLength(1);
            entity.Property(e => e.PatientId).HasMaxLength(1);
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Type__3214EC0712DF6A32");

            entity.ToTable("Type");

            entity.Property(e => e.Type1)
                .HasMaxLength(1)
                .HasColumnName("type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
