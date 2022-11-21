using System;
using TestDrive.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }


        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();

            Title = $"Agendamento - {veiculo.Nome}";
            Data = DateTime.Now;            

            BindingContext = this;
        }

        private void OnAgendar(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento", $"Nome: {Nome} \nTelefone: {Telefone} \nE-mail: {Email} \n\nData: {Data} \nHora: {Hora}", "Ok");
        }
    }
}