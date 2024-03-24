using HotelCharp.Interfaces;

namespace HotelCharp.Models
{
    public class Recepcionista : Pessoa, IRecepcionista
    {
        public Recepcionista() : base()
        {
        }
        public Recepcionista(string nome, string cpf, string telefone)
        : base(nome, cpf, telefone)
        {
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Prazer, eu sou a " + Nome + "e sou recepcionista.");
            Console.WriteLine();
        }

        public void AtenderTelefone()
        {
            Console.WriteLine("sei atender o telefone ");
        }

        public void FalarIngles()
        {
            Console.WriteLine(" Sei falar inglês ");
        }
    }
}