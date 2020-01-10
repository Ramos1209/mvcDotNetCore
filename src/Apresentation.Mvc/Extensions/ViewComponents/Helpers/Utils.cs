using ErpHospitalar.Data.ORM;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Apresentation.Mvc.ViewComponents.Helpers
{
    public static class Utils
    {
        public static int TotalRegistro(ERPHospitalarContext ctx)
        {
            return (from pac in ctx.Pacientes.AsNoTracking() select pac).Count();
        }

        public static decimal NumeroRegistro(ERPHospitalarContext ctx, string estado)
        {
            return ctx.Pacientes.Include(x => x.EstadoPaciente)
                .AsNoTracking()
                .Count(x => x.EstadoPaciente.Descricao.Contains(estado));
        }
    }
}
