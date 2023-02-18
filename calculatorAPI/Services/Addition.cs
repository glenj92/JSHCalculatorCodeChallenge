using System;
namespace calculatorAPI.Services
{
	internal class Addition : ICreateOperation
	{
		public double Calculate(double a, double b)
        {
			return a + b;
		}
	}
}

