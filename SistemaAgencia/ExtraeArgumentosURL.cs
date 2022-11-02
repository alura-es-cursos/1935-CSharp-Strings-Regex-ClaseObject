using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgencia
{
    public class ExtraeArgumentosURL
    {
        public string _url { get; }
        public ExtraeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("El url no puede estar vacío o no puede ser nulo");
            }
            
            _url = url;

        }

        // monedaOrigen=Pesos&monedaDestino=Dolares&cantidad=1000
        public string getValor(string parametro)
        {
            string argumentos = _url.Substring(_url.IndexOf('?') + 1);
            
            string argumentosEnMayuscula = argumentos.ToUpper();
            parametro = parametro + "=";
            parametro = parametro.ToUpper();
            
            //Obtenemos la posición del valor del argumento
            int posicionParametro = argumentosEnMayuscula.IndexOf(parametro) + parametro.Length;
            string valor = argumentos.Substring(posicionParametro);
            int posicionSeparador = valor.IndexOf('&');

            if (posicionSeparador >= 0)
                return valor.Remove(posicionSeparador);
            return valor;
        }
    }
}
