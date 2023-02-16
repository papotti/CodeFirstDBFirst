﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDBFirst.Migrations
{
    /// <inheritdoc />
    public partial class Campo5e6Tabella1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Campo6",
                table: "Tabella1",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Campo6",
                table: "Tabella1");
        }
    }
}
