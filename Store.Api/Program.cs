using Store.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<CustomerService>();
builder.Services.AddSingleton<EmployeeService>();
builder.Services.AddSingleton<ProductService>();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
