using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleDemo
{
    public class HandleException
    {
        public void Display()
        {
            try
            {
                //COde to try block goes here
                //put a statement where we want to rise exception
                int[] array = { 1, 2, 3 };
                for (int val = 0; val < array.Length; val++)
                {
                    Console.WriteLine(array[val]);
                }
                Console.WriteLine(array[10]);
            }
            catch(Exception ex)//some specific exception
            {
                //statement to hanlde the exception goes here
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //statment to execute after try and possibily catch block
                //clean up code
            }
           
        }
    }
}

