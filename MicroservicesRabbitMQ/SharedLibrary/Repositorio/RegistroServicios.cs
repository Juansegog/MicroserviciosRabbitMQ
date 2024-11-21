using GestionCitas.Application.Bus;
using GestionCitas.Application.Contratos;
using GestionCitas.Infraestructura.BunInfraestructure;
using GestionCitas.Infraestructura.Repositorios;
using GestionPersonas.Application.Contratos;
using GestionPersonas.Infraestructura.Repositorios;
using GestionRecetas.Application.Contratos;
using GestionRecetas.Infraestructura.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace SharedLibrary.Repositorio
{
    public static class RegistroServicios
    {

        public static void AddRepositories(this IServiceCollection services)
        {
            // Registrar repositorios y servicios
            services.AddScoped(typeof(IUsuariosRepositorioGenerico<>), typeof(RepositorioUsuariosGenerico<>));
            services.AddScoped<IPacienteRepositorio, RepositorioPaciente>();
            services.AddScoped<IMedicoRepositorio, RepositorioMedico>();
            services.AddScoped(typeof(ICitasRepositorioGenerico<>), typeof(RepositorioCitasGenerico<>));
            services.AddScoped<ICitaRepositorio, RepositorioCita>();
            services.AddScoped(typeof(IRecetasRepositorioGenerico<>), typeof(RepositorioRecetaGenerico<>));
            services.AddScoped<IRecetaRepositorio, RecetaRepositorio>();
            services.AddScoped<IEventBus, RabbitMQBus>();
        }
    }
}
