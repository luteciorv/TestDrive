namespace TestDrive.Models
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado { get { return $"R$ {Preco:#,##0.00}"; } }


        public decimal PrecoFreioABS = 800.00m;
        public decimal PrecoArCondicionado = 1000.00m;
        public decimal PrecoMP3Player = 500.00m;


        public bool PossuiFreioABS { get; set; }
        public bool PossuiArCondicionado { get; set; }
        public bool PossuiMP3Player { get; set; }


        public decimal ValorTotal()
        {
            decimal valorTotal = Preco;

            valorTotal += PossuiFreioABS ? PrecoFreioABS : 0;
            valorTotal += PossuiArCondicionado ? PrecoArCondicionado : 0;
            valorTotal += PossuiMP3Player ? PrecoMP3Player : 0;

            return valorTotal;
        }
    }
}