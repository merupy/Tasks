using Microsoft.EntityFrameworkCore.Migrations;

namespace database.Data.Migrations
{
    public partial class initial12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerCode_PersonId",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerCode",
                table: "Customers",
                column: "CustomerCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerCode",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerCode_PersonId",
                table: "Customers",
                columns: new[] { "CustomerCode", "PersonId" },
                unique: true);
        }
    }
}
