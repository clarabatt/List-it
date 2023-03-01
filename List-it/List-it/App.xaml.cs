using System;
using Listit.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace List_it
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new ListPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

