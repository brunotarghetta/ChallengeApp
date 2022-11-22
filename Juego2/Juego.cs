using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Juego2
{
    public class Juego
    {
        int[] memoryCell;
        int currentPosition = 0;

        public void Jugar()
        {
            string instruccion = Instruccion.GetInstruccion();

            ResolveInstruccion("a");


            foreach (var item in instruccion)
            {

            }
        }

        public void ResolveInstruccion(string instruccion) 
        {
            switch (instruccion)
            {
                //E: move the pointer to the next memory cell. 

                //N: move the pointer to the previous memory cell. 

                //D: increment the value stored in the current memory cell by one, wrapping to 0 after 255.

                //A: decrement the value stored in the current memory cell by one, wrapping to 255 after 0.

                //V: starts / ends a loop. When reaching a V, if a loop is already started and the value stored in the memory cell at current position
                //is not 0 return to the instruction after the V that initialized the loop.

                //a: print the ascii value of the value stored in the current memory cell. 

                case "E":
                    currentPosition++;  
                    break;

                case "N":
                    currentPosition--;
                    break;
                case "D":
                    memoryCell[currentPosition]++;
                    break;
                case "A":
                    if (memoryCell[currentPosition]==0) {
                        memoryCell[currentPosition] = 255;
                    }
                    memoryCell[currentPosition]--;
                    break;
                case "V":
                    break;
                case "a":
                    Console.WriteLine(System.Convert.ToChar(memoryCell[currentPosition]).ToString());
                    break;

                default:
                    break;
            }

        }
    }
}
