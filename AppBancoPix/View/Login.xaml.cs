﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBancoPix.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoPix.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("AppBancoPix.Imagens.LogoInter.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}