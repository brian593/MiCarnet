using System;
using MiCarnet.Models;
using Xamarin.Forms;

namespace MiCarnet.PageModels
{
    public class MainPageModel : FreshMvvm.FreshBasePageModel
    {
        public Command GetCosultaCommand { get; set; }
        public MainPageModel()
        {
            GetCosultaCommand = new Command(() =>
            {
                CoreMethods.PushPageModel<ConsultaPageModel>(null, true);
            });

        }  
    }
}
