
using Api_Login.Interfaces;
using Api_Login.Servicios;

namespace Api_Login
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
            builder.Services.AddScoped<IRegistrarUsuario, RegistrarUsuarioService>();
            builder.Services.AddScoped<IGetUsuarios, GetUsuariosSevice>();
            builder.Services.AddScoped<IValidarLogin, ValidarLoginService>();
            builder.Services.AddScoped<IContacto, AddContactoService>();
            builder.Services.AddScoped<IEditarContacto, EditarContactoService>();
            builder.Services.AddScoped<IEliminarContacto, EliminarContactoServices>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
