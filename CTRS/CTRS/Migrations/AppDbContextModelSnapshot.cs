﻿// <auto-generated />
using System;
using CTRS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CTRS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SharedLibrary.Models.HealthEdu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HealthEdu");
                });

            modelBuilder.Entity("SharedLibrary.Models.MedicineCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("DidOrDidntTakeMedicine")
                        .HasColumnType("bit");

                    b.Property<int>("EachDosage")
                        .HasColumnType("int");

                    b.Property<string>("Instruction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OperationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SymptomDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitOfEachDosage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicineChecks");
                });

            modelBuilder.Entity("SharedLibrary.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpectedTreatmentTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicationInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<DateTime>("OperationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Operator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Physician")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RecentWeight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("SharedLibrary.Models.PatientMedicineList", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Dosage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectedReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ShowReasons")
                        .HasColumnType("bit");

                    b.Property<string>("SideEffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("PatientMedicineLists");
                });

            modelBuilder.Entity("SharedLibrary.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abroad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AllergyHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AssessmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BP")
                        .HasColumnType("int");

                    b.Property<double?>("BT")
                        .HasColumnType("float");

                    b.Property<string>("Consciousness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HR")
                        .HasColumnType("int");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<string>("MedicalHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OperationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Operator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RR")
                        .HasColumnType("int");

                    b.Property<string>("SideEffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SharedLibrary.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BedId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.Property<string>("NursingStation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatOr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OperatingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlOt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("SharedLibrary.Models.PatientMedicineList", b =>
                {
                    b.HasOne("SharedLibrary.Models.MedicineCheck", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}