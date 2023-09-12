namespace Practica_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            btnCalcular = new Button();
            TimePickerEdad = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(67, 167);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(180, 25);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Validacion de edad";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(108, 115);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular edad";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // TimePickerEdad
            // 
            TimePickerEdad.Location = new Point(52, 74);
            TimePickerEdad.MinDate = new DateTime(2001, 9, 11, 19, 22, 0, 0);
            TimePickerEdad.Name = "TimePickerEdad";
            TimePickerEdad.Size = new Size(232, 23);
            TimePickerEdad.TabIndex = 5;
            TimePickerEdad.Value = new DateTime(2023, 9, 11, 19, 22, 31, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 35);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 4;
            label1.Text = "Verificacion de edad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(407, 258);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(TimePickerEdad);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Button btnCalcular;
        private DateTimePicker TimePickerEdad;
        private Label label1;
    }
}