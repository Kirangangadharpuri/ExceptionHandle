using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleDemo
{
    public class NullReference_Exception
    {
        public void NullReference()
        {
           
            string str = null;
            if(str!=null)
            {
                Console.WriteLine(str.Substring(5));
            }
            else
            {
                Console.WriteLine("String is null");
            }
           
        }
    }
}
