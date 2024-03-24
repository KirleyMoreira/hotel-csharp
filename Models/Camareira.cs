using HotelCharp.Interfaces;

namespace HotelCharp.Models
{
    public class Camareira : Pessoa, ICamareira
    {
        public Camareira() : base()
        {
        }

        public Camareira(string nome, string cpf, string telefone) 
        : base(nome, cpf, telefone)
        {
        }

        public void ArrumarCama()
        {
           Console.WriteLine("Sei arrumar a cama. ");
           Console.WriteLine();
        }

        public void LimparQuarto()
        {
            Console.WriteLine("Sei limpar o quarto. ");
           Console.WriteLine();
        }

        public override void SeApresentar()
        {
           Console.WriteLine("Olá, sou a  " + Nome + " e sou camareira. ");
           Console.WriteLine();
        }
    }
}