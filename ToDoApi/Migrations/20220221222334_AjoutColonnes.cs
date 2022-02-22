using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ni_Soft.ToDoApi.Migrations
{
    public partial class AjoutColonnes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Auteur",
                table: "ToDo",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreation",
                table: "ToDo",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Auteur",
                table: "ToDo");

            migrationBuilder.DropColumn(
                name: "DateCreation",
                table: "ToDo");
        }
    }
}
