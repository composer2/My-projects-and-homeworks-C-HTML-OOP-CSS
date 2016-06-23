using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_2
{
    internal class Test1 : BaseClass,IInterface
    {

    }

    internal class Test2: BaseClass
    {

    }

    internal class Test3 : BaseClass, IInterface
    {
        public Test3(int param)
        {

        }
    }

    internal interface IInterface
    {

    }

    internal class BaseClass
    {

    }

    internal class GenericConstraints<T>
        where T:BaseClass,IInterface,new()
    {
        public T Method(T param)
        {
            return param;
        }
    }
}
