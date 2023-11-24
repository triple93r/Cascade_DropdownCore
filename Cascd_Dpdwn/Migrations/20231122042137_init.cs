using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cascd_Dpdwn.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Country",
                columns: table => new
                {
                    Cnt_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ter_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Country", x => x.Cnt_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Stt",
                columns: table => new
                {
                    Stt_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    St_Name = table.Column<int>(type: "int", nullable: false),
                    Cnt_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Stt", x => x.Stt_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Territory",
                columns: table => new
                {
                    Ter_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tr_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Territory", x => x.Ter_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Country");

            migrationBuilder.DropTable(
                name: "tbl_Stt");

            migrationBuilder.DropTable(
                name: "tbl_Territory");
        }
    }
}
