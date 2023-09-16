using System.ComponentModel.DataAnnotations;

namespace BobsBricks.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        
        public int? PieceCount { get; set; }

        public int? MiniFigs { get; set; }

        public string? ImageURL { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
