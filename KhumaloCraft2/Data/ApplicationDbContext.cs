using KhumaloCraft2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KhumaloCraft2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ArtWork> ArtWorks { get; set; }
        public DbSet<Group> Group{ get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CatId = 1, CatName = "Paintings" },
                new Category { CatId = 2, CatName = "Photos" },
                new Category { CatId = 3, CatName = "Sculptures" },
                new Category { CatId = 4, CatName = "Ceramics" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    id = 1,
                    Artist = "Khumalo",
                    ProdName = "Piccasso",
                    CatId = 1,
                    Price = 250000,
                    Availability = "Available",
                    Quantity = 1,
                    Description = "A vibrant abstract painting featuring bold, overlapping geometric shapes and vivid colors. The dynamic composition and contrasting hues create a sense of movement and depth, evoking strong emotions and inviting viewers to interpret the scene in their own unique way.",
                    ImageFileName = "Piccasso.jpg.png"
                },
                new Product
                {
                    id = 2,
                    Artist = "Van Gogh",
                    ProdName = "Starring Night",
                    CatId = 1,
                    Price = 55502,
                    Availability = "Available",
                    Quantity = 1,
                    Description = "A serene landscape painting depicting a tranquil sunset over a calm lake. Soft, warm hues blend seamlessly in the sky, reflecting beautifully on the water’s surface. Silhouetted trees along the shore add depth and balance to the peaceful scene.",
                    ImageFileName = "StarringNight.jpg.png"
                },
                new Product
                {
                    id = 3,
                    Artist = "Monet",
                    ProdName = "Lumiere",
                    CatId = 1,
                    Price = 6500,
                    Availability = "Available",
                    Quantity = 3,
                    Description = "Fine work of art from France",
                    ImageFileName = "Lumiere.jpg.png"
                },
                new Product
                {
                    id = 4,
                    Artist = "Khumalo",
                    ProdName = "Amandla",
                    CatId = 1,
                    Price = 5302,
                    Availability = "Available",
                    Quantity = 3,
                    Description = "A powerful painting capturing the essence of African struggle, with strong, expressive figures set against a stark, tumultuous backdrop. Earthy tones and bold strokes convey resilience and determination, while symbolic elements highlight the rich cultural heritage and enduring spirit of the people.",
                    ImageFileName = "Amandla.jpg.png"
                },
                new Product
                {
                    id = 5,
                    Artist = "Smith",
                    ProdName = "Sky",
                    CatId = 2,
                    Price = 345,
                    Availability = "Available",
                    Quantity = 8,
                    Description = "A breathtaking photo of the Swiss Alps, showcasing majestic snow-capped peaks under a clear blue sky. Lush green valleys and sparkling alpine lakes contrast beautifully with the rugged mountain terrain, creating a stunning and serene natural landscape.",
                    ImageFileName = "Sky.jpg.png"
                },
                new Product
                {
                    id = 6,
                    Artist = "John",
                    ProdName = "Kasi",
                    CatId = 2,
                    Price = 100,
                    Availability = "Available",
                    Quantity = 10,
                    Description = "A compelling photo of a South African township, capturing vibrant, colorful homes packed closely together. The lively streets are filled with activity, reflecting the resilience and community spirit of the residents. In the background, sprawling urban landscapes contrast with the nearby natural beauty.",
                    ImageFileName = "Kasi.jpg.png"
                },
                new Product
                {
                    id = 7,
                    Artist = "Morris",
                    ProdName = "Polar Bear",
                    CatId = 2,
                    Price = 250,
                    Availability = "Available",
                    Quantity = 8,
                    Description = "A magnificent polar bear, standing tall against a backdrop of pristine Arctic ice. Its thick, white fur glistens in the sunlight, blending seamlessly with the icy surroundings. With powerful limbs and sharp claws, it exudes strength and grace, a true master of its frozen domain.",
                    ImageFileName = "PolarBear.jpg.png"
                },
                new Product
                {
                    id = 8,
                    Artist = "Dory",
                    ProdName = "Coral Reef",
                    CatId = 2,
                    Price = 2345,
                    Availability = "Available",
                    Quantity = 5,
                    Description = "A colorful coral reef alive with marine creatures, swaying gently in the clear turquoise waters.",
                    ImageFileName = "CoralReef.jpg.png"
                },
                new Product
                {
                    id = 9,
                    Artist = "Khumalo",
                    ProdName = "Crystal",
                    CatId = 3,
                    Price = 2010,
                    Availability = "Available",
                    Quantity = 4,
                    Description = "A dazzling crystal sculpture, intricately crafted to capture and reflect light with stunning precision.",
                    ImageFileName = "Crystal.jpg.png"
                },
                new Product
                {
                    id = 10,
                    Artist = "Khumalo",
                    ProdName = "Elephant",
                    CatId = 3,
                    Price = 550,
                    Availability = "Available",
                    Quantity = 8,
                    Description = "A majestic elephant sculpture, crafted with lifelike detail and grace, capturing the essence of these gentle giants in a stunning work of art.",
                    ImageFileName = "Elephant.jpg.png"
                },
                new Product
                {
                    id = 11,
                    Artist = "Khumalo",
                    ProdName = "African Doll",
                    CatId = 3,
                    Price = 610,
                    Availability = "Available",
                    Quantity = 12,
                    Description = "An African doll, beautifully handcrafted with vibrant fabrics and intricate beadwork, representing the rich cultural heritage and artistic traditions of the continent.",
                    ImageFileName = "AfricanDoll.jpg.png"
                },
                new Product
                {
                    id = 12,
                    Artist = "Khumalo",
                    ProdName = "Human",
                    CatId = 3,
                    Price = 34010,
                    Availability = "Available",
                    Quantity = 2,
                    Description = "A human sculpture serving as furniture, blending artistry with functionality seamlessly.",
                    ImageFileName = "Human.jpg.png"
                },
                new Product
                {
                    id = 13,
                    Artist = "Serenity Maker",
                    ProdName = "Serenity Bowl",
                    CatId = 4,
                    Price = 670,
                    Availability = "Available",
                    Quantity = 21,
                    Description = "A delicate ceramic bowl with a serene blue glaze, reminiscent of tranquil ocean waters. Its smooth curves and gentle ripples evoke a sense of calm and relaxation.",
                    ImageFileName = "SerenityBowl.jpg.png"
                },
                new Product
                {
                    id = 14,
                    Artist = "Khumalo",
                    ProdName = "Ember Mug",
                    CatId = 4,
                    Price = 310,
                    Availability = "Available",
                    Quantity = 12,
                    Description = "A rustic ceramic mug with a rich, earthy glaze reminiscent of glowing embers. Its sturdy handle and textured surface provide a cozy and comforting feel, perfect for enjoying a warm beverage on a chilly evening.",
                    ImageFileName = "EmberMug.jpg.png"
                },
                new Product
                {
                    id = 15,
                    Artist = "Whisper Maker",
                    ProdName = "Whisper Vase",
                    CatId = 4,
                    Price = 200,
                    Availability = "Available",
                    Quantity = 4,
                    Description = "A slender ceramic vase with a soft, matte finish, exuding elegance and understated beauty. Its graceful silhouette and muted tones create a sense of tranquility, making it ideal for showcasing delicate blooms.",
                    ImageFileName = "WhisperVase.jpg.png"
                },
                new Product
                {
                    id = 16,
                    Artist = "Owami",
                    ProdName = "Echo Teapot",
                    CatId = 4,
                    Price = 450,
                    Availability = "Available",
                    Quantity = 8,
                    Description = "A charming ceramic teapot adorned with intricate floral motifs, echoing the beauty of nature. Its generous size and graceful spout make it both functional and decorative, adding a touch of whimsy to tea time.",
                    ImageFileName = "EchoTeapot.jpg.png"
                }
            );

            modelBuilder.Entity<ArtWork>().HasData(
                new ArtWork
                {
                    Id = 1,
                    Artist = "Khumalo",
                    ProdName = "Piccasso",
                    Type = "Painting",
                    Price = 250000,
                    Availability = "Available",
                    Quantity = 1,
                    Description = "A vibrant abstract painting featuring bold, overlapping geometric shapes and vivid colors. The dynamic composition and contrasting hues create a sense of movement and depth, evoking strong emotions and inviting viewers to interpret the scene in their own unique way.",
                    ImageFileName = "Piccasso.jpg.png"
                },
                new ArtWork
                {
                    Id = 2,
                    Artist = "Van Gogh",
                    ProdName = "Starring Night",
                    Type = "Painting",
                    Price = 55502,
                    Availability = "Available",
                    Quantity = 1,
                    Description = "A serene landscape painting depicting a tranquil sunset over a calm lake. Soft, warm hues blend seamlessly in the sky, reflecting beautifully on the water’s surface. Silhouetted trees along the shore add depth and balance to the peaceful scene.",
                    ImageFileName = "StarringNight.jpg.png"
                },
                new ArtWork
                {
                    Id = 3,
                    Artist = "Monet",
                    ProdName = "Lumiere",
                    Type = "Painting",
                    Price = 6500,
                    Availability = "Available",
                    Quantity = 3,
                    Description = "Fine work of art from France",
                    ImageFileName = "Lumiere.jpg.png"
                },
                new ArtWork
                {
                    Id = 4,
                    Artist = "Khumalo",
                    ProdName = "Amandla",
                    Type = "Painting",
                    Price = 5302,
                    Availability = "Available",
                    Quantity = 3,
                    Description = "A powerful painting capturing the essence of African struggle, with strong, expressive figures set against a stark, tumultuous backdrop. Earthy tones and bold strokes convey resilience and determination, while symbolic elements highlight the rich cultural heritage and enduring spirit of the people.",
                    ImageFileName = "Amandla.jpg.png"
                },
                new ArtWork
                {
                    Id = 5,
                    Artist = "Smith",
                    ProdName = "Sky",
                    Type = "Photos",
                    Price = 345,
                    Availability = "Available",
                    Quantity = 8,
                    Description = "A breathtaking photo of the Swiss Alps, showcasing majestic snow-capped peaks under a clear blue sky. Lush green valleys and sparkling alpine lakes contrast beautifully with the rugged mountain terrain, creating a stunning and serene natural landscape.",
                    ImageFileName = "Sky.jpg.png"
                },
                new ArtWork
                {
                    Id = 6,
                    Artist = "John",
                    ProdName = "Kasi",
                    Type = "Photos",
                    Price = 100,
                    Availability = "Available",
                    Quantity = 10,
                    Description = "A compelling photo of a South African township, capturing vibrant, colorful homes packed closely together. The lively streets are filled with activity, reflecting the resilience and community spirit of the residents. In the background, sprawling urban landscapes contrast with the nearby natural beauty.",
                    ImageFileName = "Kasi.jpg.png"
                },
                new ArtWork
                {
                    Id = 7,
                    Artist = "Morris",
                    ProdName = "Polar Bear",
                    Type = "Photos",
                    Price = 250,
                    Availability = "Available",
                    Quantity = 8,
                    Description = "A magnificent polar bear, standing tall against a backdrop of pristine Arctic ice. Its thick, white fur glistens in the sunlight, blending seamlessly with the icy surroundings. With powerful limbs and sharp claws, it exudes strength and grace, a true master of its frozen domain.",
                    ImageFileName = "PolarBear.jpg.png"
                },
                new ArtWork
                {
                    Id = 8,
                    Artist = "Dory",
                    ProdName = "Coral Reef",
                    Type = "Photos",
                    Price = 2345,
                    Availability = "Available",
                    Quantity = 5,
                    Description = "A colorful coral reef alive with marine creatures, swaying gently in the clear turquoise waters.",
                    ImageFileName = "CoralReef.jpg.png"
                },
                new ArtWork
                {
                    Id = 9,
                    Artist = "Khumalo",
                    ProdName = "Crystal",
                    Type = "Sculpture",
                    Price = 2010,
                    Availability = "Available",
                    Quantity = 4,
                    Description = "A dazzling crystal sculpture, intricately crafted to capture and reflect light with stunning precision.",
                    ImageFileName = "Crystal.jpg.png"
                },
                new ArtWork
                {
                    Id = 10,
                    Artist = "Khumalo",
                    ProdName = "Elephant",
                    Type = "Sculpture",
                    Price = 550,
                    Availability = "Available",
                    Quantity = 8,
                    Description = "A majestic elephant sculpture, crafted with lifelike detail and grace, capturing the essence of these gentle giants in a stunning work of art.",
                    ImageFileName = "Elephant.jpg.png"
                },
                new ArtWork
                {
                    Id = 11,
                    Artist = "Khumalo",
                    ProdName = "African Doll",
                    Type = "Sculpture",
                    Price = 610,
                    Availability = "Available",
                    Quantity = 12,
                    Description = "An African doll, beautifully handcrafted with vibrant fabrics and intricate beadwork, representing the rich cultural heritage and artistic traditions of the continent.",
                    ImageFileName = "/images/AfricanDoll.jpg.png"
                },
                new ArtWork
                {
                    Id = 12,
                    Artist = "Khumalo",
                    ProdName = "Human",
                    Type = "Sculpture",
                    Price = 34010,
                    Availability = "Available",
                    Quantity = 2,
                    Description = "A human sculpture serving as furniture, blending artistry with functionality seamlessly.",
                    ImageFileName = "Human.jpg.png"
                },
                new ArtWork
                {
                    Id = 13,
                    Artist = "Serenity Maker",
                    ProdName = "Serenity Bowl",
                    Type = "Ceramics",
                    Price = 670,
                    Availability = "Available",
                    Quantity = 21,
                    Description = "A delicate ceramic bowl with a serene blue glaze, reminiscent of tranquil ocean waters. Its smooth curves and gentle ripples evoke a sense of calm and relaxation.",
                    ImageFileName = "SerenityBowl.jpg.png"
                },
                new ArtWork
                {
                    Id = 14,
                    Artist = "Khumalo",
                    ProdName = "Ember Mug",
                    Type = "Ceramics",
                    Price = 310,
                    Availability = "Available",
                    Quantity = 12,
                    Description = "A rustic ceramic mug with a rich, earthy glaze reminiscent of glowing embers. Its sturdy handle and textured surface provide a cozy and comforting feel, perfect for enjoying a warm beverage on a chilly evening.",
                    ImageFileName = "EmberMug.jpg.png"
                },
                new ArtWork
                {
                    Id = 15,
                    Artist = "Whisper Maker",
                    ProdName = "Whisper Vase",
                    Type = "Ceramics",
                    Price = 200,
                    Availability = "Available",
                    Quantity = 4,
                    Description = "A slender ceramic vase with a soft, matte finish, exuding elegance and understated beauty. Its graceful silhouette and muted tones create a sense of tranquility, making it ideal for showcasing delicate blooms.",
                    ImageFileName = "WhisperVase.jpg.png"
                },
                new ArtWork
                {
                    Id = 16,
                    Artist = "Owami",
                    ProdName = "Echo Teapot",
                    Type = "Ceramics",
                    Price = 450,
                    Availability = "Available",
                    Quantity = 8,
                    Description = "A charming ceramic teapot adorned with intricate floral motifs, echoing the beauty of nature. Its generous size and graceful spout make it both functional and decorative, adding a touch of whimsy to tea time.",
                    ImageFileName = "EchoTeapot.jpg.png"
                }
            );
        }
    }
}

//Reference List:
//Microsoft.[n.d]. Role-based authorization in ASP.NET Core, [n.d]. [Online]. Available at: Role-based authorization in ASP.NET Core | Microsoft Learn
// [Accessed 07 May 2024].

//Microsoft.[n.d]. Sopping Cart [n.d]. [Online]. Available at: Shopping Cart | Microsoft Learn
// [Accessed 20 May 2024].

//Asp .net core | Role based authorization in asp.net core mvc 7. 2023. YouTube video added by Ravindra Devrani. [Online]. Available at: https://youtu.be/xhCstGA9WVI?si=vDmAAibZi9YTWLYN [Accessed 22 May 2024].

//ASP.NET Core MVC Tutorial – Build a Website Shopping cart. 2023. YouTube video added by Evan Gudmestad. [Online]. Available at: https://youtu.be/PwQyRQuEor0?si=3et8vPiidJnFwz9-  [Accessed 23 May 2024].

//W3Schhols. [n.d.]. HTML, [n.d.]. [Online]. Available at: HTML Tutorial (w3schools.com) [Accessed 243May 2024].

//ASP.NET Core MVC Tutorial – Build a Shop with Admin Area. 2023. YouTube video added by Evan Gudmestad. [Online]. Available at: https://youtu.be/T9d90fcYJvM?si=9ZJeS_qDzq8UlW_o  [Accessed 25 May 2024].

//Shopping Cart project in .net core mvc (with authentication). 2023. YouTube video added by Ravindra Devrani. [Online]. Available at: https://youtu.be/JPFlSXejgKc?si=VXSsHSydovhZY3TA  [Accessed 22 May 2024].
//Microsoft.[n.d]. Role-based authorization in ASP.NET Core, [n.d]. [Online]. Available at: Role-based authorization in ASP.NET Core | Microsoft Learn
// [Accessed 07 May 2024].

//Microsoft.[n.d]. Sopping Cart [n.d]. [Online]. Available at: Shopping Cart | Microsoft Learn
// [Accessed 20 May 2024].

//Asp .net core | Role based authorization in asp.net core mvc 7. 2023. YouTube video added by Ravindra Devrani. [Online]. Available at: https://youtu.be/xhCstGA9WVI?si=vDmAAibZi9YTWLYN [Accessed 22 May 2024].

//ASP.NET Core MVC Tutorial – Build a Website Shopping cart. 2023. YouTube video added by Evan Gudmestad. [Online]. Available at: https://youtu.be/PwQyRQuEor0?si=3et8vPiidJnFwz9-  [Accessed 23 May 2024].

//W3Schhols. [n.d.]. HTML, [n.d.]. [Online]. Available at: HTML Tutorial (w3schools.com) [Accessed 243May 2024].

//ASP.NET Core MVC Tutorial – Build a Shop with Admin Area. 2023. YouTube video added by Evan Gudmestad. [Online]. Available at: https://youtu.be/T9d90fcYJvM?si=9ZJeS_qDzq8UlW_o  [Accessed 25 May 2024].

//Shopping Cart project in .net core mvc (with authentication). 2023. YouTube video added by Ravindra Devrani. [Online]. Available at: https://youtu.be/JPFlSXejgKc?si=VXSsHSydovhZY3TA  [Accessed 22 May 2024].