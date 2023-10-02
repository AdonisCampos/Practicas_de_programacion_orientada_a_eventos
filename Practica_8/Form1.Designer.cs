namespace Practica_8
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtId = new TextBox();
            TxtNombre = new TextBox();
            TxtApellido = new TextBox();
            TxtDireccion = new TextBox();
            BtnAgregar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            dataGridViewDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(244, 9);
            label1.Name = "label1";
            label1.Size = new Size(339, 30);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento de clientes Univo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(41, 30);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 163);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 3;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 204);
            label5.Name = "label5";
            label5.Size = new Size(111, 30);
            label5.TabIndex = 4;
            label5.Text = "Direccion:";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(164, 81);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(181, 23);
            TxtId.TabIndex = 5;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(164, 120);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(181, 23);
            TxtNombre.TabIndex = 6;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(164, 163);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(181, 23);
            TxtApellido.TabIndex = 7;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Location = new Point(164, 204);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(181, 23);
            TxtDireccion.TabIndex = 8;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.Location = new Point(30, 266);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(105, 31);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEditar.Location = new Point(164, 266);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(105, 31);
            BtnEditar.TabIndex = 10;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEliminar.Location = new Point(288, 266);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(105, 31);
            BtnEliminar.TabIndex = 11;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDatos
            // 
            dataGridViewDatos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDatos.Location = new Point(403, 68);
            dataGridViewDatos.Name = "dataGridViewDatos";
            dataGridViewDatos.ReadOnly = true;
            dataGridViewDatos.RowTemplate.Height = 25;
            dataGridViewDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDatos.Size = new Size(404, 221);
            dataGridViewDatos.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 309);
            Controls.Add(dataGridViewDatos);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtDireccion);
            Controls.Add(TxtApellido);
            Controls.Add(TxtNombre);
            Controls.Add(TxtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Direccion:";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtId;
        private TextBox TxtNombre;
        private TextBox TxtApellido;
        private TextBox TxtDireccion;
        private Button BtnAgregar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private DataGridView dataGridViewDatos;
    }
}