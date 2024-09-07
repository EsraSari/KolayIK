using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KolayIK.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitKolayIK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserLogin<string>",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserLogin<string>", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    CountyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Counties_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressInfos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    CountyID = table.Column<int>(type: "int", nullable: true),
                    AddressDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressInfos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AddressInfos_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AddressInfos_Counties_CountyID",
                        column: x => x.CountyID,
                        principalTable: "Counties",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AddressInfos_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PositionID = table.Column<int>(type: "int", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RemainingLeave = table.Column<double>(type: "float", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    GenderID = table.Column<int>(type: "int", nullable: false),
                    AddressInfoID = table.Column<int>(type: "int", nullable: true),
                    EmergencyPersonID = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManagerID = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerID = table.Column<int>(type: "int", nullable: false),
                    ApprovalStatusID = table.Column<int>(type: "int", nullable: false),
                    ApproverID = table.Column<int>(type: "int", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Companies_AspNetUsers_ApproverID",
                        column: x => x.ApproverID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_AspNetUsers_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_States_ApprovalStatusID",
                        column: x => x.ApprovalStatusID,
                        principalTable: "States",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyPersons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyPersons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmergencyPersons_AspNetUsers_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseRequests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateID = table.Column<int>(type: "int", nullable: false),
                    ApproverID = table.Column<int>(type: "int", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseRequests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExpenseRequests_AspNetUsers_ApproverID",
                        column: x => x.ApproverID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpenseRequests_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpenseRequests_States_StateID",
                        column: x => x.StateID,
                        principalTable: "States",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalTime = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveTypeID = table.Column<int>(type: "int", nullable: false),
                    StateID = table.Column<int>(type: "int", nullable: false),
                    ApproverID = table.Column<int>(type: "int", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_AspNetUsers_ApproverID",
                        column: x => x.ApproverID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeID",
                        column: x => x.LeaveTypeID,
                        principalTable: "LeaveTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_States_StateID",
                        column: x => x.StateID,
                        principalTable: "States",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Resumes_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventTypeID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Events_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Events_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumeID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Certificates_Resumes_ResumeID",
                        column: x => x.ResumeID,
                        principalTable: "Resumes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResumeID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Educations_Resumes_ResumeID",
                        column: x => x.ResumeID,
                        principalTable: "Resumes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PositionID = table.Column<int>(type: "int", nullable: false),
                    ResumeID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Experiences_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Experiences_Resumes_ResumeID",
                        column: x => x.ResumeID,
                        principalTable: "Resumes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Manager", "MANAGER" },
                    { 2, null, "Admin", "ADMIN" },
                    { 3, null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "AddedDate", "CountryName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6328), "Türkiye", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6329), true },
                    { 2, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6332), "Almanya", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6333), true },
                    { 3, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6337), "Fransa", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6337), true },
                    { 4, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6341), "İngiltere", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6341), true },
                    { 5, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6344), "İtalya", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6345), true },
                    { 6, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6348), "İspanya", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6349), true },
                    { 7, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6352), "Türkiye", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6353), true },
                    { 8, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6356), "Ukrayna", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6357), true },
                    { 9, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6360), "Polonya", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6360), true },
                    { 10, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6363), "Romanya", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6364), true },
                    { 11, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6367), "Hollanda", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6368), true }
                });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "ID", "AddedDate", "EventTypeName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6717), "Resmi Tatil", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6718), true },
                    { 2, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6721), "Dini Bayram", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6722), true }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "ID", "AddedDate", "GenderName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6993), "Kadın", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6994), true },
                    { 2, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6997), "Erkek", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6998), true }
                });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "ID", "AddedDate", "LeaveTypeName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7151), "Mazeretsiz İzin", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7152), true },
                    { 2, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7155), "Yıllık İzin", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7156), true },
                    { 3, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7159), "Doğum İzni", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7160), true },
                    { 4, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7163), "Rapor", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7163), true }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "ID", "AddedDate", "ModifiedDate", "PositionName", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7304), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7305), "CEO", true },
                    { 2, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7308), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7309), "COO", true },
                    { 3, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7313), "CFO", true },
                    { 4, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7316), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7317), "CTO", true },
                    { 5, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7321), "CMO", true },
                    { 6, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7324), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7324), "Genel Müdür", true },
                    { 7, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7327), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7328), "Bölüm Müdürü", true },
                    { 8, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7331), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7332), "İdari Asistan", true },
                    { 9, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7335), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7336), "Ofis Yöneticisi", true },
                    { 10, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7338), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7339), "Sekreter", true },
                    { 11, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7342), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7343), "Muhasebeci", true },
                    { 12, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7346), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7346), "Finansal Analist", true },
                    { 13, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7349), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7350), "Mali Müşavir", true },
                    { 14, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7353), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7354), "İç Denetçi", true },
                    { 15, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7356), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7357), "Vergi Uzmanı", true },
                    { 16, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7360), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7361), "İnsan Kaynakları Müdürü", true },
                    { 17, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7364), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7365), "İK Uzmanı", true },
                    { 18, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7367), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7368), "Eğitim ve Gelişim Uzmanı", true },
                    { 19, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7371), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7372), "İşe Alım Uzmanı", true },
                    { 20, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7375), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7375), "Pazarlama Müdürü", true },
                    { 21, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7378), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7379), "Satış Müdürü", true },
                    { 22, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7382), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7383), "Dijital Pazarlama Uzmanı", true },
                    { 23, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7386), "Satış Temsilcisi", true },
                    { 24, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7389), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7390), "Müşteri İlişkileri Yöneticisi", true },
                    { 25, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7393), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7394), "Üretim Müdürü", true },
                    { 26, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7397), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7398), "Operasyon Yöneticisi", true },
                    { 27, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7400), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7401), "Kalite Kontrol Uzmanı", true },
                    { 28, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7405), "Üretim Elemanı", true },
                    { 29, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7408), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7409), "Yazılım Geliştirici", true },
                    { 30, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7411), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7412), "Sistem Analisti", true },
                    { 31, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7415), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7415), "Veri Tabanı Yöneticisi", true },
                    { 32, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7419), "IT Yöneticisi", true },
                    { 33, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7422), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7423), "Teknik Destek Uzmanı", true },
                    { 34, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7425), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7426), "Ar-Ge Müdürü", true },
                    { 35, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7429), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7430), "Ürün Geliştirme Uzmanı", true },
                    { 36, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7432), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7433), "Proje Yöneticisi", true },
                    { 37, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7437), "Hukuk Müşaviri", true },
                    { 38, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7440), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7441), "Uyum Uzmanı", true },
                    { 39, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7444), "Sözleşme Yöneticisi", true },
                    { 40, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7448), "Müşteri Hizmetleri Temsilcisi", true },
                    { 41, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7451), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(7451), "Teknik Destek Uzmanı", true }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "AddedDate", "ModifiedDate", "StateName", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9091), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9092), "Onay Bekliyor", true },
                    { 2, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9096), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9096), "Onaylandı", true },
                    { 3, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9100), new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(9100), "Reddedildi", true }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "AddedDate", "CityName", "CountryID", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3877), "Adana", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3878), true },
                    { 2, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3882), "Adıyaman", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3883), true },
                    { 3, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3887), "Afyonkarahisar", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3888), true },
                    { 4, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3891), "Ağrı", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3892), true },
                    { 5, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3895), "Amasya", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3896), true },
                    { 6, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3899), "Ankara", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3900), true },
                    { 7, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3903), "Antalya", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3904), true },
                    { 8, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3948), "Artvin", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3949), true },
                    { 9, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3952), "Aydın", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3953), true },
                    { 10, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3956), "Balıkesir", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3957), true },
                    { 11, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3960), "Bilecik", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3961), true },
                    { 12, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3964), "Bingöl", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3965), true },
                    { 13, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3968), "Bitlis", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3968), true },
                    { 14, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3971), "Bolu", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3972), true },
                    { 15, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3975), "Burdur", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3976), true },
                    { 16, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3979), "Bursa", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3980), true },
                    { 17, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3983), "Çanakkale", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3984), true },
                    { 18, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3987), "Çankırı", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3988), true },
                    { 19, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3990), "Çorum", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3991), true },
                    { 20, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3994), "Denizli", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3995), true },
                    { 21, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3998), "Diyarbakır", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(3999), true },
                    { 22, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4002), "Edirne", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4002), true },
                    { 23, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4005), "Elazığ", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4006), true },
                    { 24, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4009), "Erzincan", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4010), true },
                    { 25, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4013), "Erzurum", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4013), true },
                    { 26, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4016), "Eskişehir", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4017), true },
                    { 27, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4087), "Gaziantep", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4088), true },
                    { 28, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4091), "Giresun", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4092), true },
                    { 29, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4095), "Gümüşhane", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4096), true },
                    { 30, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4099), "Hakkâri", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4099), true },
                    { 31, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4102), "Hatay", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4103), true },
                    { 32, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4106), "Isparta", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4106), true },
                    { 33, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4109), "Mersin", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4110), true },
                    { 34, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4113), "İstanbul", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4114), true },
                    { 35, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4117), "İzmir", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4117), true },
                    { 36, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4120), "Kars", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4121), true },
                    { 37, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4124), "Kastamonu", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4125), true },
                    { 38, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4128), "Kayseri", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4128), true },
                    { 39, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4131), "Kırklareli", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4132), true },
                    { 40, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4135), "Kırşehir", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4136), true },
                    { 41, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4138), "Kocaeli", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4139), true },
                    { 42, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4142), "Konya", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4143), true },
                    { 43, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4146), "Kütahya", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4146), true },
                    { 44, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4149), "Malatya", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4150), true },
                    { 45, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4153), "Manisa", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4154), true },
                    { 46, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4156), "Kahramanmaraş", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4157), true },
                    { 47, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4160), "Mardin", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4161), true },
                    { 48, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4164), "Muğla", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4165), true },
                    { 49, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4168), "Muş", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4168), true },
                    { 50, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4171), "Nevşehir", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4172), true },
                    { 51, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4175), "Niğde", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4176), true },
                    { 52, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4178), "Ordu", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4179), true },
                    { 53, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4182), "Rize", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4183), true },
                    { 54, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4186), "Sakarya", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4186), true },
                    { 55, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4189), "Samsun", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4190), true },
                    { 56, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4193), "Siirt", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4194), true },
                    { 57, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4196), "Sinop", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4197), true },
                    { 58, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4200), "Sivas", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4201), true },
                    { 59, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4204), "Tekirdağ", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4205), true },
                    { 60, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4208), "Tokat", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4209), true },
                    { 61, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4212), "Trabzon", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4212), true },
                    { 62, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4215), "Tunceli", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4216), true },
                    { 63, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4219), "Şanlıurfa", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4220), true },
                    { 64, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4223), "Uşak", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4224), true },
                    { 65, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4227), "Van", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4227), true },
                    { 66, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4230), "Yozgat", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4231), true },
                    { 67, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4234), "Zonguldak", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4235), true },
                    { 68, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4237), "Aksaray", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4238), true },
                    { 69, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4241), "Bayburt", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4242), true },
                    { 70, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4245), "Karaman", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4246), true },
                    { 71, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4249), "Kırıkkale", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4249), true },
                    { 72, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4252), "Batman", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4253), true },
                    { 73, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4256), "Şırnak", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4257), true },
                    { 74, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4259), "Bartın", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4260), true },
                    { 75, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4263), "Ardahan", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4264), true },
                    { 76, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4267), "Iğdır", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4267), true },
                    { 77, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4270), "Yalova", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4271), true },
                    { 78, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4274), "Karabük", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4275), true },
                    { 79, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4277), "Kilis", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4278), true },
                    { 80, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4281), "Osmaniye", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4282), true },
                    { 81, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4285), "Düzce", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4285), true }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "ID", "AddedDate", "CompanyID", "EndDate", "EventName", "EventTypeID", "ModifiedDate", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6550), null, null, "Yılbaşı Günü", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6550), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6555), null, null, "23 Nisan Ulusal Egemenlik ve Çocuk Bayramı", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6556), new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6559), null, null, "1 Mayıs – Emek ve Dayanışma Günü", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6560), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6563), null, null, "30 Ağustos – Zafer Bayramı", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6564), new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6567), null, null, "29 Ekim – Cumhuriyet Bayramı", 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6568), new DateTime(2025, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "ID", "AddedDate", "CityID", "CountyName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4661), 1, "Kağıthane", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4662), true },
                    { 2, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4667), 1, "Şişli", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4667), true },
                    { 3, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4671), 1, "Beşiktaş", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4672), true },
                    { 4, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4675), 1, "Beyoğlu", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4676), true },
                    { 5, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4679), 1, "Kadıköy", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4680), true },
                    { 6, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4683), 1, "Üsküdar", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4684), true },
                    { 7, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4687), 1, "Fatih", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4688), true },
                    { 8, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4691), 1, "Bakırköy", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4692), true },
                    { 9, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4694), 1, "Maltepe", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4695), true },
                    { 10, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4698), 1, "Ataşehir", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4699), true },
                    { 11, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4702), 1, "Büyükçekmece", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4703), true },
                    { 12, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4706), 1, "Sarıyer", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4707), true },
                    { 13, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4710), 1, "Kartal", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4711), true },
                    { 14, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4714), 1, "Şile", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4715), true },
                    { 15, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4718), 1, "Çatalca", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4718), true },
                    { 16, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4721), 1, "Adalar", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4722), true },
                    { 17, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4725), 2, "Altındağ", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(4726), true },
                    { 18, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6078), 2, "Ayaş", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6078), true },
                    { 19, new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6083), 2, "Bala", new DateTime(2024, 8, 31, 3, 5, 33, 302, DateTimeKind.Local).AddTicks(6084), true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressInfos_CityID",
                table: "AddressInfos",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInfos_CountryID",
                table: "AddressInfos",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInfos_CountyID",
                table: "AddressInfos",
                column: "CountyID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInfos_UserID",
                table: "AddressInfos",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyID",
                table: "AspNetUsers",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GenderID",
                table: "AspNetUsers",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PositionID",
                table: "AspNetUsers",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_ResumeID",
                table: "Certificates",
                column: "ResumeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryID",
                table: "Cities",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ApprovalStatusID",
                table: "Companies",
                column: "ApprovalStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ApproverID",
                table: "Companies",
                column: "ApproverID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ManagerID",
                table: "Companies",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_Counties_CityID",
                table: "Counties",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ResumeID",
                table: "Educations",
                column: "ResumeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyPersons_EmployeeID",
                table: "EmergencyPersons",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_CompanyID",
                table: "Events",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeID",
                table: "Events",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseRequests_ApproverID",
                table: "ExpenseRequests",
                column: "ApproverID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseRequests_StateID",
                table: "ExpenseRequests",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseRequests_UserID",
                table: "ExpenseRequests",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_PositionID",
                table: "Experiences",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_ResumeID",
                table: "Experiences",
                column: "ResumeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_ApproverID",
                table: "LeaveRequests",
                column: "ApproverID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeID",
                table: "LeaveRequests",
                column: "LeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_StateID",
                table: "LeaveRequests",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_UserID",
                table: "LeaveRequests",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_UserID",
                table: "Resumes",
                column: "UserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressInfos_AspNetUsers_UserID",
                table: "AddressInfos",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyID",
                table: "AspNetUsers",
                column: "CompanyID",
                principalTable: "Companies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AspNetUsers_ApproverID",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AspNetUsers_ManagerID",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "AddressInfos");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "EmergencyPersons");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "ExpenseRequests");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "IdentityUserLogin<string>");

            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
