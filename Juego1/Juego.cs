using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Juego1
{
    public class Juego
    {
        public string[] map;
        Nodo NodoObjetivo;

        public void Jugar()
        {
            map = Map.CreateMap();
            List<Nodo> listaDeNodos = new List<Nodo>();

            Nodo primerPaso = new Nodo();
            primerPaso.Ubicacion = (1, 1);
            primerPaso.Padre = (1, 0);
            primerPaso.Hijos = ObtenerHijos(primerPaso.Ubicacion, primerPaso.Padre, "E");



            Console.WriteLine("Termino!");
            Console.ReadKey();

        }

        private List<Nodo> ObtenerHijos((int, int) ubicacion, (int, int) padre, string rutaPadre)
        {
            List<Nodo> hijos = new List<Nodo>();
            string valueInPosition;
            Nodo nodo = new Nodo();
            (int, int) tempPath;

            //Arranco arriba a las 12
            if (ubicacion.Item1 > 0)
            {
                tempPath = (ubicacion.Item1 - 1, ubicacion.Item2);
                valueInPosition = ValidarUbicacion(ubicacion, padre, hijos, ref nodo, tempPath, "N", rutaPadre);
            }

            //Arranco derecha a las 3
            if (ubicacion.Item2 < 100)
            {
                tempPath = (ubicacion.Item1, ubicacion.Item2 + 1);
                valueInPosition = ValidarUbicacion(ubicacion, padre, hijos, ref nodo, tempPath, "E", rutaPadre);
            }
            //Arranco abajo a las 6
            if (ubicacion.Item1 < 99)
            {
                tempPath = (ubicacion.Item1 + 1, ubicacion.Item2);
                valueInPosition = ValidarUbicacion(ubicacion, padre, hijos, ref nodo, tempPath, "S", rutaPadre);
            }

            //Arranco izquierda a las 9
            if (ubicacion.Item2 > 0)
            {
                tempPath = (ubicacion.Item1, ubicacion.Item2 - 1);
                valueInPosition = ValidarUbicacion(ubicacion, padre, hijos, ref nodo, tempPath, "W", rutaPadre);
            }

            return hijos;
        }

        private string ValidarUbicacion((int, int) ubicacion, (int, int) padre, List<Nodo> hijos, ref Nodo nodo, (int, int) tempPath, string puntoCardnial, string rutaPadre)
        {
            string valueInPosition = string.Empty;
            if (tempPath != padre)
            {
                valueInPosition = map[tempPath.Item1].Substring(tempPath.Item2, 1);
                if (valueInPosition == "0" || valueInPosition == "X")
                {
                    nodo = ArmarNodo(ubicacion, hijos, valueInPosition, tempPath, puntoCardnial, rutaPadre);

                    if (valueInPosition == "X")
                    {
                        Console.WriteLine("Lo Encontro!!!");
                        NodoObjetivo = nodo;
                    }
                }
            }

            return valueInPosition;
        }

        private Nodo ArmarNodo((int, int) ubicacion, List<Nodo> hijos, string valueInPosition, (int, int) tempPath, string puntoCardinal, string rutaPadre)
        {
            Nodo nodo = new Nodo();
            nodo.Ubicacion = tempPath;
            nodo.Padre = ubicacion;
            nodo.Valor = valueInPosition;
            nodo.PuntoCardinal = puntoCardinal;
            nodo.Ruta = rutaPadre + puntoCardinal;
            nodo.Hijos = ObtenerHijos(nodo.Ubicacion, nodo.Padre, nodo.Ruta);
            hijos.Add(nodo);
            return nodo;
        }

    }


}
