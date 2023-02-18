using calculatorAPI.Controllers;
using calculatorAPI.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<IOperation, Operation>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.MapPost("/api/sum", (double n1, double n2, IOperation operation) => Sum(n1, n2, operation));
    //app.MapPost("/subtract", (double n1, double n2, IOperation operation) => Subtract(n1, n2, operation));
    //app.MapPost("/multiply", (double n1, double n2, IOperation operation) => Multiply(n1, n2, operation));
    //app.MapPost("/divide", (double n1, double n2, IOperation operation) => Divide(n1, n2, operation));

    //double Sum(double n1, double n2, IOperation operation)
    //{
    //    var sum = operation.Sum(n1, n2);
    //    return sum;
    //}
    //double Subtract(double n1, double n2, IOperation operation)
    //{
    //    var sum = operation.Subtract(n1, n2);
    //    return sum;
    //}
    //double Multiply(double n1, double n2, IOperation operation)
    //{
    //    var sum = operation.Multiply(n1, n2);
    //    return sum;
    //}
    //double Divide(double n1, double n2, IOperation operation)
    //{
    //    var sum = operation.Divide(n1, n2);
    //    return sum;
    //}

}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

