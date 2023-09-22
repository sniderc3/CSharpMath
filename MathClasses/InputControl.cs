using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    class InputControl
    {
        //Note this method returns a tuple or (int,int). Go to Microsoft pages for syntax and use.
        public (int,int) GetTwoIntegers()
        {
            Console.WriteLine("Input two integers separated by a comma or x,y");
            string? input = Console.ReadLine();
            if(input == null)
                return (0,0);
            else
            {
                string [] numbers = input.Split(',');
                int x = int.Parse(numbers[0]);
                int y = int.Parse(numbers[1]);
                (int,int)a_tuple = (x,y);
                return a_tuple;
            }

        }

        public (float,float) GetTwoFloats()
        {
            Console.WriteLine("Input two floats separated by a comma or x,y");
            string? input = Console.ReadLine();
            if (input == null)
                return (0, 0);
            else
            {
                string[] numbers = input.Split(',');
                float x = float.Parse(numbers[0]);
                float y = float.Parse(numbers[1]);
                (float, float) a_tuple = (x, y);
                return a_tuple;
            }
        }
    }
}
