using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace calculatorAPI.Interfaces;


public interface ICreateOperation
{
    public double Calculate(double a, double b);
}
