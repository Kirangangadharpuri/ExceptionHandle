using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleDemo
{
    public class DividedByZero
    {
        public void Divided_By_Zero()
        {
            //It will handle error generated from divided by zero.
            int x = 0;
            try
            {
                int a = 100 / x;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
