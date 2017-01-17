using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HomestayManagementSystem.Database;

namespace HomestayManagementSystem.Migrations
{
    [DbContext(typeof(HomestayContext))]
    [Migration("20170106190548_Migration1")]
    partial class Migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomestayManagementSystem.Models.Homestay", b =>
                {
                    b.Property<int>("HomestayId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<string>("Language");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("PostCode")
                        .IsRequired();

                    b.Property<string>("ProfileFileName");

                    b.Property<string>("Remark");

                    b.Property<int>("Room");

                    b.Property<string>("Students");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("UpdatedUserId");

                    b.Property<string>("VideoUrl");

                    b.HasKey("HomestayId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Homestay");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.HomestayContract", b =>
                {
                    b.Property<int>("HomestayContractId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ContractDate")
                        .IsRequired();

                    b.Property<string>("ContractFileName");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<int>("HomestayId");

                    b.Property<bool>("IsContractActive");

                    b.Property<string>("Remark");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("UpdatedUserId");

                    b.HasKey("HomestayContractId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("HomestayId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("HomestayContract");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.HomestayEvaluation", b =>
                {
                    b.Property<int>("HomestayEvaluationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<int>("CriminalRecordCheck");

                    b.Property<int>("EnglishProficiency");

                    b.Property<DateTime?>("EvaluationDate")
                        .IsRequired();

                    b.Property<string>("EvaluationFileName");

                    b.Property<int>("FinancialStability");

                    b.Property<int>("HomestayId");

                    b.Property<int>("HostingExperience");

                    b.Property<bool>("IsEvaluationActive");

                    b.Property<int>("LivingSpace");

                    b.Property<int>("Location");

                    b.Property<int>("PaymentFlexibility");

                    b.Property<int>("QualityOfLivingSpace");

                    b.Property<string>("Remark");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("UpdatedUserId");

                    b.HasKey("HomestayEvaluationId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("HomestayId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("HomestayEvaluation");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.HomestayHouseHold", b =>
                {
                    b.Property<int>("HomestayHouseHoldId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("Gender");

                    b.Property<int>("HomestayId");

                    b.Property<bool>("IsHouseHoldActive");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Remark");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("UpdatedUserId");

                    b.HasKey("HomestayHouseHoldId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("HomestayId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("HomestayHouseHold");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.HomestayPoliceCheck", b =>
                {
                    b.Property<int>("HomestayPoliceCheckId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<int>("HomestayId");

                    b.Property<bool>("IsPoliceCheckActive");

                    b.Property<DateTime?>("PoliceCheckDate")
                        .IsRequired();

                    b.Property<string>("PoliceCheckFileName");

                    b.Property<string>("Remark");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("UpdatedUserId");

                    b.HasKey("HomestayPoliceCheckId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("HomestayId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("HomestayPoliceCheck");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.HomestayStudent", b =>
                {
                    b.Property<int>("HomestayStudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<DateTime?>("Arrival")
                        .IsRequired();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<DateTime?>("Departure")
                        .IsRequired();

                    b.Property<DateTime?>("DueDate")
                        .IsRequired();

                    b.Property<int>("HomestayId");

                    b.Property<bool>("IsActive");

                    b.Property<decimal>("PaidAmount");

                    b.Property<DateTime?>("PaidDate");

                    b.Property<string>("Remark");

                    b.Property<int>("StudentId");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("UpdatedUserId");

                    b.HasKey("HomestayStudentId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("HomestayId");

                    b.HasIndex("StudentId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("HomestayStudent");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.LoginHistory", b =>
                {
                    b.Property<int>("LoginHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<string>("IpAddress");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("UpdatedUserId");

                    b.HasKey("LoginHistoryId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("LoginHistory");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("PermissionId");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.Site", b =>
                {
                    b.Property<int>("SiteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("SiteId");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.SiteLocation", b =>
                {
                    b.Property<int>("SiteLocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("SiteId");

                    b.HasKey("SiteLocationId");

                    b.HasIndex("SiteId");

                    b.ToTable("SiteLocation");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("Gender");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("PostCode")
                        .IsRequired();

                    b.Property<string>("ProfileFileName");

                    b.Property<string>("Remark");

                    b.Property<int>("SiteLocationId");

                    b.Property<string>("StudentNo")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("UpdatedUserId");

                    b.HasKey("StudentId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("SiteLocationId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("LoginId")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("PermissionId");

                    b.Property<string>("Remark");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("UpdatedUserId");

                    b.HasKey("UserId");

                    b.HasAlternateKey("LoginId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.UserSiteLocation", b =>
                {
                    b.Property<int>("UserSiteLocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<bool>("IsActive");

                    b.Property<int>("SiteLocationId");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("UpdatedUserId");

                    b.Property<int>("UserId");

                    b.HasKey("UserSiteLocationId");

                    b.HasAlternateKey("UserId", "SiteLocationId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("SiteLocationId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("UserSiteLocation");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.Homestay", b =>
                {
                    b.HasOne("HomestayManagementSystem.Models.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("HomestayManagementSystem.Models.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.HomestayContract", b =>
                {
                    b.HasOne("HomestayManagementSystem.Models.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("HomestayManagementSystem.Models.Homestay", "Homestay")
                        .WithMany("HomestayContracts")
                        .HasForeignKey("HomestayId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HomestayManagementSystem.Models.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.HomestayEvaluation", b =>
                {
                    b.HasOne("HomestayManagementSystem.Models.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("HomestayManagementSystem.Models.Homestay", "Homestay")
                        .WithMany("HomestayEvaluations")
                        .HasForeignKey("HomestayId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HomestayManagementSystem.Models.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.HomestayHouseHold", b =>
                {
                    b.HasOne("HomestayManagementSystem.Models.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("HomestayManagementSystem.Models.Homestay", "Homestay")
                        .WithMany("HomestayHouseHolds")
                        .HasForeignKey("HomestayId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HomestayManagementSystem.Models.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.HomestayPoliceCheck", b =>
                {
                    b.HasOne("HomestayManagementSystem.Models.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("HomestayManagementSystem.Models.Homestay", "Homestay")
                        .WithMany("HomestayPoliceChecks")
                        .HasForeignKey("HomestayId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HomestayManagementSystem.Models.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.HomestayStudent", b =>
                {
                    b.HasOne("HomestayManagementSystem.Models.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("HomestayManagementSystem.Models.Homestay", "Homestay")
                        .WithMany("HomestayStudents")
                        .HasForeignKey("HomestayId");

                    b.HasOne("HomestayManagementSystem.Models.Student", "Student")
                        .WithMany("HomestayStudents")
                        .HasForeignKey("StudentId");

                    b.HasOne("HomestayManagementSystem.Models.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.LoginHistory", b =>
                {
                    b.HasOne("HomestayManagementSystem.Models.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("HomestayManagementSystem.Models.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.SiteLocation", b =>
                {
                    b.HasOne("HomestayManagementSystem.Models.Site", "Site")
                        .WithMany("SiteLocations")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.Student", b =>
                {
                    b.HasOne("HomestayManagementSystem.Models.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("HomestayManagementSystem.Models.SiteLocation", "SiteLocation")
                        .WithMany()
                        .HasForeignKey("SiteLocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HomestayManagementSystem.Models.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.User", b =>
                {
                    b.HasOne("HomestayManagementSystem.Models.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("HomestayManagementSystem.Models.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HomestayManagementSystem.Models.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("HomestayManagementSystem.Models.UserSiteLocation", b =>
                {
                    b.HasOne("HomestayManagementSystem.Models.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("HomestayManagementSystem.Models.SiteLocation", "SiteLocation")
                        .WithMany("UserSiteLocations")
                        .HasForeignKey("SiteLocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HomestayManagementSystem.Models.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");

                    b.HasOne("HomestayManagementSystem.Models.User", "User")
                        .WithMany("UserSiteLocations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
