using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesView : ContentPage
    {
        public Veiculo VeiculoSelecionado { get; set; }
        public DetalhesView(Veiculo veiculo)
        {
            InitializeComponent();

            Title = $"Detalhes - {veiculo.Nome}";
            VeiculoSelecionado = veiculo;
        }

        private async void OnSelecionarProximo(object sender, EventArgs e)
        {
            var paginaAgendamento = new AgendamentoView(VeiculoSelecionado);
            await Navigation.PushAsync(paginaAgendamento);
        }
    }
}