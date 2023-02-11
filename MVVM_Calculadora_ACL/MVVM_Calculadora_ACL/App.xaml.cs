using MVVM_Calculadora_ACL.Vista;
using MVVM_Calculadora_ACL.VistaModelo;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Calculadora_ACL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Calculadora());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
