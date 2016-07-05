using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class AdjustableChair : Chair, IAdjustableChair
    {
        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
