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
    }
}