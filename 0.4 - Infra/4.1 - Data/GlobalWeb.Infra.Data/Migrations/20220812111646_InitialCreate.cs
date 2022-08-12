using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GlobalWeb.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fullname = table.Column<string>(type: "varchar(250)", nullable: false),
                    birthdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    document = table.Column<string>(type: "varchar(20)", nullable: false),
                    address = table.Column<string>(type: "varchar(250)", nullable: false),
                    dateregister = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 8, 12, 12, 16, 46, 169, DateTimeKind.Local).AddTicks(34)),
                    active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "client",
                columns: new[] { "id", "active", "address", "birthdate", "dateregister", "document", "fullname" },
                values: new object[] { 1, true, "Quadra SGAN 914 Módulo C", new DateTime(2001, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "08276305903", "Guilherme Enrico Pietro Nascimento" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "client");
        }
    }
}
