using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreTest.DataAcess.Migrations
{
    public partial class CreateTableAdress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "AdressId",
                table: "People",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdressStreet = table.Column<string>(nullable: true),
                    AdressNumber = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_AdressId",
                table: "People",
                column: "AdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Adresses_AdressId",
                table: "People",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Adresses_AdressId",
                table: "People");

            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropIndex(
                name: "IX_People_AdressId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
