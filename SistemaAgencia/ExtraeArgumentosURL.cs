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
        public string getValor(string argumentos, string parametro)
        {
            int posicionParametro = argumentos.IndexOf(parametro);

            return "";
        }
    }
}
