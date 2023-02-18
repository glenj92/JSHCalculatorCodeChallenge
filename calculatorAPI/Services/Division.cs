using System;
namespace calculatorAPI.Services
{
	public class Division : ICreateOperation
    {
        public double Calculate(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
            
        }
    }
}

