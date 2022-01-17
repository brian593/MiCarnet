using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Lottie.Forms;

namespace MiCarnet.Pages
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

        }
    }
}
