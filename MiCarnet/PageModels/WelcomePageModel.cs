using System;
using Xamarin.Forms;

namespace MiCarnet.PageModels
{
    public class WelcomePageModel:FreshMvvm.FreshBasePageModel
    {
        public Command GetStartedCommand { get; set; }

        public WelcomePageModel()
        {
            GetStartedCommand = new Command(() =>
            {
                CoreMethods.PushPageModel<MainPageModel>(null, true);
            });
        }

        
    }
}
