﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Atividade3.ViewModel;

namespace XF.Atividade3.View.Aluno
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        AlunoViewModel vmAluno;

        public MainPage ()
		{
            vmAluno = new AlunoViewModel();
            BindingContext = vmAluno;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            vmAluno = new AlunoViewModel();
            BindingContext = vmAluno;
            base.OnAppearing();
        }

        private void OnNovo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovoAlunoView());
        }

        private void OnAlunoTapped(object sender, ItemTappedEventArgs args)
        {
            var selecionado = args.Item as Model.Aluno;
            DisplayAlert("Aluno selecionado", "Aluno: " + selecionado.Id, "OK");
        }
    }
}