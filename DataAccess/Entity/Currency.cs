using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entity
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Company> companies { get; set; }
    }
}
