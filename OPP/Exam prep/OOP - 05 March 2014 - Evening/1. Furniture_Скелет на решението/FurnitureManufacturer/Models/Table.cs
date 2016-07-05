using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Table : Furniture, ITable
    {
        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        public decimal Length { get; private set; }
        

        public decimal Width { get; private set; }

    }
}
