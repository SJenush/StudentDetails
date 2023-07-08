﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentDetails.Data;

#nullable disable

namespace StudentDetails.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230707103724_lolo")]
    partial class lolo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentDetails.Models.Domains.Marks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<int>("RollNumber")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stud_Marks");
                });

            modelBuilder.Entity("StudentDetails.Models.Domains.School", b =>
                {
                    b.Property<int>("School_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("School_Code"));

                    b.Property<string>("School_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("School_Code");

                    b.ToTable("M_School");
                });

            modelBuilder.Entity("StudentDetails.Models.Domains.Student", b =>
                {
                    b.Property<int>("Stud_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Stud_id"));

                    b.Property<string>("Acd_Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<string>("Contact_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Roll_No")
                        .HasColumnType("int");

                    b.Property<int>("School_Code")
                        .HasColumnType("int");

                    b.Property<string>("Stud_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Stud_id");

                    b.HasIndex("School_Code")
                        .IsUnique();

                    b.ToTable("Stud_detail");
                });

            modelBuilder.Entity("StudentDetails.Models.Domains.Student", b =>
                {
                    b.HasOne("StudentDetails.Models.Domains.School", "School")
                        .WithMany()
                        .HasForeignKey("School_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentDetails.Models.Domains.Student", null)
                        .WithOne()
                        .HasForeignKey("StudentDetails.Models.Domains.Student", "School_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });
#pragma warning restore 612, 618
        }
    }
}
