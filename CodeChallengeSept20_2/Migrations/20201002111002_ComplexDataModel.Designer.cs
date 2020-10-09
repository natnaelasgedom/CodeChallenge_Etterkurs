﻿// <auto-generated />
using System;
using CodeChallengeSept20_2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeChallengeSept20_2.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20201002111002_ComplexDataModel")]
    partial class ComplexDataModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("CodeChallengeSept20_2.Models.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClosestRelativeEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosestRelativeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosestRelativePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("ContactInfo");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.CourseAssignment", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.HasKey("CourseID", "InstructorID");

                    b.HasIndex("InstructorID");

                    b.ToTable("CourseAssignment");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<int?>("InstructorID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.OfficeAssignment", b =>
                {
                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InstructorID");

                    b.ToTable("OfficeAssignment");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.ContactInfo", b =>
                {
                    b.HasOne("CodeChallengeSept20_2.Models.Student", "Student")
                        .WithOne("ContactInfo")
                        .HasForeignKey("CodeChallengeSept20_2.Models.ContactInfo", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Course", b =>
                {
                    b.HasOne("CodeChallengeSept20_2.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.CourseAssignment", b =>
                {
                    b.HasOne("CodeChallengeSept20_2.Models.Course", "Course")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeChallengeSept20_2.Models.Instructor", "Instructor")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Department", b =>
                {
                    b.HasOne("CodeChallengeSept20_2.Models.Instructor", "Administrator")
                        .WithMany()
                        .HasForeignKey("InstructorID");

                    b.Navigation("Administrator");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Enrollment", b =>
                {
                    b.HasOne("CodeChallengeSept20_2.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeChallengeSept20_2.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.OfficeAssignment", b =>
                {
                    b.HasOne("CodeChallengeSept20_2.Models.Instructor", "Instructor")
                        .WithOne("OfficeAssignment")
                        .HasForeignKey("CodeChallengeSept20_2.Models.OfficeAssignment", "InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Course", b =>
                {
                    b.Navigation("CourseAssignments");

                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Department", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Instructor", b =>
                {
                    b.Navigation("CourseAssignments");

                    b.Navigation("OfficeAssignment");
                });

            modelBuilder.Entity("CodeChallengeSept20_2.Models.Student", b =>
                {
                    b.Navigation("ContactInfo");

                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
