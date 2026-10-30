using Catalog;
using Basket;
using Ordering;

var builder = WebApplication.CreateBuilder(args);
// add services to the container
builder.Services.AddControllers();

// add services for modules
builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

var app = builder.Build();

// pipeline 
app.Run();
