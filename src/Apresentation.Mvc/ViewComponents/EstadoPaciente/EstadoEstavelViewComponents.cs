using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Apresentation.Mvc.ViewComponents.EstadoPaciente
{
    [ViewComponent(Name = "EstadoEstavel")]
    public class EstadoEstavelViewComponents : ViewComponent
    {
        public EstadoEstavelViewComponents()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
