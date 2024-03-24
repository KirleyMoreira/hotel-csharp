using HotelCharp.Interfaces;
using HotelCharp.Models;

Console.WriteLine("********************************");
Console.WriteLine("********* Hotel Charp **********");
Console.WriteLine("********************************");
Console.WriteLine();

Camareira Camareira01 = new Camareira("Aria feliz", "12345678920", "81912334455");
Camareira camareira02 = new Camareira("Ilana couto", "541154545", "54545151545");
Camareira camareira03 = new Camareira("sokka nelas", "541154545", "54545151545");


Recepcionista recepcionista1 = new Recepcionista( "Livia", "13345532433", "26411448412");
Recepcionista recepcionista02  = new Recepcionista("Beatriz Andrade", "4451212", "15454545");

Gerente gerente = new Gerente("Carina Luzia", "1552354230", "545403265");
Gerente gerente02 = new Gerente ("ciclano de tal.", "41254621", "2546463251");

//Inauguração do Hotel
Hotel hotel = new Hotel("Hotel CSharp", new Endereco()
{
CEP = "5515155",
Rua = "Rua da Conversão",
Numero = 24,
Bairro = "Singapura",
Cidade = "Jambo",
UF = "PE"
});

//Contratar Camareiras
hotel.ContratarCamareira(camareira02);
hotel.ContratarCamareira(Camareira01);

// contratar Recepcionista 
hotel.ContratarRecepcionista(recepcionista1);
hotel.ContratarRecepcionista(recepcionista02);

//Contratar Gerente
hotel.ContratarGerente(gerente02);

//Contratar Faz tudo
hotel.ContratarCamareira(camareira03);

//Apresentação
hotel.Gerente.SeApresentar();
hotel.Gerente.AtenderTelefone();
hotel.Gerente.FalarIngles();
hotel.Gerente.LimparQuarto();
hotel.Gerente.ArrumarCama();

foreach (var camareira in hotel.Camareiras)
{
    camareira.SeApresentar();
    camareira.ArrumarCama();
    camareira.LimparQuarto();
}

foreach (var recepcionista in hotel.Recepcionistas)
{
    recepcionista.SeApresentar();
    recepcionista.AtenderTelefone();
    recepcionista.FalarIngles();
}

//Contratar Camareira
IRHTerceirizado rh = new HR("Hotel CSharp", hotel);

var camareira04 = new Camareira{
    Nome = "Marina Albur"
};
rh.ContratarCamareira(camareira03);

//Contratar Recepcionista 
var recepcionista03 = new Recepcionista("Cintia Lima", "55451512", "5121515512");
rh.ContratarRecepcionista(recepcionista03);

// Promover Camareira 
var camareiraPromovida = new Camareira{
    Nome = "Katia Costa"
};
rh.PromoverGerente(camareiraPromovida);

// Promover Recepcionista
var recepcionistaPromovida = new Recepcionista{
    Nome = "Amanda Vasconcelos "
};






