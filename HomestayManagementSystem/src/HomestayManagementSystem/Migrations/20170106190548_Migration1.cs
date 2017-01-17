using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HomestayManagementSystem.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    PermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    SiteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.SiteId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    LoginId = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.UniqueConstraint("AK_User_LoginId", x => x.LoginId);
                    table.ForeignKey(
                        name: "FK_User_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SiteLocation",
                columns: table => new
                {
                    SiteLocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    SiteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteLocation", x => x.SiteLocationId);
                    table.ForeignKey(
                        name: "FK_SiteLocation_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "SiteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Homestay",
                columns: table => new
                {
                    HomestayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    PostCode = table.Column<string>(nullable: false),
                    ProfileFileName = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Room = table.Column<int>(nullable: false),
                    Students = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true),
                    VideoUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homestay", x => x.HomestayId);
                    table.ForeignKey(
                        name: "FK_Homestay_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Homestay_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoginHistory",
                columns: table => new
                {
                    LoginHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: true),
                    IpAddress = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginHistory", x => x.LoginHistoryId);
                    table.ForeignKey(
                        name: "FK_LoginHistory_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoginHistory_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    PostCode = table.Column<string>(nullable: false),
                    ProfileFileName = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    SiteLocationId = table.Column<int>(nullable: false),
                    StudentNo = table.Column<string>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_SiteLocation_SiteLocationId",
                        column: x => x.SiteLocationId,
                        principalTable: "SiteLocation",
                        principalColumn: "SiteLocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSiteLocation",
                columns: table => new
                {
                    UserSiteLocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    SiteLocationId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSiteLocation", x => x.UserSiteLocationId);
                    table.UniqueConstraint("AK_UserSiteLocation_UserId_SiteLocationId", x => new { x.UserId, x.SiteLocationId });
                    table.ForeignKey(
                        name: "FK_UserSiteLocation_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSiteLocation_SiteLocation_SiteLocationId",
                        column: x => x.SiteLocationId,
                        principalTable: "SiteLocation",
                        principalColumn: "SiteLocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSiteLocation_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSiteLocation_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomestayContract",
                columns: table => new
                {
                    HomestayContractId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContractDate = table.Column<DateTime>(nullable: false),
                    ContractFileName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: true),
                    HomestayId = table.Column<int>(nullable: false),
                    IsContractActive = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomestayContract", x => x.HomestayContractId);
                    table.ForeignKey(
                        name: "FK_HomestayContract_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomestayContract_Homestay_HomestayId",
                        column: x => x.HomestayId,
                        principalTable: "Homestay",
                        principalColumn: "HomestayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomestayContract_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HomestayEvaluation",
                columns: table => new
                {
                    HomestayEvaluationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: true),
                    CriminalRecordCheck = table.Column<int>(nullable: false),
                    EnglishProficiency = table.Column<int>(nullable: false),
                    EvaluationDate = table.Column<DateTime>(nullable: false),
                    EvaluationFileName = table.Column<string>(nullable: true),
                    FinancialStability = table.Column<int>(nullable: false),
                    HomestayId = table.Column<int>(nullable: false),
                    HostingExperience = table.Column<int>(nullable: false),
                    IsEvaluationActive = table.Column<bool>(nullable: false),
                    LivingSpace = table.Column<int>(nullable: false),
                    Location = table.Column<int>(nullable: false),
                    PaymentFlexibility = table.Column<int>(nullable: false),
                    QualityOfLivingSpace = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomestayEvaluation", x => x.HomestayEvaluationId);
                    table.ForeignKey(
                        name: "FK_HomestayEvaluation_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomestayEvaluation_Homestay_HomestayId",
                        column: x => x.HomestayId,
                        principalTable: "Homestay",
                        principalColumn: "HomestayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomestayEvaluation_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HomestayHouseHold",
                columns: table => new
                {
                    HomestayHouseHoldId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    HomestayId = table.Column<int>(nullable: false),
                    IsHouseHoldActive = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomestayHouseHold", x => x.HomestayHouseHoldId);
                    table.ForeignKey(
                        name: "FK_HomestayHouseHold_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomestayHouseHold_Homestay_HomestayId",
                        column: x => x.HomestayId,
                        principalTable: "Homestay",
                        principalColumn: "HomestayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomestayHouseHold_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HomestayPoliceCheck",
                columns: table => new
                {
                    HomestayPoliceCheckId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: true),
                    HomestayId = table.Column<int>(nullable: false),
                    IsPoliceCheckActive = table.Column<bool>(nullable: false),
                    PoliceCheckDate = table.Column<DateTime>(nullable: false),
                    PoliceCheckFileName = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomestayPoliceCheck", x => x.HomestayPoliceCheckId);
                    table.ForeignKey(
                        name: "FK_HomestayPoliceCheck_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomestayPoliceCheck_Homestay_HomestayId",
                        column: x => x.HomestayId,
                        principalTable: "Homestay",
                        principalColumn: "HomestayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomestayPoliceCheck_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HomestayStudent",
                columns: table => new
                {
                    HomestayStudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(nullable: false),
                    Arrival = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: true),
                    Departure = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    HomestayId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    PaidAmount = table.Column<decimal>(nullable: false),
                    PaidDate = table.Column<DateTime>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomestayStudent", x => x.HomestayStudentId);
                    table.ForeignKey(
                        name: "FK_HomestayStudent_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomestayStudent_Homestay_HomestayId",
                        column: x => x.HomestayId,
                        principalTable: "Homestay",
                        principalColumn: "HomestayId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomestayStudent_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomestayStudent_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Homestay_CreatedUserId",
                table: "Homestay",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Homestay_UpdatedUserId",
                table: "Homestay",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayContract_CreatedUserId",
                table: "HomestayContract",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayContract_HomestayId",
                table: "HomestayContract",
                column: "HomestayId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayContract_UpdatedUserId",
                table: "HomestayContract",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayEvaluation_CreatedUserId",
                table: "HomestayEvaluation",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayEvaluation_HomestayId",
                table: "HomestayEvaluation",
                column: "HomestayId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayEvaluation_UpdatedUserId",
                table: "HomestayEvaluation",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayHouseHold_CreatedUserId",
                table: "HomestayHouseHold",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayHouseHold_HomestayId",
                table: "HomestayHouseHold",
                column: "HomestayId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayHouseHold_UpdatedUserId",
                table: "HomestayHouseHold",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayPoliceCheck_CreatedUserId",
                table: "HomestayPoliceCheck",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayPoliceCheck_HomestayId",
                table: "HomestayPoliceCheck",
                column: "HomestayId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayPoliceCheck_UpdatedUserId",
                table: "HomestayPoliceCheck",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayStudent_CreatedUserId",
                table: "HomestayStudent",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayStudent_HomestayId",
                table: "HomestayStudent",
                column: "HomestayId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayStudent_StudentId",
                table: "HomestayStudent",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayStudent_UpdatedUserId",
                table: "HomestayStudent",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginHistory_CreatedUserId",
                table: "LoginHistory",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginHistory_UpdatedUserId",
                table: "LoginHistory",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteLocation_SiteId",
                table: "SiteLocation",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_CreatedUserId",
                table: "Student",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_SiteLocationId",
                table: "Student",
                column: "SiteLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_UpdatedUserId",
                table: "Student",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedUserId",
                table: "User",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PermissionId",
                table: "User",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UpdatedUserId",
                table: "User",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSiteLocation_CreatedUserId",
                table: "UserSiteLocation",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSiteLocation_SiteLocationId",
                table: "UserSiteLocation",
                column: "SiteLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSiteLocation_UpdatedUserId",
                table: "UserSiteLocation",
                column: "UpdatedUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomestayContract");

            migrationBuilder.DropTable(
                name: "HomestayEvaluation");

            migrationBuilder.DropTable(
                name: "HomestayHouseHold");

            migrationBuilder.DropTable(
                name: "HomestayPoliceCheck");

            migrationBuilder.DropTable(
                name: "HomestayStudent");

            migrationBuilder.DropTable(
                name: "LoginHistory");

            migrationBuilder.DropTable(
                name: "UserSiteLocation");

            migrationBuilder.DropTable(
                name: "Homestay");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "SiteLocation");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Site");
        }
    }
}
