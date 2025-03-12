namespace Hotel_desafio_1
{
    public partial class Form1 : Form
    {
        bool[,] matrizDeHabitaciones = new bool[5, 10];
        List<Cliente> listaDeClientes = new List<Cliente>();
        Dictionary<string, Reservacion> diccionarioReservaciones = new Dictionary<string, Reservacion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


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
            for(int i =0; i < listaDeClientes.Count; i++) 
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
            reservacion.numeroDeHabitacion = txbNumeroDeHabitacion.Text;
            reservacion.cantidadDeNoches = Convert.ToInt32(txbNumeroDeNoches.Text);
            reservacion.identificacionDelCliente = cmbClientes.SelectedItem.ToString();

            if (diccionarioReservaciones.ContainsKey(txbNumeroDeHabitacion.Text))
            {
                MessageBox.Show("La habitacion seleccionada ya esta ocupada");
            } else
            {
                diccionarioReservaciones.Add(txbNumeroDeHabitacion.Text, reservacion);
                MessageBox.Show("Reservacion guardada con exito");
            }

            // resetear campos de reservacion 
            txbNumeroDeHabitacion.Text = "";
            txbNumeroDeNoches.Text = "";
            cmbClientes.SelectedIndex = 0;
        }
    }
}
