using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhumaloCraft2.Data.Migrations
{
    /// <inheritdoc />
    public partial class Total : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "ArtWorks",
                newName: "Id");

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "ArtWorks",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "Piccasso.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "StarringNight.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "Lumiere.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "Amandla.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "Sky.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "Kasi.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "PolarBear.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "CoralReef.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "Crystal.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "Elephant.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "/images/AfricanDoll.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "Human.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "SerenityBowl.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "EmberMug.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "WhisperVase.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageFileName", "Total" },
                values: new object[] { "EchoTeapot.jpg.png", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "ImageFileName",
                value: "Piccasso.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "ImageFileName",
                value: "StarringNight.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "ImageFileName",
                value: "Lumiere.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "ImageFileName",
                value: "Amandla.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "ImageFileName",
                value: "Sky.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "ImageFileName",
                value: "Kasi.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "ImageFileName",
                value: "PolarBear.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "ImageFileName",
                value: "CoralReef.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "ImageFileName",
                value: "Crystal.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "ImageFileName",
                value: "Elephant.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "ImageFileName",
                value: "AfricanDoll.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "ImageFileName",
                value: "Human.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "ImageFileName",
                value: "SerenityBowl.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "ImageFileName",
                value: "EmberMug.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "ImageFileName",
                value: "WhisperVase.jpg.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "ImageFileName",
                value: "EchoTeapot.jpg.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "ArtWorks");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ArtWorks",
                newName: "id");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 1,
                column: "ImageFileName",
                value: "/images/Piccasso.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 2,
                column: "ImageFileName",
                value: "/images/StarringNight.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 3,
                column: "ImageFileName",
                value: "/images/Lumiere.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 4,
                column: "ImageFileName",
                value: "/images/Amandla.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 5,
                column: "ImageFileName",
                value: "/images/Sky.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 6,
                column: "ImageFileName",
                value: "/images/Kasi.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 7,
                column: "ImageFileName",
                value: "/images/PolarBear.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 8,
                column: "ImageFileName",
                value: "/images/CoralReef.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 9,
                column: "ImageFileName",
                value: "/images/Crystal.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 10,
                column: "ImageFileName",
                value: "/images/Elephant.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 11,
                column: "ImageFileName",
                value: "/images/AfricanDoll.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 12,
                column: "ImageFileName",
                value: "/images/Human.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 13,
                column: "ImageFileName",
                value: "/images/SerenityBowl.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 14,
                column: "ImageFileName",
                value: "/images/EmberMug.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 15,
                column: "ImageFileName",
                value: "/images/WhisperVase.jpg");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "id",
                keyValue: 16,
                column: "ImageFileName",
                value: "/images/EchoTeapot.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "ImageFileName",
                value: "/images/Piccasso.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "ImageFileName",
                value: "/images/StarringNight.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "ImageFileName",
                value: "/images/Lumiere.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "ImageFileName",
                value: "/images/Amandla.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "ImageFileName",
                value: "/images/Sky.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "ImageFileName",
                value: "/images/Kasi.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "ImageFileName",
                value: "/images/PolarBear.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "ImageFileName",
                value: "/images/CoralReef.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "ImageFileName",
                value: "/images/Crystal.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "ImageFileName",
                value: "/images/Elephant.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "ImageFileName",
                value: "/images/AfricanDoll.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "ImageFileName",
                value: "/images/Human.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "ImageFileName",
                value: "/images/SerenityBowl.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "ImageFileName",
                value: "/images/EmberMug.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "ImageFileName",
                value: "/images/WhisperVase.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "ImageFileName",
                value: "/images/EchoTeapot.jpg");
        }
    }
}
