using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Saaly.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationn : Migration
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
                    Types = table.Column<int>(type: "integer", nullable: false),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("PK_tblAuditEntities", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityClientGroupClient",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityClientGroupClient", x => x.Guid);
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                name: "tblEntities",
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
                    table.PrimaryKey("PK_tblEntities", x => x.Guid);
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                name: "tblAuditEntityBillCode",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityBillCode", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityBillCode_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityBillCodeCurrencyRate",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityBillCodeCurrencyRate", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityBillCodeCurrencyRate_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityBillUnit",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityBillUnit", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityBillUnit_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityClientGroup",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityClientGroup", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityClientGroup_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityCurrency",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityCurrency", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityCurrency_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityExpense",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityExpense", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityExpense_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityGender",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityGender", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityGender_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityJob",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityJob", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityJob_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityLocation",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityLocation", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityLocation_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityProject",
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
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityProject", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityProject_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityTaskCurrencyRate",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityTaskCurrencyRate", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityTaskCurrencyRate_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityTasks", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityTasks_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
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
                    AssigmentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityTimeSheet", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityTimeSheet_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityUser",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityUserGuid = table.Column<Guid>(type: "uuid", nullable: false),
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
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityUser", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityUser_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityUserDepartmentClaim",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityUserDepartmentClaim", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityUserDepartmentClaim_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityUserDepartments", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityUserDepartments_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityUserGroup",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityUserGroup", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityUserGroup_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityUserGroupUser",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityUserGroupUser", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityUserGroupUser_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
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
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    AssigmentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsAssigned = table.Column<bool>(type: "boolean", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityWorkAssignments", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityWorkAssignments_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityBillUnit",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityBillUnit", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityBillUnit_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
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
                        name: "FK_tblEntityCurrency_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
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
                        name: "FK_tblEntityGender_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEntityJob",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityJob", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityJob_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                        name: "FK_tblEntityUserGroup_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
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
                        name: "FK_tblEntityLocation_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityLocation_tblLocation_ParentGuid",
                        column: x => x.ParentGuid,
                        principalTable: "tblLocation",
                        principalColumn: "Guid");
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
                        name: "FK_tblEntityBillCode_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityBillCode_tblEntityBillUnit_BillUnitGuid",
                        column: x => x.BillUnitGuid,
                        principalTable: "tblEntityBillUnit",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_tblEntityUserDepartmentClaim_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityUserDepartmentClaim_tblEntityUserDepartments_Entit~",
                        column: x => x.EntityUserDepartmentGuid,
                        principalTable: "tblEntityUserDepartments",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblContacts",
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
                    EntityLocationGuid = table.Column<Guid>(type: "uuid", nullable: true),
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
                    table.PrimaryKey("PK_tblContacts", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblContacts_tblEntityGender_GenderGuid",
                        column: x => x.GenderGuid,
                        principalTable: "tblEntityGender",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblContacts_tblEntityLocation_EntityLocationGuid",
                        column: x => x.EntityLocationGuid,
                        principalTable: "tblEntityLocation",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblContacts_tblLocation_LocationGuid",
                        column: x => x.LocationGuid,
                        principalTable: "tblLocation",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblEntityBillCodeCurrencyRate",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEntityBillCodeCurrencyRate", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityBillCodeCurrencyRate_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityBillCodeCurrencyRate_tblEntityBillCode_EntityBillC~",
                        column: x => x.EntityBillCodeGuid,
                        principalTable: "tblEntityBillCode",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityBillCodeCurrencyRate_tblEntityCurrency_EntityCurre~",
                        column: x => x.EntityCurrencyGuid,
                        principalTable: "tblEntityCurrency",
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
                        name: "FK_tblAdmins_tblContacts_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContacts",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityClient",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityClient", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityClient_tblContacts_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContacts",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblAuditEntityClient_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuditEntityClientBillingInfo",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUser = table.Column<Guid>(type: "uuid", nullable: true),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    EntityGuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuditEntityClientBillingInfo", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblAuditEntityClientBillingInfo_tblContacts_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContacts",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblAuditEntityClientBillingInfo_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_tblEntityUser_tblContacts_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContacts",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityUser_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityUser_tblEntityBillCode_BillCodeGuid",
                        column: x => x.BillCodeGuid,
                        principalTable: "tblEntityBillCode",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityUser_tblEntityUserDepartments_DepartmentGuid",
                        column: x => x.DepartmentGuid,
                        principalTable: "tblEntityUserDepartments",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityUser_tblEntityUser_ManagerGuid",
                        column: x => x.ManagerGuid,
                        principalTable: "tblEntityUser",
                        principalColumn: "Guid");
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
                        name: "FK_tblEntityUserGroupUser_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
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
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    AssigmentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsAssigned = table.Column<bool>(type: "boolean", nullable: false),
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
                    table.PrimaryKey("PK_tblEntityWorkAssignments", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityWorkAssignments_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityWorkAssignments_tblEntityJob_JobGuid",
                        column: x => x.JobGuid,
                        principalTable: "tblEntityJob",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityWorkAssignments_tblEntityUser_EntityUserGuid",
                        column: x => x.EntityUserGuid,
                        principalTable: "tblEntityUser",
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
                        name: "FK_tblEntityClient_tblContacts_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContacts",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityClient_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
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
                        name: "FK_tblEntityClientBillingInfo_tblContacts_ContactGuid",
                        column: x => x.ContactGuid,
                        principalTable: "tblContacts",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_tblEntityClientBillingInfo_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityClientBillingInfo_tblEntityClient_EntityClientGuid",
                        column: x => x.EntityClientGuid,
                        principalTable: "tblEntityClient",
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
                        name: "FK_tblEntityProject_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityProject_tblEntityClient_ClientGuid",
                        column: x => x.ClientGuid,
                        principalTable: "tblEntityClient",
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
                    Deleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                        name: "FK_tblEntityTasks_tblEntityBillUnit_BillUnitGuid",
                        column: x => x.BillUnitGuid,
                        principalTable: "tblEntityBillUnit",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTasks_tblEntityProject_ProjectGuid",
                        column: x => x.ProjectGuid,
                        principalTable: "tblEntityProject",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "tblEntityTaskCurrencyRate",
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
                    table.PrimaryKey("PK_tblEntityTaskCurrencyRate", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_tblEntityTaskCurrencyRate_tblEntities_EntityGuid",
                        column: x => x.EntityGuid,
                        principalTable: "tblEntities",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTaskCurrencyRate_tblEntityCurrency_CurrencyGuid",
                        column: x => x.CurrencyGuid,
                        principalTable: "tblEntityCurrency",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEntityTaskCurrencyRate_tblEntityTasks_TaskGuid",
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
                name: "IX_tblAspNetUsers_EntityUserGuid",
                table: "tblAspNetUsers",
                column: "EntityUserGuid");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "tblAspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityBillCode_EntityGuid",
                table: "tblAuditEntityBillCode",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityBillCodeCurrencyRate_EntityGuid",
                table: "tblAuditEntityBillCodeCurrencyRate",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityBillUnit_EntityGuid",
                table: "tblAuditEntityBillUnit",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityClient_ContactGuid",
                table: "tblAuditEntityClient",
                column: "ContactGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityClient_EntityGuid",
                table: "tblAuditEntityClient",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityClientBillingInfo_ContactGuid",
                table: "tblAuditEntityClientBillingInfo",
                column: "ContactGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityClientBillingInfo_EntityGuid",
                table: "tblAuditEntityClientBillingInfo",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityClientGroup_EntityGuid",
                table: "tblAuditEntityClientGroup",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityCurrency_EntityGuid",
                table: "tblAuditEntityCurrency",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityExpense_EntityGuid",
                table: "tblAuditEntityExpense",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityGender_EntityGuid",
                table: "tblAuditEntityGender",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityJob_EntityGuid",
                table: "tblAuditEntityJob",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityLocation_EntityGuid",
                table: "tblAuditEntityLocation",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityProject_EntityGuid",
                table: "tblAuditEntityProject",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityTaskCurrencyRate_EntityGuid",
                table: "tblAuditEntityTaskCurrencyRate",
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
                name: "IX_tblAuditEntityUser_EntityGuid",
                table: "tblAuditEntityUser",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityUserDepartmentClaim_EntityGuid",
                table: "tblAuditEntityUserDepartmentClaim",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityUserDepartments_EntityGuid",
                table: "tblAuditEntityUserDepartments",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityUserGroup_EntityGuid",
                table: "tblAuditEntityUserGroup",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuditEntityUserGroupUser_EntityGuid",
                table: "tblAuditEntityUserGroupUser",
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
                name: "IX_tblEntityBillCode_BillUnitGuid",
                table: "tblEntityBillCode",
                column: "BillUnitGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillCode_EntityGuid",
                table: "tblEntityBillCode",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillCodeCurrencyRate_EntityBillCodeGuid",
                table: "tblEntityBillCodeCurrencyRate",
                column: "EntityBillCodeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillCodeCurrencyRate_EntityCurrencyGuid",
                table: "tblEntityBillCodeCurrencyRate",
                column: "EntityCurrencyGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillCodeCurrencyRate_EntityGuid",
                table: "tblEntityBillCodeCurrencyRate",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityBillUnit_EntityGuid",
                table: "tblEntityBillUnit",
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
                name: "IX_tblEntityJob_EntityGuid",
                table: "tblEntityJob",
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
                name: "IX_tblEntityTaskCurrencyRate_CurrencyGuid",
                table: "tblEntityTaskCurrencyRate",
                column: "CurrencyGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTaskCurrencyRate_EntityGuid",
                table: "tblEntityTaskCurrencyRate",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityTaskCurrencyRate_TaskGuid",
                table: "tblEntityTaskCurrencyRate",
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
                name: "IX_tblEntityUserDepartmentClaim_EntityGuid",
                table: "tblEntityUserDepartmentClaim",
                column: "EntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserDepartmentClaim_EntityUserDepartmentGuid",
                table: "tblEntityUserDepartmentClaim",
                column: "EntityUserDepartmentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_tblEntityUserDepartments_EntityGuid",
                table: "tblEntityUserDepartments",
                column: "EntityGuid");

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
                name: "FK_tblEntityClient_tblContacts_ContactGuid",
                table: "tblEntityClient");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClientBillingInfo_tblContacts_ContactGuid",
                table: "tblEntityClientBillingInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClient_tblEntities_EntityGuid",
                table: "tblEntityClient");

            migrationBuilder.DropForeignKey(
                name: "FK_tblEntityClientBillingInfo_tblEntities_EntityGuid",
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
                name: "tblAuditEntities");

            migrationBuilder.DropTable(
                name: "tblAuditEntityBillCode");

            migrationBuilder.DropTable(
                name: "tblAuditEntityBillCodeCurrencyRate");

            migrationBuilder.DropTable(
                name: "tblAuditEntityBillUnit");

            migrationBuilder.DropTable(
                name: "tblAuditEntityClient");

            migrationBuilder.DropTable(
                name: "tblAuditEntityClientBillingInfo");

            migrationBuilder.DropTable(
                name: "tblAuditEntityClientGroup");

            migrationBuilder.DropTable(
                name: "tblAuditEntityClientGroupClient");

            migrationBuilder.DropTable(
                name: "tblAuditEntityCurrency");

            migrationBuilder.DropTable(
                name: "tblAuditEntityExpense");

            migrationBuilder.DropTable(
                name: "tblAuditEntityGender");

            migrationBuilder.DropTable(
                name: "tblAuditEntityJob");

            migrationBuilder.DropTable(
                name: "tblAuditEntityLocation");

            migrationBuilder.DropTable(
                name: "tblAuditEntityProject");

            migrationBuilder.DropTable(
                name: "tblAuditEntityTaskCurrencyRate");

            migrationBuilder.DropTable(
                name: "tblAuditEntityTasks");

            migrationBuilder.DropTable(
                name: "tblAuditEntityTimeSheet");

            migrationBuilder.DropTable(
                name: "tblAuditEntityUser");

            migrationBuilder.DropTable(
                name: "tblAuditEntityUserDepartmentClaim");

            migrationBuilder.DropTable(
                name: "tblAuditEntityUserDepartments");

            migrationBuilder.DropTable(
                name: "tblAuditEntityUserGroup");

            migrationBuilder.DropTable(
                name: "tblAuditEntityUserGroupUser");

            migrationBuilder.DropTable(
                name: "tblAuditEntityWorkAssignments");

            migrationBuilder.DropTable(
                name: "tblAuditLocations");

            migrationBuilder.DropTable(
                name: "tblDataProtectionKeys");

            migrationBuilder.DropTable(
                name: "tblEntityBillCodeCurrencyRate");

            migrationBuilder.DropTable(
                name: "tblEntityTaskCurrencyRate");

            migrationBuilder.DropTable(
                name: "tblEntityUserDepartmentClaim");

            migrationBuilder.DropTable(
                name: "tblEntityUserGroupUser");

            migrationBuilder.DropTable(
                name: "tblEntityWorkAssignments");

            migrationBuilder.DropTable(
                name: "tblAspNetRoles");

            migrationBuilder.DropTable(
                name: "tblAspNetUsers");

            migrationBuilder.DropTable(
                name: "tblEntityCurrency");

            migrationBuilder.DropTable(
                name: "tblEntityTasks");

            migrationBuilder.DropTable(
                name: "tblEntityUserGroup");

            migrationBuilder.DropTable(
                name: "tblEntityJob");

            migrationBuilder.DropTable(
                name: "tblAdmins");

            migrationBuilder.DropTable(
                name: "tblEntityUser");

            migrationBuilder.DropTable(
                name: "tblEntityProject");

            migrationBuilder.DropTable(
                name: "tblEntityBillCode");

            migrationBuilder.DropTable(
                name: "tblEntityUserDepartments");

            migrationBuilder.DropTable(
                name: "tblEntityBillUnit");

            migrationBuilder.DropTable(
                name: "tblContacts");

            migrationBuilder.DropTable(
                name: "tblEntityGender");

            migrationBuilder.DropTable(
                name: "tblEntityLocation");

            migrationBuilder.DropTable(
                name: "tblLocation");

            migrationBuilder.DropTable(
                name: "tblEntities");

            migrationBuilder.DropTable(
                name: "tblEntityClientBillingInfo");

            migrationBuilder.DropTable(
                name: "tblEntityClient");
        }
    }
}
