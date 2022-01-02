using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public string ImgPhoto { get; set; }
        public string Status { get; set; }
        [ForeignKey("size")]
        public int SizeId { get; set; }
        [ForeignKey("color")]
        public int ColorId { get; set; }
        public AttributeValue Size { get; set; }
        public AttributeValue Color { get; set; }
        [ForeignKey("brand")]
        public int Brand_Id { get; set; }
        public Brand brand { get; set; }
        [ForeignKey("category")]
        public int Category_Id { get; set; }
        public Category category { get; set; }

        [ForeignKey("store")]
        public int Store_Id { get; set; }
        public Store store { get; set; }
        public List<Order> orders { get; set; }
        [NotMapped]
        public IFormFile filePath { get; set; }




    }
}
