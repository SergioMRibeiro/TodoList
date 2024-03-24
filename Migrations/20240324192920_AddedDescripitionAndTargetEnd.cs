using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuTodo2.Migrations
{
    /// <inheritdoc />
    public partial class AddedDescripitionAndTargetEnd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropPrimaryKey(
                name: "PK_meuTodos",
                table: "MeuTodos");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MeuTodos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "TargetEnd",
                table: "MeuTodos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeuTodos",
                table: "MeuTodos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MeuTodos",
                table: "MeuTodos");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "MeuTodos");

            migrationBuilder.DropColumn(
                name: "TargetEnd",
                table: "MeuTodos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_meuTodos",
                table: "MeuTodos",
                column: "Id");
        }
    }
}
