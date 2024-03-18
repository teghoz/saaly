using System;
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
                name: "tblAuditEntities",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntities", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityClientGroupClients",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityClientGroupClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityClientGroupClients", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditLocations",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    LocationGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Slug = table.Column<string>(type: "text", nullable: true),
                    ParentGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Depth = table.Column<int>(type: "integer", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    MapData = table.Column<string>(type: "text", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditLocations", x => x.Guid);
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
                name: "tblLocation",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLocation", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblLocation_tblLocation_ParentGuid",
                        column: x => x.ParentGuid,
                        principalTable: "tblLocation",
                        principalColumn: "Guid");
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAdmins", x => x.Guid);
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
                });

            migrationBuilder.CreateTable(
                name: "tblAspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uuid", nullable: true),
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
                name: "tblAuditEntityBillCodeCurrencyRates",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityBillCodeCurrencyRateGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityCurrencyGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    BillCostRate = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    BillRate = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    EntityBillCodeGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityBillCodeCurrencyRates", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityBillCodes",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityBillCodeGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    BillUnitGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityBillCodes", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityBillUnits",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityBillUnitGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityBillUnits", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityClientBillingInfos",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityClientBillingInfoGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityClientBillingInfos", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityClientGroups",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityClientGroupGuid = table.Column<Guid>(type: "uuid", nullable: false),
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityClientGroups", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityClients",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ManagementCompany = table.Column<string>(type: "text", nullable: true),
                    ContactGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityClientBillingInfoGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityClients", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityCurrencies",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityCurrencyGuid = table.Column<Guid>(type: "uuid", nullable: false),
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityCurrencies", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityExpenses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityExpenseGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Day = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityExpenses", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityGenders",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityGenderGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityGenders", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityJobs",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityJobGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityJobs", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityLocations",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityLocationGuid = table.Column<Guid>(type: "uuid", nullable: false),
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityLocations", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityProjects",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityProjectGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BudgetHours = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProjectID = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    IsChargable = table.Column<bool>(type: "boolean", nullable: false),
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityProjects", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityTaskCurrencyRates",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityTaskCurrencyRateGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrencyGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    TaskGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    TaskCostRate = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    TaskRate = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityTaskCurrencyRates", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityTasks",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityTaskGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityTasks", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityTimeSheet",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityTimeSheetGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Day = table.Column<string>(type: "text", nullable: false),
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkedHours = table.Column<double>(type: "double precision", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    AssigmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityTimeSheet", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityUserDepartmentClaims",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserDepartmentClaimGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserDepartmentGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityUserDepartmentClaims", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityUserDepartments",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserDepartmentGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityUserDepartments", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityUserGroups",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserGroupGuid = table.Column<Guid>(type: "uuid", nullable: false),
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityUserGroups", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityUserGroupUsers",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserGroupUserGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserGroupGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityUserGroupUsers", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityUsers",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: false),
                    BillCodeGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    DepartmentGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    ManagerGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityUsers", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityWorkAssignments",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityWorkAssignmentGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    JobGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    JobName = table.Column<string>(type: "text", nullable: false),
                    EntityUserGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    AssignedHours = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    AssigmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsAssigned = table.Column<bool>(type: "boolean", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityWorkAssignments", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblContacts",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    WhatsappNumber = table.Column<string>(type: "text", nullable: true),
                    GenderGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true),
                    LocationGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityLocationGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblContacts", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblContacts_tblLocation_LocationGuid",
                        column: x => x.LocationGuid,
                        principalTable: "tblLocation",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblUser_tblContacts_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContacts",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblEntities",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    OwnerGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntities", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntities_tblUser_OwnerGuid",
                        column: x => x.OwnerGuid,
                        principalTable: "tblUser",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblEntityBillUnits",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityBillUnits", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityBillUnits_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityClientGroups",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityClientGroups", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityClientGroups_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityCurrencies",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityCurrencies", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityCurrencies_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityGenders",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityGenders", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityGenders_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityJobs",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityJobs", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityJobs_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityLocations",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityLocations", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityLocations_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityLocations_tblLocation_ParentGuid",
                        column: x => x.ParentGuid,
                        principalTable: "tblLocation",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblEntityUserDepartments",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityUserDepartments", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityUserDepartments_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityUserGroups",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityUserGroups", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityUserGroups_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityBillCodes",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityBillCodes", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityBillCodes_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityBillCodes_tblEntityBillUnits_BillUnitGuid",
                        column: x => x.BillUnitGuid,
                        principalTable: "tblEntityBillUnits",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityWorkAssignments",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    JobGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    JobName = table.Column<string>(type: "text", nullable: false),
                    EntityUserGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    AssignedHours = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    AssigmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsAssigned = table.Column<bool>(type: "boolean", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityWorkAssignments", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityWorkAssignments_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityWorkAssignments_tblEntityJobs_JobGuid",
                        column: x => x.JobGuid,
                        principalTable: "tblEntityJobs",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityWorkAssignments_tblUser_EntityUserGuid",
                        column: x => x.EntityUserGuid,
                        principalTable: "tblUser",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityUserDepartmentClaims",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityUserDepartmentClaims", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityUserDepartmentClaims_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityUserDepartmentClaims_tblEntityUserDepartments_Enti~",
                        column: x => x.EntityUserDepartmentGuid,
                        principalTable: "tblEntityUserDepartments",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityBillCodeCurrencyRates",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityCurrencyGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    BillCostRate = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    BillRate = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    EntityBillCodeGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityBillCodeCurrencyRates", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityBillCodeCurrencyRates_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityBillCodeCurrencyRates_tblEntityBillCodes_EntityBil~",
                        column: x => x.EntityBillCodeGuid,
                        principalTable: "tblEntityBillCodes",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityBillCodeCurrencyRates_tblEntityCurrencies_EntityCu~",
                        column: x => x.EntityCurrencyGuid,
                        principalTable: "tblEntityCurrencies",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityUsers",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: false),
                    BillCodeGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    DepartmentGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    ManagerGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityUsers", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityUsers_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityUsers_tblEntityBillCodes_BillCodeGuid",
                        column: x => x.BillCodeGuid,
                        principalTable: "tblEntityBillCodes",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityUsers_tblEntityUserDepartments_DepartmentGuid",
                        column: x => x.DepartmentGuid,
                        principalTable: "tblEntityUserDepartments",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityUsers_tblEntityUsers_ManagerGuid",
                        column: x => x.ManagerGuid,
                        principalTable: "tblEntityUsers",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityUsers_tblUser_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "tblUser",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblEntityUserGroupUsers",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserGroupGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserGroupUserGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityUserGroupUsers", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityUserGroupUsers_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityUserGroupUsers_tblEntityUserGroups_EntityUserGroup~",
                        column: x => x.EntityUserGroupGuid,
                        principalTable: "tblEntityUserGroups",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityUserGroupUsers_tblEntityUsers_EntityUserGuid",
                        column: x => x.EntityUserGuid,
                        principalTable: "tblEntityUsers",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityUserGroupUsers_tblUser_EntityUserGroupUserGuid",
                        column: x => x.EntityUserGroupUserGuid,
                        principalTable: "tblUser",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityClientBillingInfos",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityClientBillingInfos", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityClientBillingInfos_tblContacts_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContacts",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityClientBillingInfos_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityClients",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityClients", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityClients_tblContacts_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContacts",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityClients_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityClients_tblEntityClientBillingInfos_EntityClientBi~",
                        column: x => x.EntityClientBillingInfoGuid,
                        principalTable: "tblEntityClientBillingInfos",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblEntityClientGroupClients",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    GroupGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityClientGroupClients", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityClientGroupClients_tblEntityClientGroups_GroupGuid",
                        column: x => x.GroupGuid,
                        principalTable: "tblEntityClientGroups",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityClientGroupClients_tblEntityClients_ClientGuid",
                        column: x => x.ClientGuid,
                        principalTable: "tblEntityClients",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityExpenses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    ID = table.Column<int>(type: "integer", nullable: false),
                    WorkGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Day = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityExpenses", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityExpenses_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityExpenses_tblEntityClients_ClientGuid",
                        column: x => x.ClientGuid,
                        principalTable: "tblEntityClients",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityExpenses_tblEntityWorkAssignments_WorkGuid",
                        column: x => x.WorkGuid,
                        principalTable: "tblEntityWorkAssignments",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityExpenses_tblUser_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "tblUser",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityProjects",
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
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityProjects", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityProjects_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityProjects_tblEntityClients_ClientGuid",
                        column: x => x.ClientGuid,
                        principalTable: "tblEntityClients",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblEntityTimeSheets",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Day = table.Column<string>(type: "text", nullable: false),
                    ClientGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkedHours = table.Column<double>(type: "double precision", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    AssigmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityTimeSheets", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityTimeSheets_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTimeSheets_tblEntityClients_ClientGuid",
                        column: x => x.ClientGuid,
                        principalTable: "tblEntityClients",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTimeSheets_tblEntityWorkAssignments_WorkGuid",
                        column: x => x.WorkGuid,
                        principalTable: "tblEntityWorkAssignments",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTimeSheets_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityTasks",
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityTasks", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityTasks_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTasks_tblEntityBillUnits_BillUnitGuid",
                        column: x => x.BillUnitGuid,
                        principalTable: "tblEntityBillUnits",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTasks_tblEntityProjects_ProjectGuid",
                        column: x => x.ProjectGuid,
                        principalTable: "tblEntityProjects",
                        principalColumn: "Guid");
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
                    Deleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityTaskCurrencyRates", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityTaskCurrencyRates_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTaskCurrencyRates_tblEntityCurrencies_CurrencyGuid",
                        column: x => x.CurrencyGuid,
                        principalTable: "tblEntityCurrencies",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTaskCurrencyRates_tblEntityTasks_TaskGuid",
                        column: x => x.TaskGuid,
                        principalTable: "tblEntityTasks",
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
                name: "IX_tblAspNetUsers_UserGuid",
                table: "tblAspNetUsers",
                column: "UserGuid");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "tblAspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityBillCodeCurrencyRates_EntityGuid",
                table: "tblAuditEntityBillCodeCurrencyRates",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityBillCodes_EntityGuid",
                table: "tblAuditEntityBillCodes",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityBillUnits_EntityGuid",
                table: "tblAuditEntityBillUnits",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityClientBillingInfos_ContactGuid",
                table: "tblAuditEntityClientBillingInfos",
                column: "ContactGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityClientBillingInfos_EntityGuid",
                table: "tblAuditEntityClientBillingInfos",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityClientGroups_EntityGuid",
                table: "tblAuditEntityClientGroups",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityClients_ContactGuid",
                table: "tblAuditEntityClients",
                column: "ContactGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityClients_EntityGuid",
                table: "tblAuditEntityClients",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityCurrencies_EntityGuid",
                table: "tblAuditEntityCurrencies",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityExpenses_EntityGuid",
                table: "tblAuditEntityExpenses",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityGenders_EntityGuid",
                table: "tblAuditEntityGenders",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityJobs_EntityGuid",
                table: "tblAuditEntityJobs",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityLocations_EntityGuid",
                table: "tblAuditEntityLocations",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityProjects_EntityGuid",
                table: "tblAuditEntityProjects",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityTaskCurrencyRates_EntityGuid",
                table: "tblAuditEntityTaskCurrencyRates",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityTasks_EntityGuid",
                table: "tblAuditEntityTasks",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityTimeSheet_EntityGuid",
                table: "tblAuditEntityTimeSheet",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityUserDepartmentClaims_EntityGuid",
                table: "tblAuditEntityUserDepartmentClaims",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityUserDepartments_EntityGuid",
                table: "tblAuditEntityUserDepartments",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityUserGroups_EntityGuid",
                table: "tblAuditEntityUserGroups",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityUserGroupUsers_EntityGuid",
                table: "tblAuditEntityUserGroupUsers",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityUsers_EntityGuid",
                table: "tblAuditEntityUsers",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityWorkAssignments_EntityGuid",
                table: "tblAuditEntityWorkAssignments",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblContacts_EntityLocationGuid",
                table: "tblContacts",
                column: "EntityLocationGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblContacts_GenderGuid",
                table: "tblContacts",
                column: "GenderGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblContacts_LocationGuid",
                table: "tblContacts",
                column: "LocationGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntities_OwnerGuid",
                table: "tblEntities",
                column: "OwnerGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillCodeCurrencyRates_EntityBillCodeGuid",
                table: "tblEntityBillCodeCurrencyRates",
                column: "EntityBillCodeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillCodeCurrencyRates_EntityCurrencyGuid",
                table: "tblEntityBillCodeCurrencyRates",
                column: "EntityCurrencyGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillCodeCurrencyRates_EntityGuid",
                table: "tblEntityBillCodeCurrencyRates",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillCodes_BillUnitGuid",
                table: "tblEntityBillCodes",
                column: "BillUnitGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillCodes_EntityGuid",
                table: "tblEntityBillCodes",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillUnits_EntityGuid",
                table: "tblEntityBillUnits",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClientBillingInfos_ContactGuid",
                table: "tblEntityClientBillingInfos",
                column: "ContactGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClientBillingInfos_EntityClientGuid",
                table: "tblEntityClientBillingInfos",
                column: "EntityClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClientBillingInfos_EntityGuid",
                table: "tblEntityClientBillingInfos",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClientGroupClients_ClientGuid",
                table: "tblEntityClientGroupClients",
                column: "ClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClientGroupClients_GroupGuid",
                table: "tblEntityClientGroupClients",
                column: "GroupGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClientGroups_EntityGuid",
                table: "tblEntityClientGroups",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClients_ContactGuid",
                table: "tblEntityClients",
                column: "ContactGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClients_EntityClientBillingInfoGuid",
                table: "tblEntityClients",
                column: "EntityClientBillingInfoGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityClients_EntityGuid",
                table: "tblEntityClients",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityCurrencies_EntityGuid",
                table: "tblEntityCurrencies",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityExpenses_ClientGuid",
                table: "tblEntityExpenses",
                column: "ClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityExpenses_EntityGuid",
                table: "tblEntityExpenses",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityExpenses_UserGuid",
                table: "tblEntityExpenses",
                column: "UserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityExpenses_WorkGuid",
                table: "tblEntityExpenses",
                column: "WorkGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityGenders_EntityGuid",
                table: "tblEntityGenders",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityJobs_EntityGuid",
                table: "tblEntityJobs",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityLocations_EntityGuid",
                table: "tblEntityLocations",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityLocations_ParentGuid",
                table: "tblEntityLocations",
                column: "ParentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityProjects_ClientGuid",
                table: "tblEntityProjects",
                column: "ClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityProjects_EntityGuid",
                table: "tblEntityProjects",
                column: "EntityGuid");

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
                name: "IX_tblEntityTasks_BillUnitGuid",
                table: "tblEntityTasks",
                column: "BillUnitGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTasks_EntityGuid",
                table: "tblEntityTasks",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTasks_ProjectGuid",
                table: "tblEntityTasks",
                column: "ProjectGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTimeSheets_ClientGuid",
                table: "tblEntityTimeSheets",
                column: "ClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTimeSheets_EntityGuid",
                table: "tblEntityTimeSheets",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTimeSheets_UserId",
                table: "tblEntityTimeSheets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTimeSheets_WorkGuid",
                table: "tblEntityTimeSheets",
                column: "WorkGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserDepartmentClaims_EntityGuid",
                table: "tblEntityUserDepartmentClaims",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserDepartmentClaims_EntityUserDepartmentGuid",
                table: "tblEntityUserDepartmentClaims",
                column: "EntityUserDepartmentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserDepartments_EntityGuid",
                table: "tblEntityUserDepartments",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserGroups_EntityGuid",
                table: "tblEntityUserGroups",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserGroupUsers_EntityGuid",
                table: "tblEntityUserGroupUsers",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserGroupUsers_EntityUserGroupGuid",
                table: "tblEntityUserGroupUsers",
                column: "EntityUserGroupGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserGroupUsers_EntityUserGroupUserGuid",
                table: "tblEntityUserGroupUsers",
                column: "EntityUserGroupUserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserGroupUsers_EntityUserGuid",
                table: "tblEntityUserGroupUsers",
                column: "EntityUserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUsers_BillCodeGuid",
                table: "tblEntityUsers",
                column: "BillCodeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUsers_DepartmentGuid",
                table: "tblEntityUsers",
                column: "DepartmentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUsers_EntityGuid",
                table: "tblEntityUsers",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUsers_ManagerGuid",
                table: "tblEntityUsers",
                column: "ManagerGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUsers_UserGuid",
                table: "tblEntityUsers",
                column: "UserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityWorkAssignments_EntityGuid",
                table: "tblEntityWorkAssignments",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityWorkAssignments_EntityUserGuid",
                table: "tblEntityWorkAssignments",
                column: "EntityUserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityWorkAssignments_JobGuid",
                table: "tblEntityWorkAssignments",
                column: "JobGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblLocation_ParentGuid",
                table: "tblLocation",
                column: "ParentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblUser_ContactGuid",
                table: "tblUser",
                column: "ContactGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblAdmins_tblContacts_ContactGuid",
                table: "tblAdmins",
                column: "ContactGuid",
                principalTable: "tblContacts",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblAspNetUserClaims_tblAspNetUsers_UserId",
                table: "tblAspNetUserClaims",
                column: "UserId",
                principalTable: "tblAspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAspNetUserLogins_tblAspNetUsers_UserId",
                table: "tblAspNetUserLogins",
                column: "UserId",
                principalTable: "tblAspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAspNetUserRoles_tblAspNetUsers_UserId",
                table: "tblAspNetUserRoles",
                column: "UserId",
                principalTable: "tblAspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAspNetUsers_tblUser_UserGuid",
                table: "tblAspNetUsers",
                column: "UserGuid",
                principalTable: "tblUser",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityBillCodeCurrencyRates_tblEntities_EntityGuid",
                table: "tblAuditEntityBillCodeCurrencyRates",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityBillCodes_tblEntities_EntityGuid",
                table: "tblAuditEntityBillCodes",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityBillUnits_tblEntities_EntityGuid",
                table: "tblAuditEntityBillUnits",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityClientBillingInfos_tblContacts_ContactGuid",
                table: "tblAuditEntityClientBillingInfos",
                column: "ContactGuid",
                principalTable: "tblContacts",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityClientBillingInfos_tblEntities_EntityGuid",
                table: "tblAuditEntityClientBillingInfos",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityClientGroups_tblEntities_EntityGuid",
                table: "tblAuditEntityClientGroups",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityClients_tblContacts_ContactGuid",
                table: "tblAuditEntityClients",
                column: "ContactGuid",
                principalTable: "tblContacts",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityClients_tblEntities_EntityGuid",
                table: "tblAuditEntityClients",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityCurrencies_tblEntities_EntityGuid",
                table: "tblAuditEntityCurrencies",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityExpenses_tblEntities_EntityGuid",
                table: "tblAuditEntityExpenses",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityGenders_tblEntities_EntityGuid",
                table: "tblAuditEntityGenders",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityJobs_tblEntities_EntityGuid",
                table: "tblAuditEntityJobs",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityLocations_tblEntities_EntityGuid",
                table: "tblAuditEntityLocations",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityProjects_tblEntities_EntityGuid",
                table: "tblAuditEntityProjects",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityTaskCurrencyRates_tblEntities_EntityGuid",
                table: "tblAuditEntityTaskCurrencyRates",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityTasks_tblEntities_EntityGuid",
                table: "tblAuditEntityTasks",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityTimeSheet_tblEntities_EntityGuid",
                table: "tblAuditEntityTimeSheet",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityUserDepartmentClaims_tblEntities_EntityGuid",
                table: "tblAuditEntityUserDepartmentClaims",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityUserDepartments_tblEntities_EntityGuid",
                table: "tblAuditEntityUserDepartments",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityUserGroups_tblEntities_EntityGuid",
                table: "tblAuditEntityUserGroups",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityUserGroupUsers_tblEntities_EntityGuid",
                table: "tblAuditEntityUserGroupUsers",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityUsers_tblEntities_EntityGuid",
                table: "tblAuditEntityUsers",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuditEntityWorkAssignments_tblEntities_EntityGuid",
                table: "tblAuditEntityWorkAssignments",
                column: "EntityGuid",
                principalTable: "tblEntities",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblContacts_tblEntityGenders_GenderGuid",
                table: "tblContacts",
                column: "GenderGuid",
                principalTable: "tblEntityGenders",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblContacts_tblEntityLocations_EntityLocationGuid",
                table: "tblContacts",
                column: "EntityLocationGuid",
                principalTable: "tblEntityLocations",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblEntityClientBillingInfos_tblEntityClients_EntityClientGu~",
                table: "tblEntityClientBillingInfos",
                column: "EntityClientGuid",
                principalTable: "tblEntityClients",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClientBillingInfos_tblContacts_ContactGuid",
                table: "tblEntityClientBillingInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClients_tblContacts_ContactGuid",
                table: "tblEntityClients");

            migrationBuilder.DropForeignKey(
                name: "FK_tblUser_tblContacts_ContactGuid",
                table: "tblUser");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntities_tblUser_OwnerGuid",
                table: "tblEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClientBillingInfos_tblEntities_EntityGuid",
                table: "tblEntityClientBillingInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClients_tblEntities_EntityGuid",
                table: "tblEntityClients");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClientBillingInfos_tblEntityClients_EntityClientGu~",
                table: "tblEntityClientBillingInfos");

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
                name: "tblAuditEntities");

            migrationBuilder.DropTable(
                name: "tblAuditEntityBillCodeCurrencyRates");

            migrationBuilder.DropTable(
                name: "tblAuditEntityBillCodes");

            migrationBuilder.DropTable(
                name: "tblAuditEntityBillUnits");

            migrationBuilder.DropTable(
                name: "tblAuditEntityClientBillingInfos");

            migrationBuilder.DropTable(
                name: "tblAuditEntityClientGroupClients");

            migrationBuilder.DropTable(
                name: "tblAuditEntityClientGroups");

            migrationBuilder.DropTable(
                name: "tblAuditEntityClients");

            migrationBuilder.DropTable(
                name: "tblAuditEntityCurrencies");

            migrationBuilder.DropTable(
                name: "tblAuditEntityExpenses");

            migrationBuilder.DropTable(
                name: "tblAuditEntityGenders");

            migrationBuilder.DropTable(
                name: "tblAuditEntityJobs");

            migrationBuilder.DropTable(
                name: "tblAuditEntityLocations");

            migrationBuilder.DropTable(
                name: "tblAuditEntityProjects");

            migrationBuilder.DropTable(
                name: "tblAuditEntityTaskCurrencyRates");

            migrationBuilder.DropTable(
                name: "tblAuditEntityTasks");

            migrationBuilder.DropTable(
                name: "tblAuditEntityTimeSheet");

            migrationBuilder.DropTable(
                name: "tblAuditEntityUserDepartmentClaims");

            migrationBuilder.DropTable(
                name: "tblAuditEntityUserDepartments");

            migrationBuilder.DropTable(
                name: "tblAuditEntityUserGroups");

            migrationBuilder.DropTable(
                name: "tblAuditEntityUserGroupUsers");

            migrationBuilder.DropTable(
                name: "tblAuditEntityUsers");

            migrationBuilder.DropTable(
                name: "tblAuditEntityWorkAssignments");

            migrationBuilder.DropTable(
                name: "tblAuditLocations");

            migrationBuilder.DropTable(
                name: "tblDataProtectionKeys");

            migrationBuilder.DropTable(
                name: "tblEntityBillCodeCurrencyRates");

            migrationBuilder.DropTable(
                name: "tblEntityClientGroupClients");

            migrationBuilder.DropTable(
                name: "tblEntityExpenses");

            migrationBuilder.DropTable(
                name: "tblEntityTaskCurrencyRates");

            migrationBuilder.DropTable(
                name: "tblEntityTimeSheets");

            migrationBuilder.DropTable(
                name: "tblEntityUserDepartmentClaims");

            migrationBuilder.DropTable(
                name: "tblEntityUserGroupUsers");

            migrationBuilder.DropTable(
                name: "tblAspNetRoles");

            migrationBuilder.DropTable(
                name: "tblAspNetUsers");

            migrationBuilder.DropTable(
                name: "tblEntityClientGroups");

            migrationBuilder.DropTable(
                name: "tblEntityCurrencies");

            migrationBuilder.DropTable(
                name: "tblEntityTasks");

            migrationBuilder.DropTable(
                name: "tblEntityWorkAssignments");

            migrationBuilder.DropTable(
                name: "tblEntityUserGroups");

            migrationBuilder.DropTable(
                name: "tblEntityUsers");

            migrationBuilder.DropTable(
                name: "tblAdmins");

            migrationBuilder.DropTable(
                name: "tblEntityProjects");

            migrationBuilder.DropTable(
                name: "tblEntityJobs");

            migrationBuilder.DropTable(
                name: "tblEntityBillCodes");

            migrationBuilder.DropTable(
                name: "tblEntityUserDepartments");

            migrationBuilder.DropTable(
                name: "tblEntityBillUnits");

            migrationBuilder.DropTable(
                name: "tblContacts");

            migrationBuilder.DropTable(
                name: "tblEntityGenders");

            migrationBuilder.DropTable(
                name: "tblEntityLocations");

            migrationBuilder.DropTable(
                name: "tblLocation");

            migrationBuilder.DropTable(
                name: "tblUser");

            migrationBuilder.DropTable(
                name: "tblEntities");

            migrationBuilder.DropTable(
                name: "tblEntityClients");

            migrationBuilder.DropTable(
                name: "tblEntityClientBillingInfos");
        }
    }
}
