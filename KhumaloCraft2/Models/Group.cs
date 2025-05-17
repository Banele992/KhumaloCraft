using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft2.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string? GroupName { get; set; }
    }
}
