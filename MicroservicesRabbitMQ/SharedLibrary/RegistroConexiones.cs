using GestionCitas.Infraestructura.Persistencia;
using GestionPersonas.Infraestructura.Persistencia;
using GestionRecetas.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SharedLibrary
{
    public static class RegistroConexiones
    {
        public static void AddApplicationContexts(this IServiceCollection services, IConfiguration configuration)
        {
            // Registrar los diferentes contextos de base de datos
            services.AddDbContext<AplicacionUsuariosDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("UsuariosConnectionString")));

            services.AddDbContext<AplicacionCitasDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CitasConnectionString")));

            services.AddDbContext<AplicacionRecetasDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("RecetasConnectionString")));
        }
    }
}
