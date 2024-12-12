﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _3312_Final_Project.Models;

#nullable disable

namespace _3312_Final_Project.Migrations
{
    [DbContext(typeof(CareerEventDbContext))]
    [Migration("20241212222742_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("_3312_Final_Project.Models.CareerEvent", b =>
                {
                    b.Property<int>("CareerEventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventLocation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("TEXT");

                    b.HasKey("CareerEventID");

                    b.ToTable("CareerEvents");
                });

            modelBuilder.Entity("_3312_Final_Project.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("GradYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("ResumeReview")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("_3312_Final_Project.Models.StudentRegistration", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CareerEventID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID", "CareerEventID");

                    b.HasIndex("CareerEventID");

                    b.ToTable("StudentRegistrations");
                });

            modelBuilder.Entity("_3312_Final_Project.Models.StudentRegistration", b =>
                {
                    b.HasOne("_3312_Final_Project.Models.CareerEvent", "CareerEvent")
                        .WithMany("StudentRegistrations")
                        .HasForeignKey("CareerEventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_3312_Final_Project.Models.Student", "Student")
                        .WithMany("StudentRegistrations")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CareerEvent");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("_3312_Final_Project.Models.CareerEvent", b =>
                {
                    b.Navigation("StudentRegistrations");
                });

            modelBuilder.Entity("_3312_Final_Project.Models.Student", b =>
                {
                    b.Navigation("StudentRegistrations");
                });
#pragma warning restore 612, 618
        }
    }
}
