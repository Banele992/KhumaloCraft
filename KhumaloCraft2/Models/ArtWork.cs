using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft2.Models
{
    public class ArtWork
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        public string? ProdName { get; set; }

        [Required(ErrorMessage = "Artist name is required")]
        public string? Artist { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Availability is required")]
        public string? Availability { get; set; }
        [ForeignKey("Category")]
        public int CatID { get; set; }
        public string? ImageFileName { get; set; }
        public int Quantity { get; set; }
        public decimal? Total { get; set; }
        public string? Details { get; set; }
        public String? Type { get; set; }


        //Slug read only
        public string Slug => $"{Type}-{ProdName}-{Price}".ToLower().Replace("-", "-");
    }
}


