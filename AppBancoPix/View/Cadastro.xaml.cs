using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoPix.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("AppBancoPix.Imagens.LogoInter.png");
        }

        private void CadastrarButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Login());
        }
    }
}