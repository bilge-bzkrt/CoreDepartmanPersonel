using Microsoft.EntityFrameworkCore.Migrations;

namespace ilk.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmans",
                columns: table => new
                {
                    departman_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departman_adi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmans", x => x.departman_id);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    personel_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personel_adi = table.Column<string>(nullable: true),
                    personel_soyadi = table.Column<string>(nullable: true),
                    personel_sehir = table.Column<string>(nullable: true),
                    departman_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.personel_id);
                    table.ForeignKey(
                        name: "FK_Personels_Departmans_departman_id",
                        column: x => x.departman_id,
                        principalTable: "Departmans",
                        principalColumn: "departman_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personels_departman_id",
                table: "Personels",
                column: "departman_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Departmans");
        }
    }
}
