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
            cmbClientes = new ComboBox();
            Cliente = new Label();
            btnReservar = new Button();
            label5 = new Label();
            txbNumeroDeNoches = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txbNumeroDeHabitacion = new TextBox();
            dataGridView1 = new DataGridView();
            clNumeroDeHabitacion = new DataGridViewTextBoxColumn();
            clDisponibilidad = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            clNumHabitacion = new DataGridViewTextBoxColumn();
            clCliente = new DataGridViewTextBoxColumn();
            clMontoTotal = new DataGridViewTextBoxColumn();
            btnHabDisponible = new Button();
            btnRebActivas = new Button();
            groupBox3 = new GroupBox();
            btnCanReservacion = new Button();
            label7 = new Label();
            txbNumHabitacion = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            groupBox2.Controls.Add(cmbClientes);
            groupBox2.Controls.Add(Cliente);
            groupBox2.Controls.Add(btnReservar);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txbNumeroDeNoches);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txbNumeroDeHabitacion);
            groupBox2.Location = new Point(12, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 231);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reserva habitacion";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(177, 125);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(147, 28);
            cmbClientes.TabIndex = 6;
            cmbClientes.Text = "selecione cliente";
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(16, 128);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(55, 20);
            Cliente.TabIndex = 5;
            Cliente.Text = "Cliente";
            Cliente.Click += Cliente_Click;
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(77, 174);
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
            label5.Location = new Point(16, 88);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 4;
            label5.Text = "Numero de noches";
            label5.Click += label5_Click;
            // 
            // txbNumeroDeNoches
            // 
            txbNumeroDeNoches.Location = new Point(177, 81);
            txbNumeroDeNoches.Name = "txbNumeroDeNoches";
            txbNumeroDeNoches.Size = new Size(147, 27);
            txbNumeroDeNoches.TabIndex = 3;
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
            label3.Location = new Point(16, 50);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 1;
            label3.Text = "Numero de habitacion";
            label3.Click += label3_Click;
            // 
            // txbNumeroDeHabitacion
            // 
            txbNumeroDeHabitacion.Location = new Point(180, 40);
            txbNumeroDeHabitacion.Name = "txbNumeroDeHabitacion";
            txbNumeroDeHabitacion.Size = new Size(144, 27);
            txbNumeroDeHabitacion.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clNumeroDeHabitacion, clDisponibilidad });
            dataGridView1.Location = new Point(425, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(417, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { clNumHabitacion, clCliente, clMontoTotal });
            dataGridView2.Location = new Point(425, 286);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(417, 189);
            dataGridView2.TabIndex = 5;
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
            // btnHabDisponible
            // 
            btnHabDisponible.Location = new Point(556, 216);
            btnHabDisponible.Name = "btnHabDisponible";
            btnHabDisponible.Size = new Size(168, 48);
            btnHabDisponible.TabIndex = 6;
            btnHabDisponible.Text = "ver habitaciones disponibles";
            btnHabDisponible.UseVisualStyleBackColor = true;
            // 
            // btnRebActivas
            // 
            btnRebActivas.Location = new Point(573, 488);
            btnRebActivas.Name = "btnRebActivas";
            btnRebActivas.Size = new Size(165, 52);
            btnRebActivas.TabIndex = 7;
            btnRebActivas.Text = "ver reservaciones activas ";
            btnRebActivas.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(btnCanReservacion);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txbNumHabitacion);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(18, 549);
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
            btnCanReservacion.Size = new Size(94, 29);
            btnCanReservacion.TabIndex = 3;
            btnCanReservacion.Text = "Cancelar habitacion";
            btnCanReservacion.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 41);
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
            ClientSize = new Size(854, 692);
            Controls.Add(groupBox3);
            Controls.Add(btnRebActivas);
            Controls.Add(btnHabDisponible);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private TextBox txbNumeroDeHabitacion;
        private Label label4;
        private Label label5;
        private TextBox txbNumeroDeNoches;
        private Label Cliente;
        private ComboBox cmbClientes;
        private Button btnReservar;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn clNumeroDeHabitacion;
        private DataGridViewTextBoxColumn clDisponibilidad;
        private Button btnHabDisponible;
        private Button btnRebActivas;
        private DataGridViewTextBoxColumn clNumHabitacion;
        private DataGridViewTextBoxColumn clCliente;
        private DataGridViewTextBoxColumn clMontoTotal;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox txbNumHabitacion;
        private Label label6;
        private Button btnCanReservacion;
    }
}
