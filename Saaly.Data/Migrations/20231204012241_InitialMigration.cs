using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Saaly.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblDataProtectionKeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FriendlyName = table.Column<string>(type: "text", nullable: true),
                    Xml = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDataProtectionKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblEntity",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Types = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntity", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAspNetRoleClaims_tblAspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tblAspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityCurrency",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ShortName = table.Column<string>(type: "text", nullable: true),
                    IsoCode = table.Column<string>(type: "text", nullable: true),
                    Symbol = table.Column<string>(type: "text", nullable: true),
                    FractionalUnit = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityCurrency", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityCurrency_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityGender",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityGender", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityGender_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityLocation",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Slug = table.Column<string>(type: "text", nullable: true),
                    ParentGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Depth = table.Column<int>(type: "integer", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    MapData = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityLocation", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityLocation_tblEntityLocation_ParentGuid",
                        column: x => x.ParentGuid,
                        principalTable: "tblEntityLocation",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityLocation_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityUserDepartment",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityUserDepartment", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityUserDepartment_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityUserGroup",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    HasMaximumCapacity = table.Column<bool>(type: "boolean", nullable: false),
                    MaximumCapacity = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityUserGroup", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityUserGroup_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbltblEntity",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbltblEntity", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tbltblEntity_tblEntity_Guid",
                        column: x => x.Guid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblContact",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    WhatsappNumber = table.Column<string>(type: "text", nullable: true),
                    GenderGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true),
                    LocationGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblContact", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblContact_tblEntityGender_GenderGuid",
                        column: x => x.GenderGuid,
                        principalTable: "tblEntityGender",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblContact_tblEntityLocation_LocationGuid",
                        column: x => x.LocationGuid,
                        principalTable: "tblEntityLocation",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblEntityUserDepartmentClaim",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserDepartmentGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityUserDepartmentClaim", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityUserDepartmentClaim_tblEntityUserDepartment_Entity~",
                        column: x => x.EntityUserDepartmentGuid,
                        principalTable: "tblEntityUserDepartment",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityUserDepartmentClaim_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityBillCode",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    BillUnitGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityBillCode", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityBillCode_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityBillCode_tbltblEntity_BillUnitGuid",
                        column: x => x.BillUnitGuid,
                        principalTable: "tbltblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAdmins",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: true),
                    ReferralCode = table.Column<string>(type: "text", nullable: true),
                    DefaultPassword = table.Column<string>(type: "text", nullable: true),
                    ContactGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    DefaultUser = table.Column<bool>(type: "boolean", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAdmins", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAdmins_tblContact_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContact",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblEntityUser",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: false),
                    BillCodeGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    DepartmentGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    ManagerGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityUser", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityUser_tblContact_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContact",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityUser_tblEntityBillCode_BillCodeGuid",
                        column: x => x.BillCodeGuid,
                        principalTable: "tblEntityBillCode",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityUser_tblEntityUserDepartment_DepartmentGuid",
                        column: x => x.DepartmentGuid,
                        principalTable: "tblEntityUserDepartment",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityUser_tblEntityUser_ManagerGuid",
                        column: x => x.ManagerGuid,
                        principalTable: "tblEntityUser",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityUser_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbltblEntityBillCode",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityCurrencyGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    BillCostRate = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    BillRate = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    EntityBillCodeGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbltblEntityBillCode", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tbltblEntityBillCode_tblEntityBillCode_EntityBillCodeGuid",
                        column: x => x.EntityBillCodeGuid,
                        principalTable: "tblEntityBillCode",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbltblEntityBillCode_tblEntityBillCode_Guid",
                        column: x => x.Guid,
                        principalTable: "tblEntityBillCode",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbltblEntityBillCode_tblEntityCurrency_EntityCurrencyGuid",
                        column: x => x.EntityCurrencyGuid,
                        principalTable: "tblEntityCurrency",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    AdminGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    HasLoggedIn = table.Column<bool>(type: "boolean", nullable: false),
                    JustInitialized = table.Column<bool>(type: "boolean", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAspNetUsers_tblAdmins_AdminGuid",
                        column: x => x.AdminGuid,
                        principalTable: "tblAdmins",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblAspNetUsers_tblEntityUser_EntityUserGuid",
                        column: x => x.EntityUserGuid,
                        principalTable: "tblEntityUser",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblEntityUserGroupUser",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserGroupGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserGroupUserGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityUserGroupUser", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityUserGroupUser_tblEntityUserGroup_EntityUserGroupGu~",
                        column: x => x.EntityUserGroupGuid,
                        principalTable: "tblEntityUserGroup",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityUserGroupUser_tblEntityUser_EntityUserGroupUserGuid",
                        column: x => x.EntityUserGroupUserGuid,
                        principalTable: "tblEntityUser",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityUserGroupUser_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAspNetUserClaims_tblAspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblAspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_tblAspNetUserLogins_tblAspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblAspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_tblAspNetUserRoles_tblAspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tblAspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblAspNetUserRoles_tblAspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblAspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_tblAspNetUserTokens_tblAspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblAspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityClient",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ManagementCompany = table.Column<string>(type: "text", nullable: true),
                    ContactGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityClientBillingInfoGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityClient", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityClient_tblContact_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContact",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityClient_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityClientBillingInfo",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityClientBillingInfo", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityClientBillingInfo_tblContact_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContact",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityClientBillingInfo_tblEntityClient_EntityClientGuid",
                        column: x => x.EntityClientGuid,
                        principalTable: "tblEntityClient",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityClientBillingInfo_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityProject",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BudgetHours = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProjectID = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    IsChargable = table.Column<bool>(type: "boolean", nullable: false),
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityProject", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityProject_tblEntityClient_ClientGuid",
                        column: x => x.ClientGuid,
                        principalTable: "tblEntityClient",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityProject_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityTask",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    BudgetHours = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BillUnitGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    AuditFees = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: true),
                    IsChargable = table.Column<bool>(type: "boolean", nullable: false),
                    ProjectGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Parent = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityTask", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityTask_tblEntityProject_ProjectGuid",
                        column: x => x.ProjectGuid,
                        principalTable: "tblEntityProject",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityTask_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTask_tbltblEntity_BillUnitGuid",
                        column: x => x.BillUnitGuid,
                        principalTable: "tbltblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityTaskCurrencyRates",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrencyGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    TaskGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    TaskCostRate = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    TaskRate = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityTaskCurrencyRates", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityTaskCurrencyRates_tblEntityCurrency_CurrencyGuid",
                        column: x => x.CurrencyGuid,
                        principalTable: "tblEntityCurrency",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTaskCurrencyRates_tblEntityTask_TaskGuid",
                        column: x => x.TaskGuid,
                        principalTable: "tblEntityTask",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTaskCurrencyRates_tblEntity_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntity",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblAdmins_ContactGuid",
                table: "tblAdmins",
                column: "ContactGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAspNetRoleClaims_RoleId",
                table: "tblAspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "tblAspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblAspNetUserClaims_UserId",
                table: "tblAspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAspNetUserLogins_UserId",
                table: "tblAspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAspNetUserRoles_RoleId",
                table: "tblAspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "tblAspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_tblAspNetUsers_AdminGuid",
                table: "tblAspNetUsers",
                column: "AdminGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAspNetUsers_EntityUserGuid",
                table: "tblAspNetUsers",
                column: "EntityUserGuid");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "tblAspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblContact_GenderGuid",
                table: "tblContact",
                column: "GenderGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblContact_LocationGuid",
                table: "tblContact",
                column: "LocationGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillCode_BillUnitGuid",
                table: "tblEntityBillCode",
                column: "BillUnitGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillCode_EntityGuid",
                table: "tblEntityBillCode",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClient_ContactGuid",
                table: "tblEntityClient",
                column: "ContactGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClient_EntityClientBillingInfoGuid",
                table: "tblEntityClient",
                column: "EntityClientBillingInfoGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClient_EntityGuid",
                table: "tblEntityClient",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClientBillingInfo_ContactGuid",
                table: "tblEntityClientBillingInfo",
                column: "ContactGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClientBillingInfo_EntityClientGuid",
                table: "tblEntityClientBillingInfo",
                column: "EntityClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClientBillingInfo_EntityGuid",
                table: "tblEntityClientBillingInfo",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityCurrency_EntityGuid",
                table: "tblEntityCurrency",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityGender_EntityGuid",
                table: "tblEntityGender",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityLocation_EntityGuid",
                table: "tblEntityLocation",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityLocation_ParentGuid",
                table: "tblEntityLocation",
                column: "ParentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityProject_ClientGuid",
                table: "tblEntityProject",
                column: "ClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityProject_EntityGuid",
                table: "tblEntityProject",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTask_BillUnitGuid",
                table: "tblEntityTask",
                column: "BillUnitGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTask_EntityGuid",
                table: "tblEntityTask",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTask_ProjectGuid",
                table: "tblEntityTask",
                column: "ProjectGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTaskCurrencyRates_CurrencyGuid",
                table: "tblEntityTaskCurrencyRates",
                column: "CurrencyGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTaskCurrencyRates_EntityGuid",
                table: "tblEntityTaskCurrencyRates",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTaskCurrencyRates_TaskGuid",
                table: "tblEntityTaskCurrencyRates",
                column: "TaskGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUser_BillCodeGuid",
                table: "tblEntityUser",
                column: "BillCodeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUser_ContactGuid",
                table: "tblEntityUser",
                column: "ContactGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUser_DepartmentGuid",
                table: "tblEntityUser",
                column: "DepartmentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUser_EntityGuid",
                table: "tblEntityUser",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUser_ManagerGuid",
                table: "tblEntityUser",
                column: "ManagerGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserDepartment_EntityGuid",
                table: "tblEntityUserDepartment",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserDepartmentClaim_EntityGuid",
                table: "tblEntityUserDepartmentClaim",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserDepartmentClaim_EntityUserDepartmentGuid",
                table: "tblEntityUserDepartmentClaim",
                column: "EntityUserDepartmentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserGroup_EntityGuid",
                table: "tblEntityUserGroup",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserGroupUser_EntityGuid",
                table: "tblEntityUserGroupUser",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserGroupUser_EntityUserGroupGuid",
                table: "tblEntityUserGroupUser",
                column: "EntityUserGroupGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserGroupUser_EntityUserGroupUserGuid",
                table: "tblEntityUserGroupUser",
                column: "EntityUserGroupUserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tbltblEntityBillCode_EntityBillCodeGuid",
                table: "tbltblEntityBillCode",
                column: "EntityBillCodeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tbltblEntityBillCode_EntityCurrencyGuid",
                table: "tbltblEntityBillCode",
                column: "EntityCurrencyGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblEntityClient_tblEntityClientBillingInfo_EntityClientBill~",
                table: "tblEntityClient",
                column: "EntityClientBillingInfoGuid",
                principalTable: "tblEntityClientBillingInfo",
                principalColumn: "Guid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClient_tblContact_ContactGuid",
                table: "tblEntityClient");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClientBillingInfo_tblContact_ContactGuid",
                table: "tblEntityClientBillingInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClient_tblEntity_EntityGuid",
                table: "tblEntityClient");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClientBillingInfo_tblEntity_EntityGuid",
                table: "tblEntityClientBillingInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClient_tblEntityClientBillingInfo_EntityClientBill~",
                table: "tblEntityClient");

            migrationBuilder.DropTable(
                name: "tblAspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "tblAspNetUserClaims");

            migrationBuilder.DropTable(
                name: "tblAspNetUserLogins");

            migrationBuilder.DropTable(
                name: "tblAspNetUserRoles");

            migrationBuilder.DropTable(
                name: "tblAspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tblDataProtectionKeys");

            migrationBuilder.DropTable(
                name: "tblEntityTaskCurrencyRates");

            migrationBuilder.DropTable(
                name: "tblEntityUserDepartmentClaim");

            migrationBuilder.DropTable(
                name: "tblEntityUserGroupUser");

            migrationBuilder.DropTable(
                name: "tbltblEntityBillCode");

            migrationBuilder.DropTable(
                name: "tblAspNetRoles");

            migrationBuilder.DropTable(
                name: "tblAspNetUsers");

            migrationBuilder.DropTable(
                name: "tblEntityTask");

            migrationBuilder.DropTable(
                name: "tblEntityUserGroup");

            migrationBuilder.DropTable(
                name: "tblEntityCurrency");

            migrationBuilder.DropTable(
                name: "tblAdmins");

            migrationBuilder.DropTable(
                name: "tblEntityUser");

            migrationBuilder.DropTable(
                name: "tblEntityProject");

            migrationBuilder.DropTable(
                name: "tblEntityBillCode");

            migrationBuilder.DropTable(
                name: "tblEntityUserDepartment");

            migrationBuilder.DropTable(
                name: "tbltblEntity");

            migrationBuilder.DropTable(
                name: "tblContact");

            migrationBuilder.DropTable(
                name: "tblEntityGender");

            migrationBuilder.DropTable(
                name: "tblEntityLocation");

            migrationBuilder.DropTable(
                name: "tblEntity");

            migrationBuilder.DropTable(
                name: "tblEntityClientBillingInfo");

            migrationBuilder.DropTable(
                name: "tblEntityClient");
        }
    }
}
