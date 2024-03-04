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

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<DoctorType> DoctorTypes { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Project\\DAL\\DB\\Clinic.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Appointm__A25C5AA63E5FF67C");

            entity.ToTable("Appointment");

            entity.Property(e => e.AppointmentTime).HasColumnType("datetime");

            entity.HasOne(d => d.DoctorCodeNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.DoctorCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Appointme__Docto__5CD6CB2B");

            entity.HasOne(d => d.PatientCodeNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.PatientCode)
                .HasConstraintName("FK__Appointme__Patie__5DCAEF64");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Doctor__A25C5AA62BF18208");

            entity.ToTable("Doctor");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Id).HasMaxLength(10);
            entity.Property(e => e.LastName).HasMaxLength(50);

            entity.HasOne(d => d.DoctorTypeNavigation).WithMany(p => p.Doctors)
                .HasForeignKey(d => d.DoctorType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Doctor__DoctorTy__4CA06362");
        });

        modelBuilder.Entity<DoctorType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DoctorTy__3214EC077647476B");

            entity.ToTable("DoctorType");

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Patient__A25C5AA63650974B");

            entity.ToTable("Patient");

            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PatientId).HasMaxLength(10);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
