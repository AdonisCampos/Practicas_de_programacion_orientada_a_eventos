namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void validadfecha()
        {
            DateTime hoy = DateTime.Today;
            if (TimePickerEdad.Value.Date > hoy)
            {
                MessageBox.Show("Fecha Invalida", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblResultado.Text = ("No puedes selecionar futura");
            }
            else if (TimePickerEdad.Value.Date.AddYears(18) <= hoy)
            {
                MessageBox.Show("Eres mayor de edad", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultado.Text = ("Eres mayor de edad");
            }
            else
            {
                MessageBox.Show("Eres menor de edad", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultado.Text = ("Eres menor de edad");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            validadfecha();
        }
    }
}