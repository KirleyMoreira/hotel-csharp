using System.Net.Http.Headers;
using HotelCharp.Interfaces;

namespace HotelCharp.Models
{
    public class HR : IRHTerceirizado
    {
     public string Nome{get;set;}  
     public Hotel Hotel{get;set;} 

     public HR(string nome, Hotel hotel)
     {
        Nome = nome;
        Hotel = hotel;
     }

        public void ContratarCamareira(ICamareira camareira)
        {
            throw new NotImplementedException();
        }

        public void ContratarRecepcionista(IRecepcionista recepcionista)
        {
            throw new NotImplementedException();
        }

        public void PromoverGerente(Camareira camareira)
        {
            throw new NotImplementedException();
        }

        public void PromoverGerente(Recepcionista recepcionista)
        {
            throw new NotImplementedException();
        }
    }   
}
