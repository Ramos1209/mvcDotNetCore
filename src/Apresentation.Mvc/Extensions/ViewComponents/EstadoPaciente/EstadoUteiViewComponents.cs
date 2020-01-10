using Apresentation.Mvc.ViewComponents.Helpers;
using ErpHospitalar.Data.ORM;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Apresentation.Mvc.Extensions.ViewComponents.EstadoPaciente
{
    [ViewComponent(Name ="EstadoUtei")]
    public class EstadoUteiViewComponents:ViewComponent
    {
        private readonly ERPHospitalarContext _context;
        public EstadoUteiViewComponents(ERPHospitalarContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var totalGeral = Utils.TotalRegistro(_context);
            decimal totalEstado = Utils.NumeroRegistro(_context, "UTI");
            decimal progress = totalEstado * 100 / totalGeral;
            var porc = progress.ToString("F1");

            var model = new ContadorEstadoPaciente()
            {
                Titulo = "Estado Utei",
                Partial = (int)totalEstado,
                Percentual = porc,
                ClassContainer = "panel panel-warning tile panelClose panelRefresh",
                IconLarg = "l-basic-life-buoy",
                IconMd = "fa fa-arrow-circle-o-down s20 mr5 pull-left",
                Progress = progress,
            };

            return View(model);
        }
    }
}
