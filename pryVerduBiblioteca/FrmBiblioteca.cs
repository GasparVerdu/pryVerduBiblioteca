using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVerduBiblioteca
{
    public partial class FrmBiblioteca : Form
    {
        //espacios para la cantidad de libros, distribuidoras y editoriales
        string[,] matConsultaLibro = new string[21, 5];
        string[,] matDistribuidora = new string[7, 2];
        string[,] matEditorial = new string[7, 2];
        //var global
        int NumPag = 0;
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            char separador = Convert.ToChar(",");
            int Fm = 0;
            int FmDistribuidora = 0;
            int FmEditorial = 0;

            StreamReader srDistribuidora = new StreamReader("./DISTRIBUIDORA.txt");
            StreamReader srConsultaLibro = new StreamReader("./LIBRO.txt");
            StreamReader srEditorial = new StreamReader("./EDITORIAL.txt");

            while (!srDistribuidora.EndOfStream)
            {
                string[] vecDistribuidora = srDistribuidora.ReadLine().Split(separador);
                matDistribuidora[FmDistribuidora,0] = vecDistribuidora[0];
                matDistribuidora[FmDistribuidora, 1] = vecDistribuidora[1];
                FmDistribuidora++;
            }
            while (!srEditorial.EndOfStream)
            {
                string[] vecEditorial = srEditorial.ReadLine().Split(separador);
                matEditorial[FmEditorial,0] = vecEditorial[0];
                matEditorial[FmEditorial,1] = vecEditorial[1];
                FmEditorial++;
            }
            while (!srConsultaLibro.EndOfStream)
            {
                //4 por la cantidad de datos que hay en la linea de los libros 
                string[] vecLibro = srConsultaLibro.ReadLine().Split(separador);
                matConsultaLibro [Fm, 0] = vecLibro[0];
                matConsultaLibro [Fm, 1] = vecLibro[1];
                matConsultaLibro [Fm, 2] = vecLibro[2];
                matConsultaLibro [Fm, 3] = vecLibro[3];
                matConsultaLibro [Fm, 4] = vecLibro[4];

                switch (matConsultaLibro[Fm, 4])
                {
                    //SEGUN SEA, va a comparar los valores que hay en la matriz de la distribuidora con la cuarta posicion
                    //que marque el separador, que indicaria a que numero de editorial pertenece
                    //las "filas" de la matDistribuidora hacen alusion a la cantidad de distribuidoras que hay y el uno a la posicion dodne se encuentra el nombre de las mismas
                    case "\t1": matConsultaLibro[Fm, 4] = matDistribuidora[0, 1]; break;
                    case "\t2": matConsultaLibro[Fm, 4] = matDistribuidora[1, 1]; break;
                    case "\t3": matConsultaLibro[Fm, 4] = matDistribuidora[2, 1]; break;
                    case "\t4": matConsultaLibro[Fm, 4] = matDistribuidora[3, 1]; break;
                    case "\t5": matConsultaLibro[Fm, 4] = matDistribuidora[4, 1]; break;
                    case "\t6": matConsultaLibro[Fm, 4] = matDistribuidora[5, 1]; break;
                    case "\t7": matConsultaLibro[Fm, 4] = matDistribuidora[6, 1]; break;
                }
                switch (matConsultaLibro[Fm, 2])
                {
                    //SEGUN SEA, ca a comparar ahora los numeros de las editoriales con el nombre que esta xcargado en la otra matriz
                    //la posicion 2 de la matConsultaLibro indica el numero de editorial que corresponde
                    //ej, en el primer libro indica el numero 7, entocnes compara y la editorial 7 es colombo
                    //o sea seria la posicion matEditorial[6, 1] (6 indica el septimo lugar y el uno el nomrbe que corresponde
                    case "\t1": matConsultaLibro[Fm, 2] = matEditorial[0, 1]; break;
                    case "\t2": matConsultaLibro[Fm, 2] = matEditorial[1, 1]; break;
                    case "\t3": matConsultaLibro[Fm, 2] = matEditorial[2, 1]; break;
                    case "\t4": matConsultaLibro[Fm, 2] = matEditorial[3, 1]; break;
                    case "\t5": matConsultaLibro[Fm, 2] = matEditorial[4, 1]; break;
                    case "\t6": matConsultaLibro[Fm, 2] = matEditorial[5, 1]; break;
                    case "\t7": matConsultaLibro[Fm, 2] = matEditorial[6, 1]; break;
                }
                Fm++;
            }
            srConsultaLibro.Close();
            //cargar los datos en la grilla
            //el numero de la pagina va a ser 0, para cargar los primeros datos que tengamos y despues vamos a ir incrementandola
            dgvBiblioteca.Rows.Add(matConsultaLibro[NumPag, 0], matConsultaLibro[NumPag,1], matConsultaLibro[NumPag,2], matConsultaLibro[NumPag,3], matConsultaLibro[NumPag,4]);




        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            NumPag++;
            if (NumPag < 21) //canitdad de libros que hay en los datos
            {
                dgvBiblioteca.Rows.Clear();
                dgvBiblioteca.Rows.Add(matConsultaLibro[NumPag, 0], matConsultaLibro[NumPag, 1], matConsultaLibro[NumPag, 2], matConsultaLibro[NumPag, 3], matConsultaLibro[NumPag, 4]);
            }
            else
            {
                MessageBox.Show("No hay mas libros para mostrar");
                
                NumPag = 20;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NumPag--;
            if (NumPag >= 0) 
            {
                dgvBiblioteca.Rows.Clear();
                dgvBiblioteca.Rows.Add(matConsultaLibro[NumPag, 0], matConsultaLibro[NumPag, 1], matConsultaLibro[NumPag, 2], matConsultaLibro[NumPag, 3], matConsultaLibro[NumPag, 4]);
            }
            else
            {
                MessageBox.Show("No hay mas libros para mostrar");
                
                NumPag = 0;
            }
        }
    }
}
