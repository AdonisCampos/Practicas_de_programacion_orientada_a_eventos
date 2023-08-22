using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
         //Utilizar la clase openfiledialog para visualizar la ventana
         OpenFileDialog abrir = new OpenFileDialog();
            //Filtro para abrir imagenes JPG
            abrir.Filter = "JPEG (*.JPG)|*JPG|BMP(*.BMP)|*.BMP"; 

            //Validar ventana y mostrarla.
            //ShowDialog abre una ventana, el if valida nuestra respuesta
            //en la ventana
            if (abrir.ShowDialog() == DialogResult.OK )
            {

                //Validaciones sobre ventana img
                //Obteniendo la ruta de la imagen y el nombre del archivo
                pictureBox1.Image = Image.FromFile(abrir.FileName);
            }
            else
            {

            }
            
        }
        //Inicializar el estado de la imagen 
        private bool isimg = true;

        // Manejador de evento para el Timer que cambia automáticamente la imagen del PictureBox
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Iniciando la estructura condicional
            if (isimg)
            { // Cargar la primera imagen en el PictureBox3
                pictureBox3.Image = Image.FromFile("D:\\Escritorio\\Practica_3\\img\\imagen1.jpg");
                isimg = false;
            }
            // Cambiar el estado de la imagen a falso
            else
            {
                // Cargar la segunda imagen en el PictureBox3
                pictureBox3.Image = Image.FromFile("D:\\Escritorio\\Practica_3\\img\\imagen2.jpg");
                // Cambiar el estado de la imagen a verdadero
                isimg = true;
            }
        }
        // Manejador de evento para el botón que cambia manualmente la imagen del PictureBox2
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Iniciando la estructura condicional
            if (isimg)
            {
                // Cargar la primera imagen en el PictureBox
                pictureBox2.Image = Image.FromFile("D:\\Escritorio\\Practica_3\\img\\imagen1.jpg");
                // Cambiar el estado de la imagen a falso
                isimg = false;
            }
            else
            {
                // Cargar la segunda imagen en el PictureBox2
                pictureBox2.Image = Image.FromFile("D:\\Escritorio\\Practica_3\\img\\imagen2.jpg");
                // Cambiar el estado de la imagen a verdadero
                isimg = true;
            }
        }
    }
}
