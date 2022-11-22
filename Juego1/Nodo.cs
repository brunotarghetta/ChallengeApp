using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Juego1
{
    public class Nodo
    {
        public (int, int) Padre { get; set; }

        public (int, int) Ubicacion { get; set; }

        public string PuntoCardinal { get; set; }

        public string Ruta { get; set; }

        public string Valor { get; set; }

        public List<Nodo> Hijos { get; set; }
    }
}
