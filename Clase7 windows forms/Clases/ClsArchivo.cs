using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7_windows_forms.Clases
{
    class ClsArchivo
    {
        public string[]LeerArchivo(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo);
                return lineas;
        }
        public string LeerTodoArchivo(string archivo)
        {
            string contenidoArchivo;
            using(StreamReader reader = new StreamReader(archivo))
            {
                contenidoArchivo = reader.ReadToEnd();
            }
            return contenidoArchivo;
        }
     
} 
        
    }

