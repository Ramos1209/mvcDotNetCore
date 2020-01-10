using Apresentation.Mvc.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Apresentation.Mvc.Extensions.ViewComponents.CabecalhoModulo
{
    [ViewComponent(Name = "Cabecalho")]
    public class CabecalhoModuloViewComponents: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string titulo, string subtitulo)
        {
            var model = new Modulo()
            {
                Titulo = titulo,
                Subtitulo = subtitulo
            };
            return View(model);
        }
    }
}
