using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_abstract_class_ex1
{
    public abstract class AbsClass
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public abstract int mul(int x, int y);
    }

    public class AbsDerived : AbsClass
    {
        public override int mul(int x, int y)
        {
            return x * y;
        }
    }
}
