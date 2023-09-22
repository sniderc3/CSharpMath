namespace MathClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            float result = 0;
            InputControl control = new InputControl();
            Calculator calculator = new Calculator();

            //Note the use of a tuple here. Go to Microsoft pages on tuples for syntax and use.
            (int,int) x = control.GetTwoIntegers();
            result = calculator.DivideValues(x.Item1, x.Item2);
            Console.WriteLine("The result is: " + result);

            (float,float) y = control.GetTwoFloats();
            result = calculator.DivideValues(y.Item1, y.Item2);
            Console.WriteLine("The result is: " + result);
        }
    }
}