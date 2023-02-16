using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDBFirst.Migrations
{
    /// <inheritdoc />
    public partial class IoAggiungoUnCampo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescrizioneAggiuntiva",
                table: "tabella2",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescrizioneAggiuntiva",
                table: "tabella2");
        }
    }
}
