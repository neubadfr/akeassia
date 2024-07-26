using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace akeassia2.Migrations
{
    /// <inheritdoc />
    public partial class WCvp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wcvp_names",
                columns: table => new
                {
                    WcvpID = table.Column<string>(type: "text", nullable: false),
                    ipni_id = table.Column<string>(type: "text", nullable: true),
                    taxon_rank = table.Column<string>(type: "text", nullable: true),
                    taxon_status = table.Column<string>(type: "text", nullable: true),
                    family = table.Column<string>(type: "text", nullable: true),
                    genus_hybrid = table.Column<string>(type: "text", nullable: true),
                    genus = table.Column<string>(type: "text", nullable: true),
                    species_hybrid = table.Column<string>(type: "text", nullable: true),
                    species = table.Column<string>(type: "text", nullable: true),
                    infraspecific_rank = table.Column<string>(type: "text", nullable: true),
                    infraspecies = table.Column<string>(type: "text", nullable: true),
                    parenthetical_author = table.Column<string>(type: "text", nullable: true),
                    primary_author = table.Column<string>(type: "text", nullable: true),
                    publication_author = table.Column<string>(type: "text", nullable: true),
                    place_of_publication = table.Column<string>(type: "text", nullable: true),
                    volume_and_page = table.Column<string>(type: "text", nullable: true),
                    first_published = table.Column<string>(type: "text", nullable: true),
                    nomenclatural_remarks = table.Column<string>(type: "text", nullable: true),
                    geographic_area = table.Column<string>(type: "text", nullable: true),
                    lifeform_description = table.Column<string>(type: "text", nullable: true),
                    climate_description = table.Column<string>(type: "text", nullable: true),
                    taxon_name = table.Column<string>(type: "text", nullable: true),
                    taxon_authors = table.Column<string>(type: "text", nullable: true),
                    accepted_plant_name_id = table.Column<string>(type: "text", nullable: true),
                    basionym_plant_name_id = table.Column<string>(type: "text", nullable: true),
                    replaced_synonym_author = table.Column<string>(type: "text", nullable: true),
                    homotypic_synonym = table.Column<string>(type: "text", nullable: true),
                    parent_plant_name_id = table.Column<string>(type: "text", nullable: true),
                    powo_id = table.Column<string>(type: "text", nullable: true),
                    hybrid_formula_id = table.Column<string>(type: "text", nullable: true),
                    reviewed = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcvp_names", x => x.WcvpID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wcvp_names");
        }
    }
}
