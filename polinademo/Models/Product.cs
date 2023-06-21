using System.ComponentModel.DataAnnotations;
namespace polinademo.Models
{
    public class Product
    {
        [Key]
        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductUnitOfMeasurement { get; set; }
        public decimal ProductCost { get; set; }
        public byte ProductMaxDiscountAmount { get; set; }
        public string ProductManufacturer { get; set; }
        public string ProductSupplier { get; set; }
        public string ProductCategory { get; set; }
        public byte ProductDiscountAmount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public string ProductDescription { get; set; }
        public string? ProductPhoto { get; set; }
    }
}
