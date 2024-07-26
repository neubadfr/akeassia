using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace akeassia2.Migrations
{
    /// <inheritdoc />
    public partial class WCvp2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WcvpID",
                table: "wcvp_names",
                newName: "plant_name_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "plant_name_id",
                table: "wcvp_names",
                newName: "WcvpID");
        }
    }
}
