namespace Cosmetics.Contracts
{
    using System.Collections.Generic;

    public interface IToothpaste : IProduct
    {
        ICollection<string> Ingredients { get; }
    }
}