using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerJunctionMVC.Models
{
    public class Brand //Model For Table Brand
    {
        [Key]
        public int Id { get; set; } //Primary Key For Brand Model
        public string Name { get; set; }
        public ICollection<Product> products { get; set; } //Navigation Conected with Product Model
    }
}
