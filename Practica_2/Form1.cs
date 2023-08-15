using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    //Formulario principal que muestra imágenes en un PictureBox y permite navegar entre ellas.
    public partial class Form1 : Form
	{
        // Array de nombres de imágenes en la carpeta "Imagenes"
        private string[] imageNames = new string[]
         {
            "imagen1.jpg",
            "imagen2.jpeg",
            "imagen3.jpeg",
            "imagen4.jpg"
         };
        // Índice de la imagen actual que se está mostrando
        private int currentImageIndex = 0;
        //Constructor del formulario.
        public Form1()
		{
            InitializeComponent();
            // Inicializa el slider de imagenes
            InitializeImageSlider();
        }
        // Evento click del botón "Cambio Etiqueta a Después"
        private void button1_Click(object sender, EventArgs e)
		{
            // Cambia el contenido de la etiqueta al hacer clic en el botón 
            label1.Text = "Despues del evento";
		}
        // Evento click del botón "Cambio Etiqueta a Antes"
        private void button2_Click(object sender, EventArgs e)
		{
            // Cambia el contenido de la etiqueta al hacer clic en el botón
            label1.Text = "Antes del evento";
		}

		private void button3_Click(object sender, EventArgs e)
		{
            // Crea un nuevo objeto de la clase Random
            Random ramdom = new Random();
            // Crea un nuevo objeto de la clase Color con un valor aleatorio entre 0 y 255 para cada componente RGB
            Color coloraleatorio = Color.FromArgb(ramdom.Next(255), ramdom.Next(255), ramdom.Next(255));
            // Establece el color de fondo del panel1 al coloraleatorio
            panel1.BackColor = coloraleatorio;
			
		}
        
        // Inicializa el PictureBox con la primera imagen
        private void InitializeImageSlider()
        {
            // Obtiene la ruta de la imagen actual
            string imagePath = Path.Combine(Application.StartupPath, "Imagenes", imageNames[currentImageIndex]);
            // Establece la imagen del PictureBox con la imagen actual
            pictureBox1.Image = Image.FromFile(imagePath);
        }
        // Maneja el evento del botón "Siguiente"
        private void button5_Click(object sender, EventArgs e)
        {
            // Incrementa el índice de la imagen actual si no es la última imagen
            if (currentImageIndex < imageNames.Length - 1)
            {
                currentImageIndex++;
                UpdatePictureBox();// Actualiza la imagen en el PictureBox
            }

        }
        // Maneja el evento del botón "Anterior"
        private void button4_Click(object sender, EventArgs e)
        {
            // Si el índice de la imagen actual no es la primera imagen,
            // decrementa el índice de la imagen actual y actualiza la imagen en el PictureBox
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                UpdatePictureBox();// Actualiza la imagen en el PictureBox
            }
        }
        // Actualiza la imagen en el PictureBox
        private void UpdatePictureBox()
        {
            // Obtiene la ruta de la imagen actual
            string imagePath = Path.Combine(Application.StartupPath, "Imagenes", imageNames[currentImageIndex]);
            // Establece la imagen del PictureBox con la imagen actual
            pictureBox1.Image = Image.FromFile(imagePath);
        }

    }
}
