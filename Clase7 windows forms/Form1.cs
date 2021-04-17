using Clase7_windows_forms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Clase7_windows_forms
{
    public partial class Form1 : Form
    {
    
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArreglo_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 10;
            arreglo[1] = 8;
            arreglo[2] = 16;
            arreglo[3] = 36;
            arreglo[4] = 1;

            ClSarreglos ObjArreglo = new ClSarreglos(arreglo);
            int[] resultado = ObjArreglo.MetodoBurbuja();

            for (int indice = 0; indice < resultado.Length; indice++)
            {
                listBoxResultado.Items.Add($"{resultado[indice]} ");
            }

        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona tu archivo plano";


            ofd.InitialDirectory = @"C:\Pictures\Clase7WindowsForms)";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";



            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);

                ArregloNotas = ar.LeerArchivo(archivo); //retorna arreglo

                textBoxContenido.Text = resultado;
            }
        }

        public int promedios(string[,] matriz, int columna)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);

            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);
            }
            promedio = acumulador / matriz.GetLength(0) - 1;
            return promedio;
        }


        private void btnNombres_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int acumulador = 0 ;
       
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];

            int[] ordenarparcial = new int[ArregloNotas.Length - 1];
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (contador != 0)
                {
                    listBoxResultado.Items.Add(datos[1]);
                    listBoxResultado.Sorted = true;


                    acumulador = acumulador + Convert.ToInt32(datos[4]);
                    ordenarparcial[contador - 1] = Convert.ToInt32(datos[4]);

                }
                ArregloDosDimensiones[contador, 0] = datos[0];
                ArregloDosDimensiones[contador, 1] = datos[1];
                ArregloDosDimensiones[contador, 2] = datos[2];
                ArregloDosDimensiones[contador, 3] = datos[3];
                ArregloDosDimensiones[contador, 4] = datos[4];
                ArregloDosDimensiones[contador, 5] = datos[5];
                contador++;
                
            }
            

            ClSarreglos fncArreglo = new ClSarreglos(ordenarparcial);
            int min = ordenarparcial[0];
            int max = ordenarparcial[ordenarparcial.Length - 1];


            int promedioMatriz2 = promedios(ArregloDosDimensiones, 2);
            int promedioMatriz3 = promedios(ArregloDosDimensiones, 3);
            int promedioMatriz4 = promedios(ArregloDosDimensiones, 4);

            MessageBox.Show($"\nminimo: {min}\nmaximo: {max}\nPromedio parcial 1: {promedioMatriz2}\nPromedio parcial 2: {promedioMatriz3}\nPromedio parcial 3: {promedioMatriz4}");
        
        }

        private void listBoxResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ejer2_Click(object sender, EventArgs e)
        {
           
        }

        private void Ejer1_Click(object sender, EventArgs e)
        {
            int promedio, acumulador=0, contador=0;
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];

            int[] ordenarparcial = new int[ArregloNotas.Length - 1];
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (contador != 0)
                {
                    listBoxResultado.Items.Add(datos[4]);
                    acumulador = acumulador + Convert.ToInt32(datos[4]);
                    ordenarparcial[contador - 1] = Convert.ToInt32(datos[4]);

                }
                ArregloDosDimensiones[contador, 0] = datos[0];
                ArregloDosDimensiones[contador, 1] = datos[1];
                ArregloDosDimensiones[contador, 2] = datos[2];
                ArregloDosDimensiones[contador, 3] = datos[3];
                ArregloDosDimensiones[contador, 4] = datos[4];
                ArregloDosDimensiones[contador, 5] = datos[5];
                contador++;

            }
            ClSarreglos fncArreglo = new ClSarreglos(ordenarparcial);
            int min = ordenarparcial[0];
            int max = ordenarparcial[ordenarparcial.Length - 1];
            promedio = acumulador / contador - 1;
            MessageBox.Show($"Promedio es: {promedio}");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            listBoxResultado.Items.Clear();
        }

        private void Ejer3_Click(object sender, EventArgs e)
        {
          
            int contador = 0;
            foreach (string linea in ArregloNotas)
            {
                
                string[] datos = linea.Split(';');

                if (contador != 0)
                {
                    listBoxResultado.Items.Add(datos[5]);
                    listBoxResultado.Sorted = true;
                }
                contador++;
            }
        }
    }
 }
    


            