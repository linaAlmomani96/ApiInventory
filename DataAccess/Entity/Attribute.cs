using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Entity
{
    [Table("Attributes")]
    public class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public List<AttributeValue> attributeValues { get; set; }
    }
}
