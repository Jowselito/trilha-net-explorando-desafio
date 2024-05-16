using System.Formats.Asn1;
using System.Net.Security;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //Implementado!
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                //Implementado!
                throw new ArgumentException("Número de hóspedes maior que a capacidade da suite.");
            }
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Implementado!
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            //Implementado!
            decimal valor = 0;

            valor = Suite.ValorDiaria * DiasReservados;

            //Implementado!
            if (DiasReservados >= 10)
            {
                valor = valor * 0.9M;
            }

            return valor;
        }
    }
}