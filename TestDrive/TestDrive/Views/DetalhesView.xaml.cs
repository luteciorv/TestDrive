using System;
using TestDrive.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesView : ContentPage
    {
        public Veiculo VeiculoSelecionado { get; set; }


        public string RecuperarFreioABS { get { return $"Freio ABS - R$ {VeiculoSelecionado.PrecoFreioABS:#,#00.0}"; } }
        public string RecuperarArCondicionado { get { return $"Freio ABS - R$ {VeiculoSelecionado.PrecoArCondicionado:#,#00.0}"; } }
        public string RecuperarMP3Player { get { return $"Freio ABS - R$ {VeiculoSelecionado.PrecoMP3Player:#,#00.0}"; } }
        

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
            VeiculoSelecionado.PossuiFreioABS = swtFreio.On;
            VeiculoSelecionado.PossuiArCondicionado = swArCondicionado.On;
            VeiculoSelecionado.PossuiMP3Player = swMP3.On;            

            txtValorTotal.Text = $"Valor Total R$ {VeiculoSelecionado.ValorTotal():#,#00.0}";
        }


        private async void OnSelecionarProximo(object sender, EventArgs e)
        {
            var paginaAgendamento = new AgendamentoView(VeiculoSelecionado);
            await Navigation.PushAsync(paginaAgendamento);
        }
    }
}