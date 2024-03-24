using HotelCharp.Interfaces;

namespace HotelCharp.Models
{
    public class Hotel
    {
        public string Nome {get;set;}
         public Endereco Endereco{get;set;}
         public List<Recepcionista> Recepcionistas {get;private set;}
         public List<Camareira> Camareiras{get;private set;}
         public IGerente Gerente{get;private set;}

        public Hotel (String nome)
        {
            Nome = nome;
            Recepcionistas = new List<Recepcionista>();
            Camareiras = new List<Camareira>();
        }

        public Hotel (String nome, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Recepcionistas = new List<Recepcionista>();
            Camareiras = new List<Camareira>();
        }
        public void ContratarGerente(Gerente gerente)
        {
            Gerente = gerente;
        }
        public void ContratarCamareira(Camareira camareira)
        { 

            Camareiras.Add(camareira);
            
        }
        public void ContratarRecepcionista(Recepcionista recepcionista)
        {
            Recepcionistas.Add(recepcionista);
        }


    }
}