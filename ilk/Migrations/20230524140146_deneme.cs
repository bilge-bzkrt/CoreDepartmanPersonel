using Microsoft.EntityFrameworkCore.Migrations;

namespace ilk.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departmans",
                columns: table => new
                {
                    departman_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departman_adi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmans", x => x.departman_id);
                });

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    personel_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personel_adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personel_soyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personel_sehir = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.personel_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "departmans");

            migrationBuilder.DropTable(
                name: "personels");
        }
    }
}
