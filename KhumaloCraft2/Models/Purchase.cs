namespace KhumaloCraft2.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int ArtWorkId { get; set; }

        public ArtWork ArtWork { get; set; }

        public int Quantity { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public decimal? Total {  get; set; }
    }
}
