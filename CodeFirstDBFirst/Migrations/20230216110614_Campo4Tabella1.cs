using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDBFirst.Migrations
{
    /// <inheritdoc />
    public partial class Campo4Tabella1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Campo4",
                table: "Tabella1",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Campo4",
                table: "Tabella1");
        }
    }
}
