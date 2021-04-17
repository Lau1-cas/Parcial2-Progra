using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7_windows_forms.Clases
{
    class ClSarreglos
    {
        private int[] ArregloTemporal;
        private int[] datos;
        private int i, j, datoTemporal;
        private int tamanoArreglo = 0;

        public int GetTamañoArreglo()
        {
            return datos.Length;
        }
        public ClSarreglos(int[] arreglo)
        {
            datos = arreglo;
            tamanoArreglo = datos.Length; //numero de datos
        }
        /// <summary>
        /// Burbuja
        /// intercambia cada pareja consecutiva no ordenada
        /// </summary>
        /// <returns></returns>
        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;
            for(i=0; i < tamanoArreglo - 1; i++)
            {
                for(j= i+ 1; j < tamanoArreglo; j++)
                {
                    if(ArregloTemporal[i] < ArregloTemporal[i])

                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return ArregloTemporal;


        }

        }
    }

