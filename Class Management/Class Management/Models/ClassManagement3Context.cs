using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Class_Management.Models;

public partial class ClassManagement3Context : DbContext
{
    public ClassManagement3Context()
    {
    }

    public ClassManagement3Context(DbContextOptions<ClassManagement3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ClassSchedule> ClassSchedules { get; set; }

    public virtual DbSet<ClassStudent> ClassStudents { get; set; }

    public virtual DbSet<DayOfWeek> DayOfWeeks { get; set; }

    public virtual DbSet<Mark> Marks { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<TimeOfDay> TimeOfDays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server =(local); database = ClassManagement3;uid=sa;pwd=12345678; TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.AttendanceId).HasName("PK__Attendan__8B69263C4A9A504D");

            entity.ToTable("Attendance");

            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.AttendanceDate).HasColumnType("date");
            entity.Property(e => e.ClassStudentId).HasColumnName("ClassStudentID");

            entity.HasOne(d => d.ClassStudent).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.ClassStudentId)
                .HasConstraintName("FK__Attendanc__Class__3F466844");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__Class__CB1927A008E3155F");

            entity.ToTable("Class");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassEndDate).HasColumnType("date");
            entity.Property(e => e.ClassName).HasMaxLength(50);
            entity.Property(e => e.ClassStartDate).HasColumnType("date");
        });

        modelBuilder.Entity<ClassSchedule>(entity =>
        {
            entity.HasKey(e => new { e.ClassId, e.DayOfWeekId, e.TimeOfDayId }).HasName("PK__ClassSch__D585E76EA0F14016");

            entity.ToTable("ClassSchedule");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.DayOfWeekId).HasColumnName("DayOfWeekID");
            entity.Property(e => e.TimeOfDayId).HasColumnName("TimeOfDayID");

            entity.HasOne(d => d.Class).WithMany(p => p.ClassSchedules)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ClassSche__Class__4BAC3F29");

            entity.HasOne(d => d.DayOfWeek).WithMany(p => p.ClassSchedules)
                .HasForeignKey(d => d.DayOfWeekId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ClassSche__DayOf__4CA06362");

            entity.HasOne(d => d.TimeOfDay).WithMany(p => p.ClassSchedules)
                .HasForeignKey(d => d.TimeOfDayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ClassSche__TimeO__4D94879B");
        });

        modelBuilder.Entity<ClassStudent>(entity =>
        {
            entity.HasKey(e => e.ClassStudentId).HasName("PK__CLassStu__B814783943026E25");

            entity.ToTable("CLassStudent");

            entity.Property(e => e.ClassStudentId).HasColumnName("ClassStudentID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Class).WithMany(p => p.ClassStudents)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK__CLassStud__Class__3B75D760");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassStudents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__CLassStud__Stude__3C69FB99");
        });

        modelBuilder.Entity<DayOfWeek>(entity =>
        {
            entity.HasKey(e => e.DayOfWeekId).HasName("PK__DayOfWee__01AA8DDFCCFDD86A");

            entity.ToTable("DayOfWeek");

            entity.Property(e => e.DayOfWeekId).HasColumnName("DayOfWeekID");
            entity.Property(e => e.DayName).HasMaxLength(20);
        });

        modelBuilder.Entity<Mark>(entity =>
        {
            entity.HasKey(e => e.MarkId).HasName("PK__Mark__4E30D34623F39FD6");

            entity.ToTable("Mark");

            entity.Property(e => e.MarkId).HasColumnName("MarkID");
            entity.Property(e => e.ClassStudentId).HasColumnName("ClassStudentID");
            entity.Property(e => e.Mark1)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Mark");
            entity.Property(e => e.MarkDate).HasColumnType("date");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.ClassStudent).WithMany(p => p.Marks)
                .HasForeignKey(d => d.ClassStudentId)
                .HasConstraintName("FK__Mark__ClassStude__4222D4EF");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payment__9B556A58E1FF4DAA");

            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ClassStudentId).HasColumnName("ClassStudentID");
            entity.Property(e => e.PaymentDate).HasColumnType("date");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ClassStudent).WithMany(p => p.Payments)
                .HasForeignKey(d => d.ClassStudentId)
                .HasConstraintName("FK__Payment__Payment__44FF419A");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52A7948DA95B2");

            entity.ToTable("Student");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.ContactInfo).HasMaxLength(200);
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(10);
        });

        modelBuilder.Entity<TimeOfDay>(entity =>
        {
            entity.HasKey(e => e.TimeOfDayId).HasName("PK__TimeOfDa__866813FF67CDE38A");

            entity.ToTable("TimeOfDay");

            entity.Property(e => e.TimeOfDayId).HasColumnName("TimeOfDayID");
            entity.Property(e => e.TimeSlot).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
