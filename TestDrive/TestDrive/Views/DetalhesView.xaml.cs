using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public const decimal PrecoFreioABS = 800.00m;
        public const decimal PrecoArCondicionado = 1000.00m;
        public const decimal PrecoMP3Player = 500.00m;


        public string RecuperarFreioABS { get { return $"Freio ABS - R$ {PrecoFreioABS:#,#00.0}"; } }
        public string RecuperarArCondicionado { get { return $"Freio ABS - R$ {PrecoArCondicionado:#,#00.0}"; } }
        public string RecuperarMP3Player { get { return $"Freio ABS - R$ {PrecoMP3Player:#,#00.0}"; } }


        public Veiculo VeiculoSelecionado { get; set; }


        public DetalhesView(Veiculo veiculo)
        {
            InitializeComponent();

            Title = $"Detalhes - {veiculo.Nome}";
            VeiculoSelecionado = veiculo;

            AssociarInformacoesAcessarios();            
        }

        private void AssociarInformacoesAcessarios()
        {
            swtFreio.Text = RecuperarFreioABS;
            swArCondicionado.Text = RecuperarArCondicionado;
            swMP3.Text = RecuperarMP3Player;

            OnSelecionarAjuste(null, null);
        }
       

        private void OnSelecionarAjuste(object sender, ToggledEventArgs e)
        {
            decimal valorTotal = VeiculoSelecionado.Preco;

            valorTotal += swtFreio.On ? PrecoFreioABS : 0;
            valorTotal += swArCondicionado.On ? PrecoArCondicionado : 0;
            valorTotal += swMP3.On ? PrecoMP3Player : 0;

            txtValorTotal.Text = $"Valor Total R$ {valorTotal:#,#00.0}";
        }


        private async void OnSelecionarProximo(object sender, EventArgs e)
        {
            var paginaAgendamento = new AgendamentoView(VeiculoSelecionado);
            await Navigation.PushAsync(paginaAgendamento);
        }
    }
}