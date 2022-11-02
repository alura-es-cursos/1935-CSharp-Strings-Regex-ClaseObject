// See https://aka.ms/new-console-template for more information

using SistemaAgencia;
using System.Reflection.Metadata;

try
{
    string url = "https://www.bytebank.com?monedaOrigen=Pesos&monedaDestino=Dolares&cantidad=1000";

    string argumentos = url.Substring(url.IndexOf('?') + 1);
    string parametro = "monedaDestino";

    Console.WriteLine(argumentos);
    int posicionParametro = argumentos.IndexOf(parametro)+parametro.Length+1;

    Console.WriteLine(posicionParametro);
    Console.ReadLine();
} catch(ArgumentNullException e)
{
    Console.WriteLine("La url no puede ser nula");
} catch(ArgumentException e)
{
    Console.WriteLine(e.Message);
}

