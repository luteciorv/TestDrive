using System;
using TestDrive.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        public Agendamento Agendamento { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();

            Title = $"Agendamento - {veiculo.Nome}";                      

            BindingContext = this;
            
            Agendamento = new Agendamento(veiculo);
        }

        private void OnAgendar(object sender, EventArgs e)
        {            
            DisplayAlert($"Agendamento do veículo {Agendamento.Veiculo.Nome}", $"Nome: {Agendamento.Nome} \nTelefone: {Agendamento.Telefone} \nE-mail: {Agendamento.Email} \n\nData: {Agendamento.DataAgendamento} \nHora: {Agendamento.HoraAgendamento}", "Ok");
        }
    }
}