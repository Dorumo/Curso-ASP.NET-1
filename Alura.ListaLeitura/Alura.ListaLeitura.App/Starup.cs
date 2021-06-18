using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public static void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();

            //var routeBuilder = new RouteBuilder(app);
            //routeBuilder.MapRoute("{controller}/{action}", RoteamentoPadrao.TratamentoPadrao);

            //routeBuilder.MapRoute("Livros/ParaLer", LivrosLogica.ParaLer);
            //routeBuilder.MapRoute("Livros/Lendo", LivrosLogica.Lendo);
            //routeBuilder.MapRoute("Livros/Lidos", LivrosLogica.Lidos);
            //routeBuilder.MapRoute("Livros/Detalhes/{id:int}", LivrosLogica.Detalhes);
            //routeBuilder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", CadastroLogica.NovoLivro);
            //routeBuilder.MapRoute("Cadastro/ExibeFormulario", CadastroLogica.ExibeFormulario);
            //routeBuilder.MapRoute("Cadastro/Incluir", CadastroLogica.Incluir);
            
            //var rotas = routeBuilder.Build();
        }
    }
}
