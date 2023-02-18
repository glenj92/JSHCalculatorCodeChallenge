using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace calculatorAPI.Services;


public interface ICreateOperation
{
    public double Calculate(double a, double b);
}
