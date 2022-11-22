using TestDrive.Models;
using Xamarin.Forms;

namespace TestDrive.Views
{
    public partial class ListagemView : ContentPage
    {        
        public ListagemView()
        {            
            InitializeComponent();
        }        

        private async void OnSelecionarVeiculo(object sender, ItemTappedEventArgs e)
        {
            var veiculoSelecionado = (Veiculo) e.Item;

            var paginaDetalhesView = new DetalhesView(veiculoSelecionado);
            await Navigation.PushAsync(paginaDetalhesView);
        }
    }    
}
