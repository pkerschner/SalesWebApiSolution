using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApi.Models {

    public class Order {

        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Description { get; set; }
        public bool Shipped { get; set; }
        [Column(TypeName = "decimal(7,2)")]
        public decimal Total { get; set; }

        public int CustomerId { get; set; } // foreign key
        // virtual instance required for Entity Framework to recognize foreign key
        // virtual means this property is in this class but not in the database
        public virtual Customer Customer { get; set; }
        // allows us to ask Entity Framework to fill in all line items when we read an order
        public virtual IEnumerable<Orderline> Orderlines { get; set; }
        // default constructor
        public Order() { }
    }
}
