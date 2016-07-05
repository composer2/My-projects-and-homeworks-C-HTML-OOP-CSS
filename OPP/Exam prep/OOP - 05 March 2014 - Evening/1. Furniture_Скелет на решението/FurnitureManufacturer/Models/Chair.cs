using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Chair : Furniture, IChair
    {
        public int NumberOfLegs { get; protected set; }
    }
}
