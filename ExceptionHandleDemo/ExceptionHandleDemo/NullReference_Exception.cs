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
            //List<Exception> exceptions = new List<Exception>();
            //foreach(var e in exceptions)
            //{
            //    Console.WriteLine(e);
            //}
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
