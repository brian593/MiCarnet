using System;
using MiCarnet.Models;

namespace MiCarnet.PageModels
{
    public class ConsultaPageModel: FreshMvvm.FreshBasePageModel
    {
        Vacuna.Root vacuna = new Vacuna.Root();

        DateDNI dateDNI = new DateDNI()
        {
            fechanacimiento = "1995-03-27",
            identificacion = "2100579735"
        };

        public ConsultaPageModel()
        {
          //  Consultar();
        }
        public async void Consultar()
        {
            vacuna = await App.apiManager.ObtenerVacuna(dateDNI); ;
        }
    }
}
