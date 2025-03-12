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
            // llenar la matriz de habitaciones con Habitaciones
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Habitacion habitacion = new Habitacion(true);
                    string numeroHabitacion = "";
                    if (i == 0)
                    {
                        numeroHabitacion = (j + 1).ToString();
                    }
                    else
                    {
                        if (j == 9)
                        {
                            numeroHabitacion = (i + 1).ToString() + "0";
                        }
                        else
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

            ActualizarGridDisponibilidad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // validar el formulario de cliente
            if (EsFormularioClienteValido(txbNombre.Text, txbIdentificacion.Text, txbNumeroDeTelefono.Text))
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
                    cmbClientes.Items.Add(
                        listaDeClientes[i].documentoDeIdentidad + "," + listaDeClientes[i].nombreDeCliente
                    );
                }
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            // guardar reservacion en diccionario de reservacion.
            Reservacion reservacion = new Reservacion();
            int pisoHabitacion = Convert.ToInt16(nudPiso.Value);
            int numeroHabitacion = Convert.ToInt16(nudHabitacion.Value);

            Habitacion habitacion = matrizDeHabitaciones[pisoHabitacion - 1, numeroHabitacion - 1];

            // validar formulario
            if (EsFormularioReservaValido(cmbClientes.Items.Count, cmbClientes.SelectedIndex)) {
                reservacion.numeroDeHabitacion = habitacion.numeroDeHabitacion;
                reservacion.cantidadDeNoches = Convert.ToInt32(nudNumeroNoches.Value);
                reservacion.montoTotal = Convert.ToInt32(nudNumeroNoches.Value) * habitacion.precioPorNoche;

                // dividir string para obtener identifiacon
                string[] clienteSplited = cmbClientes.SelectedItem.ToString().Split(",");

                // buscar cliente por identificacion
                Cliente cliente = listaDeClientes.Find(cliente => cliente.documentoDeIdentidad == clienteSplited[0]);

                // guardar cliente
                reservacion.cliente = cliente;

                // validar si la habitacion esta disponible
                if (habitacion.estadoDeHabitacion)
                {
                    // guardar reservacion
                    diccionarioReservaciones.Add(habitacion.numeroDeHabitacion, reservacion);
                    habitacion.estadoDeHabitacion = false;
                    matrizDeHabitaciones[pisoHabitacion - 1, numeroHabitacion - 1] = habitacion;
                    MessageBox.Show("Reservacion guardada con exito");
                }
                else
                {
                    // enviar mensaje de habitacion ocupada
                    MessageBox.Show("La habitacion seleccionada ya esta ocupada");
                }

                // resetear campos de reservacion 
                nudPiso.Value = 1;
                nudHabitacion.Value = 1;
                nudNumeroNoches.Value = 1;
                cmbClientes.Text = "selecciona un cliente";

                // actualizar grids
                ActualizarGridDisponibilidad();
                ActualizarGridReservaciones();
            }
        }

        private void btnCanReservacion_Click(object sender, EventArgs e)
        {
            // validar que el campo no este vacio
            if (EsCampoVacio(txbNumHabitacion.Text))
            {
                // enviar mensaje de campo vacio
                MessageBox.Show("El numero de habitacion esta vacio");
            }
            else
            {
                // validar si el numero de la habiatacion existe
                if (diccionarioReservaciones.Keys.Contains(txbNumHabitacion.Text))
                {

                    // eliminar reserva
                    diccionarioReservaciones.Remove(txbNumHabitacion.Text);

                    // resetear estado de habitacion
                    Tuple<int, int> pisoYHabitacion = ObtenerPisoYNumeroHabitacion(txbNumHabitacion.Text);
                    Habitacion habitacion = matrizDeHabitaciones[pisoYHabitacion.Item1, pisoYHabitacion.Item2];
                    habitacion.estadoDeHabitacion = true;
                    matrizDeHabitaciones[pisoYHabitacion.Item1, pisoYHabitacion.Item2] = habitacion;
                    MessageBox.Show("La reserva fue cancelada");

                    //resetear textbox
                    txbNumHabitacion.Text = "";

                    // actualizar grids
                    ActualizarGridDisponibilidad();
                    ActualizarGridReservaciones();
                }
                else
                {
                    MessageBox.Show("El numero de habitacion ingresada no existe");
                }
            }
        }

        private void ActualizarGridDisponibilidad()
        {
            // llenar grid con lista de habitacionees
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

        private void ActualizarGridReservaciones()
        {
            // llenar grid con diccionario de reservaciones
            dgvReservaciones.Rows.Clear();
            foreach (var item in diccionarioReservaciones)
            {
                dgvReservaciones.Rows.Add(
                    item.Value.numeroDeHabitacion,
                    item.Value.cliente.nombreDeCliente,
                    item.Value.montoTotal
                );
            }
        }

        private bool EsFormularioClienteValido(string nombre, string identificacion, string numerotelefono)
        {
            // validar si los campos del formulario de clientes estan vacios
            bool esFormularioValido = false;
            if (EsCampoVacio(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacio");
            } else if (EsCampoVacio(identificacion))
            {
                MessageBox.Show("La identificacion no puede estar vacia");
            } else if (EsCampoVacio(numerotelefono))
            {
                MessageBox.Show("El numero de telefono no puede estar vacio");
            } else
            {
                esFormularioValido = true;
            }

            return esFormularioValido;
        }

        private bool EsFormularioReservaValido(int comboClienteNumeroItems, int clienteIndex)
        {
            // validar si el comboBox tiene datos y si se ha seleccionado un item
            bool esFormularioValido = false;
            if (comboClienteNumeroItems < 1)
            {
                MessageBox.Show("Debes de agregar clientes");
            } else if (clienteIndex == -1)
            {
                MessageBox.Show("Debes selecconar un cliente");
            } else
            {
                esFormularioValido = true;
            }

            return esFormularioValido;
        }

        // validar si el campo esta vacio
        private bool EsCampoVacio(string valor)
        {
           return valor == "";
        }

        // obtener [piso, numeroDeHabitacion] usando el numero de habitacion ingresado en el formulario
        private Tuple<int, int> ObtenerPisoYNumeroHabitacion(string numeroHabitacion)
        {
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(matrizDeHabitaciones[i, j].numeroDeHabitacion == numeroHabitacion)
                    {
                       return Tuple.Create(i, j);                        
                    }
                }
            }
            return Tuple.Create(1, 1);
        }
    }
}
