namespace HotelCharp.Interfaces
{
    public interface IGerente : ICamareira, IRecepcionista
    {
        void ConhecerBemHotel();
    }
}