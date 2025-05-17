using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft2.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArtWorks",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatID = table.Column<int>(type: "int", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtWorks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CatId",
                        column: x => x.CatId,
                        principalTable: "Categories",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ArtWorks",
                columns: new[] { "id", "Artist", "Availability", "CatID", "Description", "Details", "ImageFileName", "Price", "ProdName", "Quantity", "Type" },
                values: new object[,]
                {
                    { 1, "Khumalo", "Available", 0, "A vibrant abstract painting featuring bold, overlapping geometric shapes and vivid colors. The dynamic composition and contrasting hues create a sense of movement and depth, evoking strong emotions and inviting viewers to interpret the scene in their own unique way.", null, "/images/Piccasso.jpg", 250000m, "Piccasso", 1, "Painting" },
                    { 2, "Van Gogh", "Available", 0, "A serene landscape painting depicting a tranquil sunset over a calm lake. Soft, warm hues blend seamlessly in the sky, reflecting beautifully on the water’s surface. Silhouetted trees along the shore add depth and balance to the peaceful scene.", null, "/images/StarringNight.jpg", 55502m, "Starring Night", 1, "Painting" },
                    { 3, "Monet", "Available", 0, "Fine work of art from France", null, "/images/Lumiere.jpg", 6500m, "Lumiere", 3, "Painting" },
                    { 4, "Khumalo", "Available", 0, "A powerful painting capturing the essence of African struggle, with strong, expressive figures set against a stark, tumultuous backdrop. Earthy tones and bold strokes convey resilience and determination, while symbolic elements highlight the rich cultural heritage and enduring spirit of the people.", null, "/images/Amandla.jpg", 5302m, "Amandla", 3, "Painting" },
                    { 5, "Smith", "Available", 0, "A breathtaking photo of the Swiss Alps, showcasing majestic snow-capped peaks under a clear blue sky. Lush green valleys and sparkling alpine lakes contrast beautifully with the rugged mountain terrain, creating a stunning and serene natural landscape.", null, "/images/Sky.jpg", 345m, "Sky", 8, "Photos" },
                    { 6, "John", "Available", 0, "A compelling photo of a South African township, capturing vibrant, colorful homes packed closely together. The lively streets are filled with activity, reflecting the resilience and community spirit of the residents. In the background, sprawling urban landscapes contrast with the nearby natural beauty.", null, "/images/Kasi.jpg", 100m, "Kasi", 10, "Photos" },
                    { 7, "Morris", "Available", 0, "A magnificent polar bear, standing tall against a backdrop of pristine Arctic ice. Its thick, white fur glistens in the sunlight, blending seamlessly with the icy surroundings. With powerful limbs and sharp claws, it exudes strength and grace, a true master of its frozen domain.", null, "/images/PolarBear.jpg", 250m, "Polar Bear", 8, "Photos" },
                    { 8, "Dory", "Available", 0, "A colorful coral reef alive with marine creatures, swaying gently in the clear turquoise waters.", null, "/images/CoralReef.jpg", 2345m, "Coral Reef", 5, "Photos" },
                    { 9, "Khumalo", "Available", 0, "A dazzling crystal sculpture, intricately crafted to capture and reflect light with stunning precision.", null, "/images/Crystal.jpg", 2010m, "Crystal", 4, "Sculpture" },
                    { 10, "Khumalo", "Available", 0, "A majestic elephant sculpture, crafted with lifelike detail and grace, capturing the essence of these gentle giants in a stunning work of art.", null, "/images/Elephant.jpg", 550m, "Elephant", 8, "Sculpture" },
                    { 11, "Khumalo", "Available", 0, "An African doll, beautifully handcrafted with vibrant fabrics and intricate beadwork, representing the rich cultural heritage and artistic traditions of the continent.", null, "/images/AfricanDoll.jpg", 610m, "African Doll", 12, "Sculpture" },
                    { 12, "Khumalo", "Available", 0, "A human sculpture serving as furniture, blending artistry with functionality seamlessly.", null, "/images/Human.jpg", 34010m, "Human", 2, "Sculpture" },
                    { 13, "Serenity Maker", "Available", 0, "A delicate ceramic bowl with a serene blue glaze, reminiscent of tranquil ocean waters. Its smooth curves and gentle ripples evoke a sense of calm and relaxation.", null, "/images/SerenityBowl.jpg", 670m, "Serenity Bowl", 21, "Ceramics" },
                    { 14, "Khumalo", "Available", 0, "A rustic ceramic mug with a rich, earthy glaze reminiscent of glowing embers. Its sturdy handle and textured surface provide a cozy and comforting feel, perfect for enjoying a warm beverage on a chilly evening.", null, "/images/EmberMug.jpg", 310m, "Ember Mug", 12, "Ceramics" },
                    { 15, "Whisper Maker", "Available", 0, "A slender ceramic vase with a soft, matte finish, exuding elegance and understated beauty. Its graceful silhouette and muted tones create a sense of tranquility, making it ideal for showcasing delicate blooms.", null, "/images/WhisperVase.jpg", 200m, "Whisper Vase", 4, "Ceramics" },
                    { 16, "Owami", "Available", 0, "A charming ceramic teapot adorned with intricate floral motifs, echoing the beauty of nature. Its generous size and graceful spout make it both functional and decorative, adding a touch of whimsy to tea time.", null, "/images/EchoTeapot.jpg", 450m, "Echo Teapot", 8, "Ceramics" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CatId", "CatName" },
                values: new object[,]
                {
                    { 1, "Paintings" },
                    { 2, "Photos" },
                    { 3, "Sculptures" },
                    { 4, "Ceramics" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Artist", "Availability", "CatId", "Description", "Details", "ImageFileName", "Price", "ProdName", "Quantity" },
                values: new object[,]
                {
                    { 1, "Khumalo", "Available", 1, "A vibrant abstract painting featuring bold, overlapping geometric shapes and vivid colors. The dynamic composition and contrasting hues create a sense of movement and depth, evoking strong emotions and inviting viewers to interpret the scene in their own unique way.", null, "/images/Piccasso.jpg", 250000m, "Piccasso", 1 },
                    { 2, "Van Gogh", "Available", 1, "A serene landscape painting depicting a tranquil sunset over a calm lake. Soft, warm hues blend seamlessly in the sky, reflecting beautifully on the water’s surface. Silhouetted trees along the shore add depth and balance to the peaceful scene.", null, "/images/StarringNight.jpg", 55502m, "Starring Night", 1 },
                    { 3, "Monet", "Available", 1, "Fine work of art from France", null, "/images/Lumiere.jpg", 6500m, "Lumiere", 3 },
                    { 4, "Khumalo", "Available", 1, "A powerful painting capturing the essence of African struggle, with strong, expressive figures set against a stark, tumultuous backdrop. Earthy tones and bold strokes convey resilience and determination, while symbolic elements highlight the rich cultural heritage and enduring spirit of the people.", null, "/images/Amandla.jpg", 5302m, "Amandla", 3 },
                    { 5, "Smith", "Available", 2, "A breathtaking photo of the Swiss Alps, showcasing majestic snow-capped peaks under a clear blue sky. Lush green valleys and sparkling alpine lakes contrast beautifully with the rugged mountain terrain, creating a stunning and serene natural landscape.", null, "/images/Sky.jpg", 345m, "Sky", 8 },
                    { 6, "John", "Available", 2, "A compelling photo of a South African township, capturing vibrant, colorful homes packed closely together. The lively streets are filled with activity, reflecting the resilience and community spirit of the residents. In the background, sprawling urban landscapes contrast with the nearby natural beauty.", null, "/images/Kasi.jpg", 100m, "Kasi", 10 },
                    { 7, "Morris", "Available", 2, "A magnificent polar bear, standing tall against a backdrop of pristine Arctic ice. Its thick, white fur glistens in the sunlight, blending seamlessly with the icy surroundings. With powerful limbs and sharp claws, it exudes strength and grace, a true master of its frozen domain.", null, "/images/PolarBear.jpg", 250m, "Polar Bear", 8 },
                    { 8, "Dory", "Available", 2, "A colorful coral reef alive with marine creatures, swaying gently in the clear turquoise waters.", null, "/images/CoralReef.jpg", 2345m, "Coral Reef", 5 },
                    { 9, "Khumalo", "Available", 3, "A dazzling crystal sculpture, intricately crafted to capture and reflect light with stunning precision.", null, "/images/Crystal.jpg", 2010m, "Crystal", 4 },
                    { 10, "Khumalo", "Available", 3, "A majestic elephant sculpture, crafted with lifelike detail and grace, capturing the essence of these gentle giants in a stunning work of art.", null, "/images/Elephant.jpg", 550m, "Elephant", 8 },
                    { 11, "Khumalo", "Available", 3, "An African doll, beautifully handcrafted with vibrant fabrics and intricate beadwork, representing the rich cultural heritage and artistic traditions of the continent.", null, "/images/AfricanDoll.jpg", 610m, "African Doll", 12 },
                    { 12, "Khumalo", "Available", 3, "A human sculpture serving as furniture, blending artistry with functionality seamlessly.", null, "/images/Human.jpg", 34010m, "Human", 2 },
                    { 13, "Serenity Maker", "Available", 4, "A delicate ceramic bowl with a serene blue glaze, reminiscent of tranquil ocean waters. Its smooth curves and gentle ripples evoke a sense of calm and relaxation.", null, "/images/SerenityBowl.jpg", 670m, "Serenity Bowl", 21 },
                    { 14, "Khumalo", "Available", 4, "A rustic ceramic mug with a rich, earthy glaze reminiscent of glowing embers. Its sturdy handle and textured surface provide a cozy and comforting feel, perfect for enjoying a warm beverage on a chilly evening.", null, "/images/EmberMug.jpg", 310m, "Ember Mug", 12 },
                    { 15, "Whisper Maker", "Available", 4, "A slender ceramic vase with a soft, matte finish, exuding elegance and understated beauty. Its graceful silhouette and muted tones create a sense of tranquility, making it ideal for showcasing delicate blooms.", null, "/images/WhisperVase.jpg", 200m, "Whisper Vase", 4 },
                    { 16, "Owami", "Available", 4, "A charming ceramic teapot adorned with intricate floral motifs, echoing the beauty of nature. Its generous size and graceful spout make it both functional and decorative, adding a touch of whimsy to tea time.", null, "/images/EchoTeapot.jpg", 450m, "Echo Teapot", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatId",
                table: "Products",
                column: "CatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtWorks");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
