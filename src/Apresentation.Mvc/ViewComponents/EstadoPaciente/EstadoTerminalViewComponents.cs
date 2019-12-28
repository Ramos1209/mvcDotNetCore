using Apresentation.Mvc.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Apresentation.Mvc.ViewComponents.EstadoPaciente
{
    [ViewComponent(Name = "EstadoTerminal")]
    public class EstadoTerminalViewComponents : ViewComponent
    {

        public EstadoTerminalViewComponents()
        {
                
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var totalGeral = Utils.TotalRegistro();
            decimal totalEstado = Utils.NumeroRegistro();
            decimal progress = totalEstado * 100 / totalGeral;
            var porc = progress.ToString("F1");

            var model = new ContadorEstadoPaciente()
            {
                Titulo = "Estado Terminal",
                Partial = (int)totalEstado,
                Percentual = porc,
                ClassContainer = "panel panel-danger tile panelClose panelRefresh",
                IconLarg = "l-basic-life-buoy",
                IconMd = "fa fa-arrow-circle-o-down s20 mr5 pull-left",
                Progress = progress,
            };

            return View(model);
        }
    }
}
