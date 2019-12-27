using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Apresentation.Mvc.ViewComponents.EstadoPaciente
{
    [ViewComponent(Name ="EstadoUtei")]
    public class EstadoUteiViewComponents:ViewComponent
    {
        public EstadoUteiViewComponents()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
