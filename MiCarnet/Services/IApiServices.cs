using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiCarnet.Models;

namespace MiCarnet.Services
{
    public interface IApiServices
    {
         Task<Vacuna.Root> ObtenerVacunas(DateDNI dateDNI);
    }
}
