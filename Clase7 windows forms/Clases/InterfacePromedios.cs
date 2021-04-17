using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7_windows_forms.Clases
{
    interface InterfacePromedios
    {
       
        // retorna el promedio en base a una columna especifica
    
        int promedios_por_parcial(string[,] matriz, int columna_parcial);


        // retorna el promedio de un parcial en especial y una seccion en especial

        int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion);

       
        // saca el promedio general de todos los alumnos por seccion.
        
        int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion);

        // se manda la matriz fuente y retrona una matiz nueva con los alumnos clasificados por seccion
        
        string[,] Clasificar_Alumnos(string[,] matriz, string seccion);
        
        // retorna una matriz de 2 columnas con el nombre y la sumatoria de las columnas del parcial 1 al 3
       
        string[,] sumatoria_general_por_alumno(string[,] matriz);

    }
}
