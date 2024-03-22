using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Class_Management.Models;

public partial class ClassManagementContext : DbContext
{
    public ClassManagementContext()
    {
    }

    public ClassManagementContext(DbContextOptions<ClassManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ClassSchedule> ClassSchedules { get; set; }

    public virtual DbSet<DayOfWeek> DayOfWeeks { get; set; }

    public virtual DbSet<Mark> Marks { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<TimeOfDay> TimeOfDays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .Build().GetConnectionString("MyExam"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.AttendanceId).HasName("PK__Attendan__8B69263C74903A24");

            entity.ToTable("Attendance");

            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.AttendanceDate).HasColumnType("date");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Class).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK__Attendanc__Class__3B75D760");

            entity.HasOne(d => d.Student).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Attendanc__Stude__3C69FB99");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__Class__CB1927A079774623");

            entity.ToTable("Class");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassEndDate).HasColumnType("date");
            entity.Property(e => e.ClassName).HasMaxLength(50);
            entity.Property(e => e.ClassStartDate).HasColumnType("date");
        });

        modelBuilder.Entity<ClassSchedule>(entity =>
        {
            entity.HasKey(e => new { e.ClassId, e.DayOfWeekId, e.TimeOfDayId }).HasName("PK__ClassSch__D585E76E6FC9440D");

            entity.ToTable("ClassSchedule");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.DayOfWeekId).HasColumnName("DayOfWeekID");
            entity.Property(e => e.TimeOfDayId).HasColumnName("TimeOfDayID");

            entity.HasOne(d => d.Class).WithMany(p => p.ClassSchedules)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ClassSche__Class__49C3F6B7");

            entity.HasOne(d => d.DayOfWeek).WithMany(p => p.ClassSchedules)
                .HasForeignKey(d => d.DayOfWeekId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ClassSche__DayOf__4AB81AF0");

            entity.HasOne(d => d.TimeOfDay).WithMany(p => p.ClassSchedules)
                .HasForeignKey(d => d.TimeOfDayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ClassSche__TimeO__4BAC3F29");
        });

        modelBuilder.Entity<DayOfWeek>(entity =>
        {
            entity.HasKey(e => e.DayOfWeekId).HasName("PK__DayOfWee__01AA8DDFA0C82641");

            entity.ToTable("DayOfWeek");

            entity.Property(e => e.DayOfWeekId).HasColumnName("DayOfWeekID");
            entity.Property(e => e.DayName).HasMaxLength(20);
        });

        modelBuilder.Entity<Mark>(entity =>
        {
            entity.HasKey(e => e.MarkId).HasName("PK__Mark__4E30D3469915E907");

            entity.ToTable("Mark");

            entity.Property(e => e.MarkId).HasColumnName("MarkID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.Mark1)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Mark");
            entity.Property(e => e.MarkDate).HasColumnType("date");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Class).WithMany(p => p.Marks)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK__Mark__ClassID__3F466844");

            entity.HasOne(d => d.Student).WithMany(p => p.Marks)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Mark__StudentID__403A8C7D");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payment__9B556A583E50B9DD");

            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PaymentDate).HasColumnType("date");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Student).WithMany(p => p.Payments)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Payment__Payment__4316F928");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52A795BECC980");

            entity.ToTable("Student");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.ContactInfo).HasMaxLength(200);
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(10);
        });

        modelBuilder.Entity<TimeOfDay>(entity =>
        {
            entity.HasKey(e => e.TimeOfDayId).HasName("PK__TimeOfDa__866813FF2F1FEF80");

            entity.ToTable("TimeOfDay");

            entity.Property(e => e.TimeOfDayId).HasColumnName("TimeOfDayID");
            entity.Property(e => e.TimeSlot).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
