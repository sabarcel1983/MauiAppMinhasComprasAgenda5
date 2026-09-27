using Microsoft.Extensions.DependencyInjection;

namespace MauiAppMinhasComprasAgenda5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new Views.ListaProduto());

        }
    }
}