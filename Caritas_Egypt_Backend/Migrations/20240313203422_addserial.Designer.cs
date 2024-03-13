﻿// <auto-generated />
using System;
using Caritas_Egypt_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Caritas_Egypt_Backend.Migrations
{
    [DbContext(typeof(CETICaretasEgyptContext))]
    [Migration("20240313203422_addserial")]
    partial class addserial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.ActivitiesAndEventsFE", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descreption")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("serial")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ActivitiesAndEventsFEs");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.Branch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid?>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TrainerId");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.CoursePrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StudentNationalityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("StudentNationalityId");

                    b.ToTable("CoursePrices");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.DiscriptionList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("DiscriptionLists");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.JobFE", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descreption")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("serial")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JobFEs");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.OurPartnersFE", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descreption")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("serial")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OurPartnersFEs");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.ProgramsCategoryFE", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descreption")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("serial")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProgramsCategoryFEs");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.ProgramsFE", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descreption")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<Guid?>("ProgramsCategoryFEId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("serial")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProgramsCategoryFEId");

                    b.ToTable("ProgramsFEs");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.ProjectsCategoryFE", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descreption")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("serial")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProjectsCategoryFEs");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.ProjectsFE", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mainactivities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Objectives")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Paragraph")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("Partners")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProjectsCategoryFEId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TargetgrouporBeneficiaries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("serial")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectsCategoryFEId");

                    b.ToTable("ProjectsFEs");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NightTrainerInsentive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ServiceTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SessionTimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TrainerInsentive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("languageId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ServiceTypeId");

                    b.HasIndex("SessionTimeId");

                    b.HasIndex("TrainerId");

                    b.HasIndex("languageId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.ServiceType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ServiceType");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.SessionReservations", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("InAbsence")
                        .HasColumnType("bit");

                    b.Property<bool>("InAttend")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SessionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<Guid?>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("coursePriceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TrainerId");

                    b.HasIndex("coursePriceId");

                    b.ToTable("SessionReservation");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.SessionTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("SessionTime");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Age")
                        .HasColumnType("real");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EducationQualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FifthBrotherOrSisterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FifthBrotherOrSisterNationalID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FifthBrotherOrSisterPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstBrotherOrSisterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstBrotherOrSisterNationalID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstBrotherOrSisterPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ForthBrotherOrSisterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForthBrotherOrSisterNationalID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForthBrotherOrSisterPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GotAJobPlacement")
                        .HasColumnType("bit");

                    b.Property<string>("Governorate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InSchool")
                        .HasColumnType("bit");

                    b.Property<string>("JopAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JopPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JopTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JopType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MotherEducationQualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherJopTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherLastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MotherPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherSecondName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumberForWatsapp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondBrotherOrSisterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondBrotherOrSisterNationalID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondBrotherOrSisterPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ServiceCardNumber")
                        .HasColumnType("int");

                    b.Property<string>("ThirdBrotherOrSisterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdBrotherOrSisterNationalID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdBrotherOrSisterPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TypeOfDisabilityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TypeOfDisabilityId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.StudentNationality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("StudentNationalities");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.StudentParent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EducationQualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("JopTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LandPhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MotherEducationQualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherJopTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherLastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MotherPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherSecondName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("StudentParent");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.Trainer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<short>("NationalID")
                        .HasColumnType("smallint");

                    b.Property<bool>("NightTrainer")
                        .HasColumnType("bit");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.TrainingCourses", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descreption")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<Guid?>("branchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("branchId");

                    b.ToTable("TrainingCoursess");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.TrainingFE", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descreption")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("serial")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TrainingFEs");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.TypeOfDisability", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TypeOfDisability");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ChangePassword")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastPasswordChage")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastPasswordChangeBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.Branch", b =>
                {
                    b.HasOne("Caritas_Egypt_Backend.Models.Trainer", null)
                        .WithMany("Branchs")
                        .HasForeignKey("TrainerId");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.CoursePrice", b =>
                {
                    b.HasOne("Caritas_Egypt_Backend.Models.Branch", "branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("Caritas_Egypt_Backend.Models.Service", "service")
                        .WithMany()
                        .HasForeignKey("ServiceId");

                    b.HasOne("Caritas_Egypt_Backend.Models.StudentNationality", "studentNationality")
                        .WithMany()
                        .HasForeignKey("StudentNationalityId");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.ProgramsFE", b =>
                {
                    b.HasOne("Caritas_Egypt_Backend.Models.ProgramsCategoryFE", "programsCategoryFE")
                        .WithMany()
                        .HasForeignKey("ProgramsCategoryFEId");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.ProjectsFE", b =>
                {
                    b.HasOne("Caritas_Egypt_Backend.Models.ProjectsCategoryFE", "projectsCategoryFE")
                        .WithMany()
                        .HasForeignKey("ProjectsCategoryFEId");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.Service", b =>
                {
                    b.HasOne("Caritas_Egypt_Backend.Models.ServiceType", "servicesType")
                        .WithMany()
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caritas_Egypt_Backend.Models.SessionTime", "sessionTime")
                        .WithMany()
                        .HasForeignKey("SessionTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caritas_Egypt_Backend.Models.Trainer", null)
                        .WithMany("Services")
                        .HasForeignKey("TrainerId");

                    b.HasOne("Caritas_Egypt_Backend.Models.Language", "language")
                        .WithMany()
                        .HasForeignKey("languageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.SessionReservations", b =>
                {
                    b.HasOne("Caritas_Egypt_Backend.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.HasOne("Caritas_Egypt_Backend.Models.Trainer", "trainer")
                        .WithMany()
                        .HasForeignKey("TrainerId");

                    b.HasOne("Caritas_Egypt_Backend.Models.CoursePrice", "coursePrice")
                        .WithMany()
                        .HasForeignKey("coursePriceId");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.Student", b =>
                {
                    b.HasOne("Caritas_Egypt_Backend.Models.TypeOfDisability", "TypeOfDisability")
                        .WithMany()
                        .HasForeignKey("TypeOfDisabilityId");
                });

            modelBuilder.Entity("Caritas_Egypt_Backend.Models.TrainingCourses", b =>
                {
                    b.HasOne("Caritas_Egypt_Backend.Models.Branch", "branch")
                        .WithMany()
                        .HasForeignKey("branchId");
                });
#pragma warning restore 612, 618
        }
    }
}
