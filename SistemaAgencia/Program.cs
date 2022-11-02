// See https://aka.ms/new-console-template for more information

using SistemaAgencia;
using System.Reflection.Metadata;

try
{
    //El usuario tiene el telefono 1234-42545
    //Ahora este usuario cambió su telefono para 5436 22455
    //Y para finalizar el usuario tiene otro telefono que es 23232323232

    string url = "https://www.bytebank.com?monedaOrigen=Pesos&monedaDestino=Dolares&cantidad=1500";

    Console.WriteLine(url.StartsWith("https://www.bytebank.com"));
    Console.WriteLine(url.EndsWith("1500"));
    Console.WriteLine(url.Contains("Pesos"));
    /*

    ExtraeArgumentosURL extractor = new ExtraeArgumentosURL(url);

    Console.WriteLine("MonedaOrigen:"+extractor.getValor("MonedaOrigen"));
    Console.WriteLine("MonedaDESTINO:"+extractor.getValor("MonedaDESTINO"));
    Console.WriteLine("CANTIDAD:"+extractor.getValor("CanTIDAD"));
   
    */
    Console.ReadLine();
} catch(ArgumentNullException e)
{
    Console.WriteLine("La url no puede ser nula");
} catch(ArgumentException e)
{
    Console.WriteLine(e.Message);
}

