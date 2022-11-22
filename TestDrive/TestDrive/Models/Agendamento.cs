using System;

namespace TestDrive.Models
{
    public class Agendamento
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public DateTime DataAgendamento { get; set; }
        public TimeSpan HoraAgendamento { get; set; }

        public Veiculo Veiculo { get; set; }


        public Agendamento()
        {
            DataAgendamento = DateTime.Today;
        }

        public Agendamento(Veiculo veiculo) : this()
        {
            Veiculo = veiculo;
        }
    }
}
