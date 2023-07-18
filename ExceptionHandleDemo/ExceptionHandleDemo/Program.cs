using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1- NormalizationForm Exception");
                Console.WriteLine("2- Devided by zero");
                Console.WriteLine("3- Null reference Exception");
                Console.WriteLine("4- Index out of range");
                Console.WriteLine("Choose above option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        HandleException handleException = new HandleException();
                        handleException.Display();
                        break;
                    case 2:
                        DividedByZero dividedByZero = new DividedByZero();
                        dividedByZero.Divided_By_Zero();
                            break;
                        case 3:
                        NullReference_Exception nullReference_Exception = new NullReference_Exception();
                        nullReference_Exception.NullReference();
                        break;
                        case 4:
                        IndexOutOf_Range indexOutOf_Range = new IndexOutOf_Range();
                        indexOutOf_Range.Index_Out_ofRange();
                        break;
                }
            }
            
        }
    }
}
