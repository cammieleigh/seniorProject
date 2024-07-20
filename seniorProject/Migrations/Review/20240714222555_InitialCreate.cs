using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace seniorProject.Migrations.Review
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "Product",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Price = table.Column<float>(type: "real", nullable: true),
            //         Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Img = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Product", x => x.Id);
            //     });
            migrationBuilder.DropTable(
                name: "Review");
            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductReview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductRating = table.Column<int>(type: "int", nullable: true),
                    productId = table.Column<int>(type: "int", nullable: false)
                }
                );

    
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
