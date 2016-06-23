using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public interface IComment
    {
        void AddComment(string comment);
        void RemoveComment(string comment);
    }
}
