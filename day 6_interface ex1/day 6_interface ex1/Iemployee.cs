using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_interface_ex1
{
    public interface Iemployee
    {
        public void GetFirstName();
        public void GetLastName();
    }
    public class Employee : Iemployee
    {
        public void GetFirstName()
        {
            Console.WriteLine("Vivek");
        }
        public void GetLastName()
        {
            Console.WriteLine("Kumar");
        }

    }

}
