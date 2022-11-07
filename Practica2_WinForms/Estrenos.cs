using System.Data;

namespace Practica2_WinForms
{
    public partial class Estrenos : Form
    {
        public Estrenos()
        {
            InitializeComponent();
        }

        #region Enumerado

        public enum ModoEdicion
        {
            lectura,
            crear,
            modificar
        }

        public ModoEdicion modoEdicion;

        #endregion

        #region Eventos
        /// <summary>
        /// Evento Load del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Estrenos_Load(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.lectura;
            ModoPantallaLectura();

            // Cargamos los items de bbdd.
            CargarYConfigurarGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento KeyPress para controlar que no se puedan escribir caracteres en el numero de temporadas.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void txtTemporadas_TextChanged(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtTemporadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTemporadas_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaEstreno_ValueChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Evento del botón añadir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAñadir_Click_1(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.crear;
            ModoPantallaEdicion();
        }

        /// <summary>
        /// Evento del botón eliminar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            bool correcto = false;
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar esta serie?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Serie s = ObtenerInformacion();
                correcto = Repositorio.EliminarSerie(s);

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acción se ha realizado correctamente.");
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acción, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }
        }


        /// <summary>
        /// Evento del botón Modificar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

            modoEdicion = ModoEdicion.modificar;
            ModoPantallaEdicion();
        }

        /// <summary>
        /// Evento click del botón guardar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            bool correcto = false;

            if (InformacionObligatoriaCumplimentada())
            {
                // Rellenamos la entidad con la información
                Serie s = ObtenerInformacion();

                switch (modoEdicion)
                {
                    case ModoEdicion.crear:
                        correcto = Repositorio.CrearSerie(s);
                        break;
                    case ModoEdicion.modificar:
                        correcto = Repositorio.ModificarSerie(s);
                        break;
                }

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acción se ha realizado correctamente.");
                    modoEdicion = ModoEdicion.lectura;
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acción, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }
            else
            {
                MessageBox.Show("Los campos Nombre y Temporadas son obligatorios.");
            }
        }

        /// <summary>
        /// Evento click del botón Cancelar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea salir de la edición?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                modoEdicion = ModoEdicion.lectura;
                ModoPantallaLectura();

                // Si tenemos una fila seleccionada en el grid:
                if (dgvListado.SelectedRows.Count == 1)
                {
                    // Recargamos su información en el formulario
                    CargarInfoFilaSeleccionadaFormulario(dgvListado.SelectedRows[0]);
                }
            }
        }


        /// <summary>
        /// Evento click de la celda.
        /// Cuando se hace click en una celda se selecciona la fila entera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListado.Rows[e.RowIndex].Selected = true;
        }


        /// <summary>
        /// Evento para cuando una fila cambia de estado en el grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListado_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Para cualquier operación que no sea que ha cambiado la selección de la fila, nos salimos
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // Obtenemos la fila seleccionada
            DataGridViewRow filaSeleccionada = e.Row;
            CargarInfoFilaSeleccionadaFormulario(filaSeleccionada);

        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método para establecer el modo de la pantalla a edición.
        /// </summary>
        public void ModoPantallaEdicion()
        {
            // Limpiamos sólo si es modo creación, si es modo edición dejamos los valores:
            if (modoEdicion == ModoEdicion.crear)
            {
                txtNombre.Text = "";
                txtTemporadas.Text = "";
                dtpFechaEstreno.Value = DateTime.Now; 
                txtId.Text = "";

            }

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Enabled = true;
            txtTemporadas.Enabled = true;
            dtpFechaEstreno.Enabled = true;
            txtId.Enabled = false;

            btnAñadir.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            dgvListado.Enabled = false;
        }

        /// <summary>
        /// Método para establecer el modo de la pantalla a lectura.
        /// </summary>
        public void ModoPantallaLectura()
        {
            txtNombre.Text = "";
            txtTemporadas.Text = "";
            dtpFechaEstreno.Value = DateTime.Now; 
            txtId.Text = "";

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAñadir.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

            txtNombre.Enabled = false;
            txtTemporadas.Enabled = false;
            dtpFechaEstreno.Enabled = false;
            txtId.Enabled = false;

            dgvListado.Enabled = true;
        }

        /// <summary>
        /// Método para obtener la información del formulario.
        /// </summary>
        /// <returns>Serie con la información del formulario.</returns>
        public Serie ObtenerInformacion()
        {
            Serie s = new Serie();

            s.nombre = txtNombre.Text;
            s.temporadas = Convert.ToInt32(txtTemporadas.Text);
            s.fechaEstreno = dtpFechaEstreno.Value;
            

            if (!String.IsNullOrEmpty(txtId.Text))
            {
                s.Id = Convert.ToInt32(txtId.Text);
            }

            return s;
        }

        /// <summary>
        /// Método que carga y configura el grid.
        /// </summary>
        /// <param name="Estrenos">DataTable con la info de los estrenos</param>
        public void CargarYConfigurarGrid()
        {
            DataSet ds = Repositorio.ObtenerSeries();
            dgvListado.DataSource = ds.Tables[0];

            // Tamaños columnas
            dgvListado.Columns["SerieId"].Width = 40;
            dgvListado.Columns["Nombre"].Width = 200;
            dgvListado.Columns["Temporadas"].Width = 150;
            dgvListado.Columns["FechaEstreno"].Width = 150;


            // Renombrado columnas
            dgvListado.Columns["SerieId"].HeaderText = "Id";
            dgvListado.Columns["FechaEstreno"].HeaderText = "Fecha Estreno";  


            // Formato fecha en español
            dgvListado.Columns["FechaEstreno"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Seleccionamos la primera fila del grid si existe
            SeleccionarPrimeraFilaGrid();

        }

        /// <summary>
        /// Método que selecciona la primera fila del grid si existe.
        /// </summary>
        public void SeleccionarPrimeraFilaGrid()
        {
            // Si hay alguna fila, seleccionamos la primera
            if (dgvListado.Rows.Count > 0)
            {
                dgvListado.Rows[0].Selected = true;
            }
        }

        /// <summary>
        /// Método que carga la información de la fila seleccionada en los controles.
        /// </summary>
        /// <param name="filaSeleccionada"></param>
        public void CargarInfoFilaSeleccionadaFormulario(DataGridViewRow filaSeleccionada)
        {
            txtId.Text = filaSeleccionada.Cells["SerieId"].Value.ToString();
            txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            txtTemporadas.Text = filaSeleccionada.Cells["Temporadas"].Value.ToString();
            dtpFechaEstreno.Value = (DateTime)filaSeleccionada.Cells["FechaEstreno"].Value;

        }

        /// <summary>
        /// Función que nos indica si la información obligatoria está cumplimentada o no.
        /// </summary>
        /// <returns></returns>
        public bool InformacionObligatoriaCumplimentada()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtTemporadas.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }




        #endregion

        
    }
}