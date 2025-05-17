using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft2.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        public string? ProdName { get; set; }

        [Required(ErrorMessage = "Artist name is required")]
        public string? Artist { get; set; }


        [Required(ErrorMessage = "Availability is required")]
        public string? Availability { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }

        [ForeignKey("CatId")]
        public Category? Category { get; set; }
        public int CatId { get; set; }
        public string? ImageFileName { get; set; }
        public int Quantity { get; set; }
        public string? Details { get; set; }


        //Slug read only
        public string Slug => $"{Category}-{ProdName}-{Price}".ToLower().Replace("-", "-");
    }
}
