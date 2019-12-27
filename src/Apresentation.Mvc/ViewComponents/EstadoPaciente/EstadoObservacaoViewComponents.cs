using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Apresentation.Mvc.ViewComponents.EstadoPaciente
{
    [ViewComponent(Name = "EstadoObservacao")]
    public class EstadoObservacaoViewComponents : ViewComponent
    {
        public EstadoObservacaoViewComponents()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
