using Acme.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Acme.Api.Controllers;
using Acme.Domain.AggregatesModel.ProductAggregate;
using Acme.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ProductController>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddControllers(
   options =>
         {
            options.SuppressAsyncSuffixInActionNames = false;
         });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductContext>(
   options =>
   {
      options.UseNpgsql(builder.Configuration.GetSection("DbOptions")["PostgresSQL"]);
   }
);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseDeveloperExceptionPage();
   app.UseSwagger();
   app.UseSwaggerUI(c =>
      c.SwaggerEndpoint($"/swagger/v1/swagger.json", "Acme.API V1")
   );

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
