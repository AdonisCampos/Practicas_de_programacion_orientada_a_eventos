using System.Data;
using System.Data.SqlClient;

namespace Practica_8


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Creamos nuestra conexion a nuestra base de datos
        SqlConnection conexion = new SqlConnection
        ("Data Source=BERNARDOCAMPOS\\SERVIDORSQL;Initial Catalog=Empresa;Integrated Security=True; TrustServerCertificate=True");
        //Creamis un metodo para completar nuestras tablas
       

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Abrimos la consulta
            conexion.Open();

            string consulta = "INSERT INTO Empleados VALUES (" + TxtId.Text + " ,'" + TxtNombre.Text + "' ,'" + TxtApellido.Text + "' ,'" + TxtDireccion.Text + "')";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.ExecuteNonQuery();

            MessageBox.Show("Registro agregado");

            conexion.Close();
        }
    }
}