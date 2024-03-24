using HotelCharp.Models;

namespace HotelCharp.Interfaces
{
    public interface IRHTerceirizado
    {
        void ContratarCamareira(ICamareira camareira);
        void ContratarRecepcionista(IRecepcionista recepcionista);
// ele disse para contratar uma camareira e não icamareira ??
        void PromoverGerente(Camareira camareira);
        void PromoverGerente(Recepcionista recepcionista);
    }
}