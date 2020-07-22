using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaerskCodingTestQuestion1
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Sku { get; set; }

        public int Quantity { get; set; }
    }
}
