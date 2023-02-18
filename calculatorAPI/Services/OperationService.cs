
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing.Matching;


namespace calculatorAPI.Services
{
	internal class OperationService  
    {
        private readonly ICreateOperation _createOperation;

        public OperationService(ICreateOperation createOperation)
        {
            _createOperation = createOperation;
        }

        public double GenerateOperation(double a, double b)
        {
           return _createOperation.Calculate(a,b);
        }

    }
}

