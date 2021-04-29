using System;
public class Calculator
{
	public double a;
        public double b;

        public void AddSub()
        {
            Console.WriteLine("Enter a number, a=" +a);
           
            Console.WriteLine("Enter another number, b=" +b);
            
            

        }
	public static Tuple<double,double> AddSub(double a, double b)
	{
	return new  Tuple<double , double>((a + b),(a - b));
	}
	public static void Main()
	{
		Tuple<double, double> output = Calculator.AddSub(3.7, 4.2);
		Console.WriteLine("Sum = "+output.Item1+"Subtraction values= "+output.Item2);
		 Calculator obj = new Calculator();
            //int exitkey = 1;
           for(; ; )
            {
                Console.WriteLine("You want to exit ? Y/N");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "n")
                {
                    obj.AddSub();
                    choice = Console.ReadLine();
                }
                else
                {
                    break;
                }
			   Console.ReadLine();
            }
           
        }
    }