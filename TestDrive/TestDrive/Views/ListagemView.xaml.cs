using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Veiculos = new List<Veiculo>
            {
                new Veiculo{Nome = "Azera  V6", Preco = 60000},
                new Veiculo{Nome = "Fiesta 2.0", Preco = 50000},
                new Veiculo{Nome = "HB20 S", Preco = 40000}
            };

            BindingContext = this;
        }

        private async void OnSelecionarVeiculo(object sender, ItemTappedEventArgs e)
        {
            var veiculoSelecionado = (Veiculo) e.Item;

            var paginaDetalhesView = new DetalhesView(veiculoSelecionado);
            await Navigation.PushAsync(paginaDetalhesView);
        }
    }

    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado { get { return $"R$ {Preco:#,##0.00}"; } }
    }
}
