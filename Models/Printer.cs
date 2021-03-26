using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerJunctionMVC.Models
{
    public class Printer //Mode for Printer Table
    {
        public int ID { get; set; } //Primary Key
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
