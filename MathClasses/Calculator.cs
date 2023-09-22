using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    class Calculator
    {

        //NOTE: This class makes heavy use of methods with the same name and different
        //input parameters. This is an excellent example of polymorphism and how 
        //powerful it can be in OOP programs.
        public int AddValues(int x, int y)
        {
            int result = x + y;
            return result;
        }

        public float AddValues(float x, float y)
        {
            float result = x + y;
            return result;
        }

        public string AddValues(string x, string y)
        {
            string result = x + y;
            return result;
        }

        public byte AddValues(byte x, byte y) 
        {
            byte result = (byte)(x + y);
            return result;
        }

        public int SubtractValues(int x, int y)
        {
            int result = x - y;
            return result;
        }

        public float SubtractValues(float x, float y)
        {
            float result = x - y;
            return result;
        }        

        //In this method, a (byte) cast must be used to get a byte result.
        //If not, it tries to return an integer value.
        public byte SubtractValues(byte x, byte y)
        {
            byte result = (byte)(x - y);
            return result;
        }

        public int MultiplyValues(int x, int y)
        {
            int result = x * y;
            return result;
        }

        public float MultiplyValues(float x, float y)
        {
            float result = x * y;
            return result;
        }

        public byte MultiplyValues(byte x, byte y)
        {
            byte result = (byte)(x * y);
            return result;
        }

        //A float cast is used here to avoid an erroneous result.
        //In integers, any result that has a fractional component will be rounded down.
        //For instance, 3/4 is 0.75, but an integer value for this would be 0.
        //Try removing the casts and see the result.
        public float DivideValues(int x, int y)
        {
            float result = (float)x / (float)y;
            return result;
        }

        public float DivideValues(float x, float y)
        {
            float result = x / y;
            return result;
        }

        public float DivideValues(byte x, byte y)
        {
            float result = (float)x / (float)y;
            return result;
        }

        public double DivideValues(double x, double y)
        {
            double result = x / y;
            return result;
        }
    }
}
