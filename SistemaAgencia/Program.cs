// See https://aka.ms/new-console-template for more information

using ByteBank.Modelos;
using SistemaAgencia;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

try
{
    //Clase object

    //Console es una clase estática
    //WriteLine es un método estático
    //Parametros de distintos tipos de datos

    Cliente cliente1 = new Cliente("Carlos Docente");
    cliente1.Dni = "8001879";
    cliente1.Profesion = "Docente";

    Cliente cliente2 = new Cliente("Carlos Perez");
    cliente2.Dni = "8001879";
    cliente2.Profesion = "Docente";

    CuentaBancaria cuenta = new CuentaBancaria("121211", "23232");


    if (cliente1.Equals(cuenta))
    {
        Console.WriteLine("Clientes iguales");
    } else
    {
        Console.WriteLine("Clientes u objetos diferentes");
    }



    /*
    Console.WriteLine("hola Mundo");
    Console.WriteLine(100);
    Console.WriteLine(12.32);
    Console.WriteLine(true);

    CuentaBancaria cuenta = new CuentaBancaria("121212", "12332");

    Console.WriteLine(cuenta.ToString());

    Director director = new Director("8001879");

    Console.WriteLine(director);

    Object obj = new object();
    */



    //Parámetro
    /*
    //El usuario tiene el telefono 1234-4254
    // Mi telefono es 4231-9877 y puedo conversar en horas comerciales.
    // Para mayor atención llamar al 5599-7485

    //string patron = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
    //string patron = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
    //string patron = "[0-9]{4}[-][0-9]{4}";
    //string patron = "[0-9]{4,5}[-][0-9]{4}";
    //string patron = "[0-9]{4,5}-{0,1}[0-9]{4}";
    string patron = "[0-9]{4,5}-?[0-9]{4}";

    string cadena = "Mi telefono es 942319877 y puedo conversar en horas comerciales.";

    Regex regex = new Regex(patron);

    Console.WriteLine("Existe el patron?" + regex.IsMatch(cadena));

    Console.WriteLine("El patron es:" + regex.Match(cadena));


    /*
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

