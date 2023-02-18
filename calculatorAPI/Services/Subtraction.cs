using System;
using calculatorAPI.Interfaces;

namespace calculatorAPI.Services
{
	public class Subtraction : ICreateOperation
    {
        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
}

