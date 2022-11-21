using System.Collections.Generic;
using TestDrive.Models;
using Xamarin.Forms;

namespace TestDrive.Views
{
    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListagemView()
        {            
            InitializeComponent();

            ExibirVeiculos();
        }

        private void ExibirVeiculos()
        {
            Veiculos = new ListagemVeiculos().Veiculos;
            BindingContext = this;
        }

        private async void OnSelecionarVeiculo(object sender, ItemTappedEventArgs e)
        {
            var veiculoSelecionado = (Veiculo) e.Item;

            var paginaDetalhesView = new DetalhesView(veiculoSelecionado);
            await Navigation.PushAsync(paginaDetalhesView);
        }
    }    
}
