using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Examination.DataAccessLayer.Data;

public partial class ExaminationSystemContext : DbContext
{
    public ExaminationSystemContext()
    {
    }

    public ExaminationSystemContext(DbContextOptions<ExaminationSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Answer> Answers { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<InstructorCourse> InstructorCourses { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionGrade> QuestionGrades { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    public virtual DbSet<StudentQuestionExam> StudentQuestionExams { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=ExaminationSystem;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Answer>(entity =>
        {
            entity.ToTable("Answer");

            entity.HasOne(d => d.Question).WithMany(p => p.Answers)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK_Answer_Question");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("Branch");

            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Course");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptId);

            entity.ToTable("Department");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Branch).WithMany(p => p.Departments)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_Department_Branch");

            entity.HasOne(d => d.Manager).WithMany(p => p.Departments)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK_Department_Instructor");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.ToTable("Exam");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.HasOne(d => d.Course).WithMany(p => p.Exams)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Exam_Course");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InstructorId).HasName("PK_Instractor");

            entity.ToTable("Instructor");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Salary).HasColumnType("money");
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.Branch).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_Instructor_Branch");

            entity.HasOne(d => d.Dept).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Instructor_Department");
        });

        modelBuilder.Entity<InstructorCourse>(entity =>
        {
            entity.HasKey(e => new { e.CourseId, e.InstructorId });

            entity.ToTable("Instructor_Course");

            entity.HasOne(d => d.Course).WithMany(p => p.InstructorCourses)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Instructor_Course_Course");

            entity.HasOne(d => d.Instructor).WithMany(p => p.InstructorCourses)
                .HasForeignKey(d => d.InstructorId)
                .HasConstraintName("FK_Instructor_Course_Instructor");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.ToTable("Question");

            entity.Property(e => e.Type).HasMaxLength(10);

            entity.HasOne(d => d.Course).WithMany(p => p.Questions)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Question_Course");

            entity.HasOne(d => d.Instructor).WithMany(p => p.Questions)
                .HasForeignKey(d => d.InstructorId)
                .HasConstraintName("FK_Question_Instructor");

            entity.HasMany(d => d.Exams).WithMany(p => p.Questions)
                .UsingEntity<Dictionary<string, object>>(
                    "QuestionExam",
                    r => r.HasOne<Exam>().WithMany()
                        .HasForeignKey("ExamId")
                        .HasConstraintName("FK_Question_Exam_Exam"),
                    l => l.HasOne<Question>().WithMany()
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("FK_Question_Exam_Question"),
                    j =>
                    {
                        j.HasKey("QuestionId", "ExamId").HasName("PK_QuestionExam");
                        j.ToTable("Question_Exam");
                    });
        });

        modelBuilder.Entity<QuestionGrade>(entity =>
        {
            entity.HasKey(e => new { e.QuestionId, e.Grade });

            entity.ToTable("Question_Grades");

            entity.Property(e => e.Grade)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Question).WithMany(p => p.QuestionGrades)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK_Question_Grades_Question");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.Fname).HasMaxLength(50);
            entity.Property(e => e.Lname).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.Branch).WithMany(p => p.Students)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Student_Branch");

            entity.HasOne(d => d.Dept).WithMany(p => p.Students)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK_Student_Department");

            entity.HasOne(d => d.Super).WithMany(p => p.InverseSuper)
                .HasForeignKey(d => d.SuperId)
                .HasConstraintName("FK_Student_Student");
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasKey(e => new { e.CourseId, e.StudentId });

            entity.ToTable("Student_Course");

            entity.HasOne(d => d.Course).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Student_Course_Course");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_Student_Course_Student");
        });

        modelBuilder.Entity<StudentQuestionExam>(entity =>
        {
            entity.HasKey(e => new { e.QuestionId, e.StudentId, e.ExamId });

            entity.ToTable("Student_Question_Exam");

            entity.HasOne(d => d.Exam).WithMany(p => p.StudentQuestionExams)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK_Student_Question_Exam_Exam");

            entity.HasOne(d => d.Question).WithMany(p => p.StudentQuestionExams)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK_Student_Question_Exam_Question");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentQuestionExams)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_Student_Question_Exam_Student");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.ToTable("Topic");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Course).WithMany(p => p.Topics)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Topic_Course");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
