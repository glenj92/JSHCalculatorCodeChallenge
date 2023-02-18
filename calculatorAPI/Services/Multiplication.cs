using System;
using calculatorAPI.Interfaces;

namespace calculatorAPI.Services
{
	public class Multiplication : ICreateOperation
    {
        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
}

