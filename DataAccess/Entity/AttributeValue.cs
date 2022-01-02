using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Entity
{
    [Table("AttributeValues")]
    public class AttributeValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("attribute")]
        public int Attribute_Id { get; set; }
        public Attribute attribute { get; set; }
        [InverseProperty("Color")]
        public List<Product> ListProductColor { get; set; }
        [InverseProperty("Size")]
        public List<Product> ListProductSize { get; set; }

    }
}
