using System;
using System.Threading.Tasks;
using MiCarnet.Models;

namespace MiCarnet.Services
{
    public class ApiManager
    {
        IApiServices apiServices;

        public ApiManager(IApiServices service)
        {
            apiServices = service;

        }

        public async Task<Vacuna.Root> ObtenerVacuna(DateDNI dateDNI)
        {
            return await apiServices.ObtenerVacunas( dateDNI);
        }
    }
}
