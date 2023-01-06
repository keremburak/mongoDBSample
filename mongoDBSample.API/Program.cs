using mongoDBSample.Core.Abstract;
using mongoDBSample.Core.Concrete;
using mongoDBSample.Service.Abstract;
using mongoDBSample.Service.Concrete;
using Utilities.Extensions;


namespace mongoDBSample.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddMongoDbSettings(builder.Configuration);

            //builder.Services.AddSingleton(typeof(IRepository<>), typeof(MongoDbRepositoryBase<>));
            builder.Services.AddSingleton<ICategoryService, CategoryService>();
            builder.Services.AddSingleton<IProductService, ProductService>();

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
        }
    }
}