
using BookingApp.Application.Mappings;
using BookingApp.Domain.Interfaces.Repositories;
using BookingApp.Domain.Interfaces.Services;
using BookingApp.Domain.Services;
using BookingApp.Infra.Data.Repositories;

namespace BookingApp.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //configurando o automapper
            builder.Services.AddAutoMapper(typeof(ProfileMapping));

            //registrar as inje��es de depend�ncia do sistema para a camada de dom�nio
            builder.Services.AddTransient<IBookingDomainService, BookingDomainService>();
            builder.Services.AddTransient<IVehicleDomainService, VehicleDomainService>();
            builder.Services.AddTransient<ICustomerDomainService, CustomerDomainService>();

            //registrar as inje��es de depend�ncia do sistema para a camada de reposit�rio
            builder.Services.AddTransient<IBookingRepository, BookingRepository>();
            builder.Services.AddTransient<IVehicleRepository, VehicleRepository>();
            builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
