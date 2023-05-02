using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleaMarket.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; } = null!;

        [Column(TypeName = "varchar(20)")]
        public int Price { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string SelectMarket { get; set; } = null!;

        [Column(TypeName = "varchar(30)")]
        public int TableNumber { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Category { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Brand { get; set; }

        public DateTime TimeAdded { get; set; } = DateTime.Now;
    }
}
