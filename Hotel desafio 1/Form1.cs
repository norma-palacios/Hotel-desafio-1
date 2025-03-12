namespace Hotel_desafio_1
{
    public partial class Form1 : Form
    {
        Habitacion[,] matrizDeHabitaciones = new Habitacion[5, 10];
        List<Cliente> listaDeClientes = new List<Cliente>();
        Dictionary<string, Reservacion> diccionarioReservaciones = new Dictionary<string, Reservacion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Habitacion habitacion = new Habitacion(true);
                    string numeroHabitacion = "";
                    if (i == 0)
                    {
                        numeroHabitacion = (j+1).ToString();
                    }
                    else
                    {
                        if(j == 9)
                        {
                            numeroHabitacion = (i+1).ToString() + "0";
                        } else
                        {
                            numeroHabitacion = i.ToString() + (j + 1).ToString();
                        }
                    }
                    habitacion.numeroDeHabitacion = numeroHabitacion;
                    habitacion.precioPorNoche = habitacion.calcularCostoDeHabitacion(Convert.ToInt32(numeroHabitacion));
                    habitacion.tipoDeHabitacion = habitacion.obtenerTipoDeHabitacion(Convert.ToInt32(numeroHabitacion));
                    matrizDeHabitaciones[i, j] = habitacion;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //guardar cliente en lista de cliente 
            Cliente cliente = new Cliente();
            cliente.nombreDeCliente = txbNombre.Text;
            cliente.documentoDeIdentidad = txbIdentificacion.Text;
            cliente.numeroDeTelefono = txbNumeroDeTelefono.Text;
            listaDeClientes.Add(cliente);

            MessageBox.Show("Cliente guardado con exito");

            //resetear los textBox
            txbNombre.Text = "";
            txbIdentificacion.Text = "";
            txbNumeroDeTelefono.Text = "";

            // llenar el comboBox con el listado de clientes
            cmbClientes.Items.Clear();
            for (int i = 0; i < listaDeClientes.Count; i++)
            {
                cmbClientes.Items.Add(listaDeClientes[i].documentoDeIdentidad);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            // guardar reservacion en diccionario de reservacion.
            Reservacion reservacion = new Reservacion();
            int pisoHabitacion = Convert.ToInt16(nudPiso.Value);
            int numeroHabitacion = Convert.ToInt16(nudHabitacion.Value);

            Habitacion habitacion = matrizDeHabitaciones[pisoHabitacion - 1, numeroHabitacion - 1];

            reservacion.numeroDeHabitacion = habitacion.numeroDeHabitacion;
            reservacion.cantidadDeNoches = Convert.ToInt32(txbNumeroDeNoches.Text);
            reservacion.montoTotal = Convert.ToInt32(txbNumeroDeNoches.Text) * habitacion.precioPorNoche;
            reservacion.identificacionDelCliente = cmbClientes.SelectedItem.ToString();

            if (habitacion.estadoDeHabitacion)
            {
                diccionarioReservaciones.Add(habitacion.numeroDeHabitacion, reservacion);
                habitacion.estadoDeHabitacion = false;
                matrizDeHabitaciones[pisoHabitacion - 1, numeroHabitacion - 1] = habitacion;
                MessageBox.Show("Reservacion guardada con exito");
            }
            else
            {
                MessageBox.Show("La habitacion seleccionada ya esta ocupada");
            }

            // resetear campos de reservacion 
            nudPiso.Value = 1;
            nudHabitacion.Value = 1;
            txbNumeroDeNoches.Text = "";
            cmbClientes.SelectedIndex = 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txbNumeroDeHabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHabDisponible_Click(object sender, EventArgs e)
        {
            dgvDisponibilidad.Rows.Clear();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Habitacion habitacion = matrizDeHabitaciones[i, j];
                    dgvDisponibilidad.Rows.Add(habitacion.numeroDeHabitacion, habitacion.estadoDeHabitacion ? "Disponible" : "Ocupada");
                }
            }
            
        }
    }
}
