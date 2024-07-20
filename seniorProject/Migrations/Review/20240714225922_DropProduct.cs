using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace seniorProject.Migrations.Review
{
    /// <inheritdoc />
    public partial class DropProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Product_productId",
                table: "Review");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Review_productId",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "productId",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "productId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_productId",
                table: "Review",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Product_productId",
                table: "Review",
                column: "productId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
