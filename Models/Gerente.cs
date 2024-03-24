using HotelCharp.Interfaces;

namespace HotelCharp.Models
{
    public class Gerente : Pessoa, IGerente, ICamareira
    {
         public Gerente() : base()
        {
        }

        public Gerente(string nome, string cpf, string telefone) 
        : base(nome, cpf, telefone)
        {
        }

        public override void SeApresentar()
        {
           Console.WriteLine("Sou o gerente " + Nome);
        }
          public void ConhecerBemHotel()
        { 
            Console.WriteLine("Sou gerente e conheço muito bem o hotel");
        }
        public void ArrumarCama()
        {
            Console.WriteLine("Sou o gerente e sei arrumar a cama.");
        }
        public void FalarIngles()
        { 
            Console.WriteLine("Sou gerente e domino o inglês");
        }

        public void LimparQuarto()
        {
            Console.WriteLine("Sei arrumar muito bem o quarto");
        }

        public void AtenderTelefone()
        {
            Console.WriteLine("Sei atender o telefone");
        }
    }
}