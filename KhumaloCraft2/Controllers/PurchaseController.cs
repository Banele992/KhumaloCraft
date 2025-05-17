using KhumaloCraft2.Data;
using KhumaloCraft2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KhumaloCraft2.Controllers
{
    public class Purchase
    {
        public int Id { get; set; }
        public string UserId { get; set; } // Add this line to store the user's ID
        public ApplicationUser User { get; set; } // Add this navigation property
        public DateTime PurchaseDate { get; set; }
        public int ArtWorkId { get; internal set; }
        public int Quantity { get; internal set; }
        public decimal? Total { get; internal set; }
    }


}
