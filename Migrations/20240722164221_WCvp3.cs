using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace akeassia2.Migrations
{
    /// <inheritdoc />
    public partial class WCvp3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "hybrid_formula_id",
                table: "wcvp_names",
                newName: "hybrid_formula");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "hybrid_formula",
                table: "wcvp_names",
                newName: "hybrid_formula_id");
        }
    }
}
