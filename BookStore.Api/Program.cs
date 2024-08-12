using BookStore.Api.Providers.Interfaces;
using BookStore.Api.Providers.Registers;
using BookStore.Pagination.Extensions;
using BookStore.Pagination.Pagination;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IServiceProviderRegister providerRegister = new ServiceProviderRegister();
providerRegister.RegisterProviders(builder);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddPaginator<Paginator>();

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
