using BookListApi.BusinessLayer.Abstract;
using BookListApi.BusinessLayer.Concrete;
using BookListApi.DataAccessLayer.Abstract;
using BookListApi.DataAccessLayer.Context;
using BookListApi.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICategoryService,CategoryManager>();
builder.Services.AddScoped<ICategoryDal,EfCategoryDal>();

builder.Services.AddScoped<IBookService,BookManager>();
builder.Services.AddScoped<IBookDal,EfBookDal>();

builder.Services.AddScoped<IFeatureService,FeatureManager>();
builder.Services.AddScoped<IFeatureDal,EfFeatureDal>();

builder.Services.AddScoped<IWriterService,WriterManager>();
builder.Services.AddScoped<IWriterDal,EfWriterDal>();

builder.Services.AddDbContext<ApiContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
