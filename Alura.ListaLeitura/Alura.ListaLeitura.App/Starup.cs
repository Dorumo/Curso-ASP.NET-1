using Alura.ListaLeitura.App.Logica;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public static void Configure(IApplicationBuilder app)
        {
            var routeBuilder = new RouteBuilder(app);
            routeBuilder.MapRoute("Livros/ParaLer", LivrosLogica.LivrosParaLer);
            routeBuilder.MapRoute("Livros/Lendo", LivrosLogica.LivrosLendo);
            routeBuilder.MapRoute("Livros/Lidos", LivrosLogica.LivrosLidos);
            routeBuilder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", CadastroLogica.NovoLivroParaLer);
            routeBuilder.MapRoute("Livros/Detalhes/{id:int}", LivrosLogica.ExibeDetalhes);
            routeBuilder.MapRoute("Cadastro/NovoLivro", CadastroLogica.ExibeFormulario);
            routeBuilder.MapRoute("Cadastro/Incluir", CadastroLogica.ProcessaFormulario);
            var rotas = routeBuilder.Build();

            app.UseRouter(rotas);

        }
    }
}
