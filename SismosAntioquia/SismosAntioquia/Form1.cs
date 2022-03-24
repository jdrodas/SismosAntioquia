using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace SismosAntioquia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento a ejecutar cuando se carga la forma
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizaComboBoxRegiones();
            InicializaVisualizacionDatos();
        }

        /// <summary>
        /// Actualiza las regiones para visualizar en el ComboBoxRegiones
        /// </summary>
        private void ActualizaComboBoxRegiones()
        {
            comboRegionesAgregarSismo.DataSource = null;
            comboRegionesAgregarSismo.DataSource = AccesoDatos.ObtenerRegiones();
            comboRegionesAgregarSismo.DisplayMember = "region";
        }

        /// <summary>
        /// Consolida el llamado a todos los metodos que visualizan datos desde la DB
        /// </summary>
        private void InicializaVisualizacionDatos()
        {
            InicializaDataGridViewDetalleSismos();
            InicializaDataGridViewConsolidadoRegiones();
            InicializaDataGridViewSismosMes();
        }

        /// <summary>
        /// Actualiza Información del DataGridView de los sismos por mes
        /// </summary>
        private void InicializaDataGridViewSismosMes()
        {
            dataGridViewSismosMes.DataSource = null;
            dataGridViewSismosMes.DataSource = AccesoDatos.ObtenerSismosMes();
        }

        /// <summary>
        /// Visualiza la información del DataGridView los sismos
        /// </summary>
        private void InicializaDataGridViewDetalleSismos()
        {
            dataGridViewDetalleSismo.DataSource = null;
            dataGridViewDetalleSismo.DataSource = AccesoDatos.ObtenerDetalleSismos();
        }

        /// <summary>
        /// Visualiza la información del DataGridView de los sismos por regiones
        /// </summary>
        private void InicializaDataGridViewConsolidadoRegiones()
        {
            dataGridViewConsolidadoRegion.DataSource = null;
            dataGridViewConsolidadoRegion.DataSource = AccesoDatos.ObtenerConsolidadoRegion();
        }

        /// <summary>
        /// Valida que los campos mínimos de un sismo tienen valor
        /// </summary>
        /// <returns></returns>
        private bool ValidaCamposMinimos()
        {
            bool resultado = false;

            if (txtProfundidad.Text != "" ||
                txtMagnitud.Text != "" ||
                txtLatitud.Text != "" ||
                txtLongitud.Text != "" ||
                comboRegionesAgregarSismo.Text != "")
                resultado = true;

            return resultado;
        }

        /// <summary>
        /// Evento asociado al cambio de selección en el combo de regiones en Agregar Sismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboRegionesAgregarSismo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreRegion = comboRegionesAgregarSismo.Text;

            Coordenada coordenadaRegion = AccesoDatos.ObtieneCoordenadasRegion(nombreRegion);

            if (coordenadaRegion.Latitud != 0 && coordenadaRegion.Longitud != 0)
            {
                txtLatitud.Text = coordenadaRegion.LatitudGMS.ToString();
                txtLongitud.Text = coordenadaRegion.LongitudGMS.ToString();
            }
        }

        /// <summary>
        /// Evento asociado al cambio de selección en el combo de regiones en Editar Sismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxRegionesEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreRegion = comboBoxRegionesEditar.Text;

            Coordenada coordenadaRegion = AccesoDatos.ObtieneCoordenadasRegion(nombreRegion);

            if (coordenadaRegion.Latitud != 0 && coordenadaRegion.Longitud != 0)
            {
                txtLatitudEditar.Text = coordenadaRegion.LatitudGMS.ToString();
                txtLongitudEditar.Text = coordenadaRegion.LongitudGMS.ToString();
            }
        }

        /// <summary>
        /// Convierte un dato string en un datetime de fecha o de hora
        /// </summary>
        private DateTime ObtieneFechaHora(string dato, string tipo)
        {
            DateTime resultado = new DateTime();
            string[] elementos;

            if (tipo == "fecha")
            {
                elementos = dato.Split('/');
                resultado = new DateTime(int.Parse(elementos[2]),
                                            int.Parse(elementos[1]),
                                            int.Parse(elementos[0]));
            }

            if (tipo == "hora")
            {
                elementos = dato.Split(':');

                //Necesitamos una hora, asi que los tres primeros valores pueden ser
                // una fecha ficticia, por ejemplo 1900-01-01
                resultado = new DateTime(1900, 1, 1,
                                         int.Parse(elementos[0]),
                                         int.Parse(elementos[1]),
                                         int.Parse(elementos[2]));
            }

            return resultado;
        }

        /// <summary>
        /// Valida que los datos ingresados por el usuario correspondan a un objeto Coordenada
        /// </summary>
        /// <param name="latitudGMS"></param>
        /// <param name="longitudGMS"></param>
        /// <returns></returns>
        private bool ValidaDatosGMS(string[] latitudGMS, string[] longitudGMS)
        {
            bool esLatitudOk = false, esLongitudOk = false;
            double grados, minutos, segundos;

            //Aqui validamos si la latitud es correcta
            try
            {
                grados = double.Parse(latitudGMS[0]);
                minutos = double.Parse(latitudGMS[1]);
                segundos = double.Parse(latitudGMS[2]);

                if (latitudGMS[3] == "N" || latitudGMS[3] == "S")
                    esLatitudOk = true;
            }
            catch (FormatException elError)
            {
                MessageBox.Show("El dato de latitud no se puede convertir a una coordenada. Intenta nuevamente. " +
                    $"{elError.Message}",
                    "Error en tipo de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Aqui validamos si la longitud es correcta
            try
            {
                grados = double.Parse(longitudGMS[0]);
                minutos = double.Parse(longitudGMS[1]);
                segundos = double.Parse(longitudGMS[2]);

                if (longitudGMS[3] == "W" || longitudGMS[3] == "E")
                    esLongitudOk = true;
            }
            catch (FormatException elError)
            {
                MessageBox.Show("El dato de longitud no se puede convertir a una coordenada. Intenta nuevamente. " +
                    $"{elError.Message}",
                    "Error en tipo de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (esLatitudOk && esLongitudOk)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Obtiene el objeto Coordenada a partir de valores string ingresados
        /// </summary>
        /// <param name="valorLatitudGMS">El componente Latitud en formato GMS</param>
        /// <param name="valorLongitudGMS">EL componente Longitud en formato GMS</param>
        /// <returns>El objeto Coordenada equivalente</returns>
        private Coordenada ObtieneCoordenadaReal(string valorLatitudGMS, string valorLongitudGMS)
        {
            Coordenada coordenadaResultado = new Coordenada(0, 0);

            char[] separador = { ' ' };
            string[] latitudGMS = valorLatitudGMS.Split(separador);
            string[] longitudGMS = valorLongitudGMS.Split(separador);

            bool datosCorrectos = ValidaDatosGMS(latitudGMS, longitudGMS);

            if (datosCorrectos)
            {
                coordenadaResultado = new Coordenada(
                    new PuntoGMS
                    {
                        Grados = double.Parse(latitudGMS[0]),
                        Minutos = double.Parse(latitudGMS[1]),
                        Segundos = double.Parse(latitudGMS[2]),
                        Orientacion = latitudGMS[3],
                        Tipo = "LAT"
                    },
                    new PuntoGMS
                    {
                        Grados = double.Parse(longitudGMS[0]),
                        Minutos = double.Parse(longitudGMS[1]),
                        Segundos = double.Parse(longitudGMS[2]),
                        Orientacion = longitudGMS[3],
                        Tipo = "LON"
                    }
                );
            }

            return coordenadaResultado;
        }

        /// <summary>
        /// Define el comportamiento del evento asociado al botón de Generación del Detalle de un sismo,
        /// en formato String, Json y XML
        /// </summary>
        private void botonGeneraDetalleSismo_Click(object sender, EventArgs e)
        {
            if (txtIdSismoDetalle.Text != "")
            {
                try
                {
                    int idSismo = int.Parse(txtIdSismoDetalle.Text);
                    Sismo sismoBuscado = AccesoDatos.ObtenerSismo(idSismo);

                    // Si el Sismo viene con el valor predeterminado, no se encontró registro
                    // de lo contrario, vendrá con un valor de id diferente de cero
                    if (sismoBuscado.Id != 0)
                    {
                        //Aqui visualizamos la información en formato texto plano sin estructura
                        txtSismoInfo.Text = sismoBuscado.ToString();

                        //Aqui visualizamos la información en formato JSON
                        txtSismoJson.Text = JsonConvert.SerializeObject(sismoBuscado, Formatting.Indented);

                        //Aqui Visualizamos la información en formato XML

                        var stringwriter = new System.IO.StringWriter();
                        var serializadorXML = new XmlSerializer(sismoBuscado.GetType());
                        serializadorXML.Serialize(stringwriter, sismoBuscado);

                        txtSismoXML.Text = stringwriter.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un sismo asociado al id suministrado.",
                            "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtIdSismoEditar.Text = "";
                        txtSismoInfo.Text = "";
                        txtSismoJson.Text = "";
                        txtSismoXML.Text = "";
                    }
                }
                catch (FormatException error)
                {
                    MessageBox.Show("El Id del sismo debe ser un valor numérico entero \n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtIdSismoDetalle.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el ID del sismo a editar",
                    "Id de Sismo no suministrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Define el comportamiento del evento asociado al botón de Actualizar Sismo
        /// </summary>
        private void btnActualizarSismo_Click(object sender, EventArgs e)
        {
            int idRegion = 0;

            if (comboBoxRegionesEditar.Text != "")
                idRegion = AccesoDatos.ObtieneIdRegion(comboBoxRegionesEditar.Text);

            //Validamos que los campos de Latidud, Longitud, Magnitud, Profundidad y Región no sean nulos
            if (ValidaCamposMinimos() && idRegion != 0)
            {
                try
                {
                    Coordenada coordenadaSismo = ObtieneCoordenadaReal(
                        txtLatitudEditar.Text,
                        txtLongitudEditar.Text);

                    Sismo unSismo = new Sismo(
                    idRegion,                                                   //Region
                    selectorFechaEditar.Value.ToString("dd/MM/yyyy"),           //Fecha
                    selectorHoraEditar.Value.ToString("HH:mm:ss"),              //Hora
                    Math.Round(double.Parse(txtMagnitudEditar.Text), 2),        //Magnitud
                    Math.Round(double.Parse(txtProfundidadEditar.Text), 2),     //Profundidad
                    coordenadaSismo                                             //Coordenada
                    );

                    unSismo.Id = int.Parse(etiquetaIdSismo.Text);

                    AccesoDatos.ActualizarSismo(unSismo);

                    //Despues de agregado a la lista, se actualiza las visualizaciones de datos
                    InicializaVisualizacionDatos();

                    MessageBox.Show("Sismo actualizado exitosamente.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException error)
                {
                    MessageBox.Show("Los campos de magnitud o profundidad deben ser numéricos \n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException errorNulo)
                {
                    MessageBox.Show("El valor de la región no debe ser nulo y debe ser seleccionado de las opciones disponibles \n" +
                        errorNulo.Message,
                        "Error en datos - Región", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos de región, magnitud o profundidad no pueden ser nulos",
                    "Error en datos - nulos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Ocultamos el grupo de controles de edición
            grupoEditarSismo.Visible = false;

            txtIdSismoEditar.Text = "";
            txtIdSismoEditar.Enabled = true;
            botonBuscarSismo.Enabled = true;
        }

        /// <summary>
        /// Define el comportamiento del evento asociado al botón de Cancelar Edición
        /// </summary>
        private void botonCancelarEdicion_Click(object sender, EventArgs e)
        {
            //Ocultamos el grupo de controles de edición
            grupoEditarSismo.Visible = false;

            txtIdSismoEditar.Text = "";
            txtIdSismoEditar.Enabled = true;
            botonBuscarSismo.Enabled = true;
        }

        /// <summary>
        /// Define el comportamiento del evento asociado al botón Buscar Sismo
        /// </summary>
        private void botonBuscarSismo_Click(object sender, EventArgs e)
        {
            if (txtIdSismoEditar.Text != "")
            {
                try
                {
                    int idSismo = int.Parse(txtIdSismoEditar.Text);
                    Sismo sismoBuscado = AccesoDatos.ObtenerSismo(idSismo);

                    // Si el Sismo viene con el valor predeterminado, no se encontró registro
                    // de lo contrario, vendrá con un valor de id diferente de cero
                    if (sismoBuscado.Id != 0)
                    {
                        grupoEditarSismo.Visible = true;

                        comboBoxRegionesEditar.DataSource = null;
                        comboBoxRegionesEditar.DataSource = AccesoDatos.ObtenerRegiones();
                        comboBoxRegionesEditar.DisplayMember = "region";
                        comboBoxRegionesEditar.Text = AccesoDatos.ObtieneNombreRegion(sismoBuscado.Id_Region);

                        etiquetaIdSismo.Text = txtIdSismoEditar.Text;
                        txtMagnitudEditar.Text = sismoBuscado.Magnitud.ToString();
                        txtProfundidadEditar.Text = sismoBuscado.Profundidad.ToString();

                        txtLatitudEditar.Text = sismoBuscado.Coordenada.LatitudGMS.ToString();
                        txtLongitudEditar.Text = sismoBuscado.Coordenada.LongitudGMS.ToString();

                        selectorFechaEditar.Value = ObtieneFechaHora(sismoBuscado.Fecha, "fecha");
                        selectorHoraEditar.Value = ObtieneFechaHora(sismoBuscado.Hora, "hora");

                        // Bloqueamos el campo de Id Sismo para evitar ediciones no controladas
                        txtIdSismoEditar.Enabled = false;
                        txtIdSismoEditar.Text = "";
                        botonBuscarSismo.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un sismo asociado al id suministrado.",
                            "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtIdSismoEditar.Text = "";
                    }
                }
                catch (FormatException error)
                {
                    MessageBox.Show("El Id del sismo debe ser un valor numérico entero \n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtIdSismoEditar.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el ID del sismo a editar",
                    "Id de Sismo no suministrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Define el comportamiento del evento asociado al botón de agregar sismo
        /// </summary>
        private void botonAgregarSismo_Click(object sender, EventArgs e)
        {
            int idRegion = 0;

            if (comboRegionesAgregarSismo.Text != "")
                idRegion = AccesoDatos.ObtieneIdRegion(comboRegionesAgregarSismo.Text);

            //Validamos que los campos de Magnitud, Profundidad y Región no sean nulos
            if (ValidaCamposMinimos() && idRegion != 0)
            {
                try
                {
                    Coordenada coordenadaSismo = ObtieneCoordenadaReal(
                        txtLatitud.Text,
                        txtLongitud.Text);

                    Sismo unSismo = new Sismo(
                        idRegion,                                               //Region
                        dtpFecha.Value.ToString("dd/MM/yyyy"),                  //Fecha
                        dtpHora.Value.ToString("HH:mm:ss"),                     //Hora
                        Math.Round(double.Parse(txtMagnitud.Text), 2),          //Magnitud
                        Math.Round(double.Parse(txtProfundidad.Text), 2),       //Profundidad
                        coordenadaSismo                                         //Coordenada
                    );

                    AccesoDatos.GuardarSismo(unSismo);

                    //Despues de agregado a la lista, se actualiza las visualizaciones de datos
                    InicializaVisualizacionDatos();

                    MessageBox.Show("Sismo registrado exitosamente.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException error)
                {
                    MessageBox.Show("Los campos de magnitud y profundidad deben ser numéricos \n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException errorNulo)
                {
                    MessageBox.Show("El valor de la región no debe ser nulo y debe ser seleccionado de las opciones disponibles \n" +
                        errorNulo.Message,
                        "Error en datos - Región", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (idRegion == 0)
                {
                    MessageBox.Show("La región indicada no se encuentra registrada.",
                        "Error en región indicada",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Los campos de latitud, longitud, magnitud o profundidad no pueden ser nulos",
                        "Error en datos - nulos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Reiniciamos los controles para registrar un nuevo valor
            comboRegionesAgregarSismo.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

            txtLatitud.Text = "";
            txtLongitud.Text = "";
            txtProfundidad.Text = "";
            txtMagnitud.Text = "";
        }

        /// <summary>
        /// Define el comportamiento del evento asociado al botón de borrar sismo
        /// </summary>
        private void btnBorrarSismo_Click(object sender, EventArgs e)
        {
            if (txtIdSismoBorrar.Text != "")
            {
                try
                {
                    int idSismo = int.Parse(txtIdSismoBorrar.Text);
                    bool respuesta = AccesoDatos.EliminarSismo(idSismo);

                    if (respuesta)
                    {
                        //Despues de agregado a la lista, se actualiza las visualizaciones de datos
                        InicializaVisualizacionDatos();

                        //Y se borra el valor ingresado
                        txtIdSismoBorrar.Text = "";

                        MessageBox.Show("Sismo eliminado exitosamente.",
                            "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un sismo asociado al id suministrado.",
                            "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException error)
                {
                    MessageBox.Show("El Id del sismo debe ser un valor numérico entero \n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el ID del sismo a eliminar",
                    "Id de Sismo no suministrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}