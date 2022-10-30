using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestorOS.Migrations
{
    public partial class OrdensDeServicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "OrdensDeServicos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "OrdensDeServicos",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Feito",
                table: "OrdensDeServicos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "OrdensDeServicos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "OrdensDeServicos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "OrdensDeServicos");

            migrationBuilder.DropColumn(
                name: "Feito",
                table: "OrdensDeServicos");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "OrdensDeServicos");
        }
    }
}
