using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft2.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }
        public string? CatName { get; set; }
    }
}
