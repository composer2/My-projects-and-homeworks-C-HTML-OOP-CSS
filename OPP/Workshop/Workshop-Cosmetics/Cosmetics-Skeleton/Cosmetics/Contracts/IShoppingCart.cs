using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Contracts
{
    public interface IShoppingCart
    {
        ICollection<IProduct> ProductsList { get; }

        void AddProducts(IProduct cosmetics);

        void RemoveProducts(IProduct cosmetics);

        void CalculateTotalPrice();
    }
}
