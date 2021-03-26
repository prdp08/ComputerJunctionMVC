using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerJunctionMVC.Models
{
    public class Product //Model For Product
    {
        [Key]
        public int Id { get; set; }//Primary Key For Product Model
        public int BrandID { get; set; } //Primary Key For Product Model
        public string Name { get; set; }
        public Brand Brand { get; set; } // Brand Attribute Which Come from Brand table

        public DateTime DateOut { get; set; }
        // public StaffNames StaffName { get; set; }
    }
}
