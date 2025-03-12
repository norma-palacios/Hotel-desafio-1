namespace Hotel_desafio_1
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
            groupBox1 = new GroupBox();
            txbNumeroDeTelefono = new TextBox();
            Telefono = new Label();
            txbIdentificacion = new TextBox();
            label2 = new Label();
            btnRegistrar = new Button();
            label1 = new Label();
            txbNombre = new TextBox();
            groupBox2 = new GroupBox();
            nudNumeroNoches = new NumericUpDown();
            nudHabitacion = new NumericUpDown();
            nudPiso = new NumericUpDown();
            label8 = new Label();
            cmbClientes = new ComboBox();
            Cliente = new Label();
            btnReservar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvDisponibilidad = new DataGridView();
            clNumeroDeHabitacion = new DataGridViewTextBoxColumn();
            clDisponibilidad = new DataGridViewTextBoxColumn();
            dgvReservaciones = new DataGridView();
            clNumHabitacion = new DataGridViewTextBoxColumn();
            clCliente = new DataGridViewTextBoxColumn();
            clMontoTotal = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            btnCanReservacion = new Button();
            label7 = new Label();
            txbNumHabitacion = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumeroNoches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHabitacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPiso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDisponibilidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txbNumeroDeTelefono);
            groupBox1.Controls.Add(Telefono);
            groupBox1.Controls.Add(txbIdentificacion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txbNombre);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de cliente";
            // 
            // txbNumeroDeTelefono
            // 
            txbNumeroDeTelefono.Location = new Point(173, 125);
            txbNumeroDeTelefono.Name = "txbNumeroDeTelefono";
            txbNumeroDeTelefono.Size = new Size(125, 27);
            txbNumeroDeTelefono.TabIndex = 5;
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Location = new Point(13, 132);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(144, 20);
            Telefono.TabIndex = 4;
            Telefono.Text = "Numero de telefono";
            // 
            // txbIdentificacion
            // 
            txbIdentificacion.Location = new Point(173, 81);
            txbIdentificacion.Name = "txbIdentificacion";
            txbIdentificacion.Size = new Size(125, 27);
            txbIdentificacion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Identificacion";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(77, 172);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(179, 39);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar cliente";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(173, 40);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(125, 27);
            txbNombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(nudNumeroNoches);
            groupBox2.Controls.Add(nudHabitacion);
            groupBox2.Controls.Add(nudPiso);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cmbClientes);
            groupBox2.Controls.Add(Cliente);
            groupBox2.Controls.Add(btnReservar);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 269);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reserva habitacion";
            // 
            // nudNumeroNoches
            // 
            nudNumeroNoches.Location = new Point(180, 128);
            nudNumeroNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumeroNoches.Name = "nudNumeroNoches";
            nudNumeroNoches.Size = new Size(150, 27);
            nudNumeroNoches.TabIndex = 10;
            nudNumeroNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudHabitacion
            // 
            nudHabitacion.Location = new Point(180, 83);
            nudHabitacion.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudHabitacion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHabitacion.Name = "nudHabitacion";
            nudHabitacion.Size = new Size(150, 27);
            nudHabitacion.TabIndex = 9;
            nudHabitacion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudPiso
            // 
            nudPiso.Location = new Point(177, 40);
            nudPiso.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudPiso.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPiso.Name = "nudPiso";
            nudPiso.Size = new Size(150, 27);
            nudPiso.TabIndex = 8;
            nudPiso.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 89);
            label8.Name = "label8";
            label8.Size = new Size(158, 20);
            label8.TabIndex = 7;
            label8.Text = "Numero de habitacion";
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(77, 169);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(253, 28);
            cmbClientes.TabIndex = 6;
            cmbClientes.Text = "selecione cliente";
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(16, 169);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(55, 20);
            Cliente.TabIndex = 5;
            Cliente.Text = "Cliente";
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(77, 209);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(164, 39);
            btnReservar.TabIndex = 3;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 133);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 4;
            label5.Text = "Numero de noches";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 98);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 47);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 1;
            label3.Text = "Piso de habitacion";
            // 
            // dgvDisponibilidad
            // 
            dgvDisponibilidad.BackgroundColor = SystemColors.ButtonFace;
            dgvDisponibilidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisponibilidad.Columns.AddRange(new DataGridViewColumn[] { clNumeroDeHabitacion, clDisponibilidad });
            dgvDisponibilidad.Location = new Point(425, 22);
            dgvDisponibilidad.Name = "dgvDisponibilidad";
            dgvDisponibilidad.RowHeadersWidth = 51;
            dgvDisponibilidad.Size = new Size(417, 229);
            dgvDisponibilidad.TabIndex = 4;
            // 
            // clNumeroDeHabitacion
            // 
            clNumeroDeHabitacion.HeaderText = "Numero de Habitacion";
            clNumeroDeHabitacion.MinimumWidth = 6;
            clNumeroDeHabitacion.Name = "clNumeroDeHabitacion";
            clNumeroDeHabitacion.Width = 130;
            // 
            // clDisponibilidad
            // 
            clDisponibilidad.HeaderText = "Disponibilidad";
            clDisponibilidad.MinimumWidth = 6;
            clDisponibilidad.Name = "clDisponibilidad";
            clDisponibilidad.Width = 130;
            // 
            // dgvReservaciones
            // 
            dgvReservaciones.BackgroundColor = SystemColors.ButtonFace;
            dgvReservaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservaciones.Columns.AddRange(new DataGridViewColumn[] { clNumHabitacion, clCliente, clMontoTotal });
            dgvReservaciones.Location = new Point(425, 286);
            dgvReservaciones.Name = "dgvReservaciones";
            dgvReservaciones.RowHeadersWidth = 51;
            dgvReservaciones.Size = new Size(417, 269);
            dgvReservaciones.TabIndex = 5;
            // 
            // clNumHabitacion
            // 
            clNumHabitacion.HeaderText = "Numero de Habitacion";
            clNumHabitacion.MinimumWidth = 6;
            clNumHabitacion.Name = "clNumHabitacion";
            clNumHabitacion.Width = 125;
            // 
            // clCliente
            // 
            clCliente.HeaderText = "Cliente";
            clCliente.MinimumWidth = 6;
            clCliente.Name = "clCliente";
            clCliente.Width = 125;
            // 
            // clMontoTotal
            // 
            clMontoTotal.HeaderText = "Monto total";
            clMontoTotal.MinimumWidth = 6;
            clMontoTotal.Name = "clMontoTotal";
            clMontoTotal.Width = 125;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(btnCanReservacion);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txbNumHabitacion);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(18, 575);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(347, 131);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cancelar reservacion ";
            // 
            // btnCanReservacion
            // 
            btnCanReservacion.Location = new Point(119, 85);
            btnCanReservacion.Name = "btnCanReservacion";
            btnCanReservacion.Size = new Size(98, 29);
            btnCanReservacion.TabIndex = 3;
            btnCanReservacion.Text = "Cancelar habitacion";
            btnCanReservacion.UseVisualStyleBackColor = true;
            btnCanReservacion.Click += btnCanReservacion_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 48);
            label7.Name = "label7";
            label7.Size = new Size(158, 20);
            label7.TabIndex = 2;
            label7.Text = "Numero de habitacion";
            // 
            // txbNumHabitacion
            // 
            txbNumHabitacion.Location = new Point(193, 41);
            txbNumHabitacion.Name = "txbNumHabitacion";
            txbNumHabitacion.Size = new Size(125, 27);
            txbNumHabitacion.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 35);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 718);
            Controls.Add(groupBox3);
            Controls.Add(dgvReservaciones);
            Controls.Add(dgvDisponibilidad);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumeroNoches).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHabitacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPiso).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDisponibilidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txbNombre;
        private TextBox txbNumeroDeTelefono;
        private Label Telefono;
        private TextBox txbIdentificacion;
        private Label label2;
        private Button btnRegistrar;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Cliente;
        private ComboBox cmbClientes;
        private Button btnReservar;
        private DataGridView dgvDisponibilidad;
        private DataGridView dgvReservaciones;
        private DataGridViewTextBoxColumn clNumeroDeHabitacion;
        private DataGridViewTextBoxColumn clDisponibilidad;
        private DataGridViewTextBoxColumn clNumHabitacion;
        private DataGridViewTextBoxColumn clCliente;
        private DataGridViewTextBoxColumn clMontoTotal;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox txbNumHabitacion;
        private Label label6;
        private Button btnCanReservacion;
        private Label label8;
        private NumericUpDown nudHabitacion;
        private NumericUpDown nudPiso;
        private NumericUpDown nudNumeroNoches;
    }
}
