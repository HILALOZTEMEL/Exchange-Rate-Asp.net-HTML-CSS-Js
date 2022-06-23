using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalSerbestPiyasaDoviz.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DolarTahmin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "DolarTahmin", "UserName" },
                values: new object[] { 1, "18.6", "Hilal" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "DolarTahmin", "UserName" },
                values: new object[] { 2, "13.11", "Zehra" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "DolarTahmin", "UserName" },
                values: new object[] { 3, "15.96", "Alihan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
