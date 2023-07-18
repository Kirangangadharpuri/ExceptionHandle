using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleDemo
{
    public class IndexOutOf_Range
    {
        public void Index_Out_ofRange()
        {
            try
            {
                List<Exception> exceptions = new List<Exception>();
                Console.WriteLine(exceptions[2]);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
