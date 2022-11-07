namespace Practica2_WinForms
{
    partial class Estrenos
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.gbInfoEstrenos = new System.Windows.Forms.GroupBox();
            this.txtTemporadas = new System.Windows.Forms.TextBox();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblTemporadas = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gbInfoEstrenos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(13, 313);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersWidth = 62;
            this.dgvListado.RowTemplate.Height = 25;
            this.dgvListado.Size = new System.Drawing.Size(1085, 253);
            this.dgvListado.TabIndex = 7;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(915, 256);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 38);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(786, 256);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 38);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(293, 256);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 38);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(158, 256);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 38);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(26, 256);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(107, 38);
            this.btnAñadir.TabIndex = 12;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click_1);
            // 
            // gbInfoEstrenos
            // 
            this.gbInfoEstrenos.Controls.Add(this.txtTemporadas);
            this.gbInfoEstrenos.Controls.Add(this.dtpFechaEstreno);
            this.gbInfoEstrenos.Controls.Add(this.txtNombre);
            this.gbInfoEstrenos.Controls.Add(this.txtId);
            this.gbInfoEstrenos.Controls.Add(this.lblTemporadas);
            this.gbInfoEstrenos.Controls.Add(this.lblFechaEstreno);
            this.gbInfoEstrenos.Controls.Add(this.lblNombre);
            this.gbInfoEstrenos.Controls.Add(this.lblId);
            this.gbInfoEstrenos.Location = new System.Drawing.Point(26, 12);
            this.gbInfoEstrenos.Name = "gbInfoEstrenos";
            this.gbInfoEstrenos.Size = new System.Drawing.Size(996, 217);
            this.gbInfoEstrenos.TabIndex = 17;
            this.gbInfoEstrenos.TabStop = false;
            this.gbInfoEstrenos.Text = "Estrenos:";
            // 
            // txtTemporadas
            // 
            this.txtTemporadas.Location = new System.Drawing.Point(186, 131);
            this.txtTemporadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTemporadas.MaxLength = 9;
            this.txtTemporadas.Name = "txtTemporadas";
            this.txtTemporadas.Size = new System.Drawing.Size(205, 31);
            this.txtTemporadas.TabIndex = 20;
            this.txtTemporadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTemporadas.TextChanged += new System.EventHandler(this.txtTemporadas_TextChanged);
            this.txtTemporadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemporadas_KeyPress);
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstreno.Location = new System.Drawing.Point(186, 178);
            this.dtpFechaEstreno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(205, 31);
            this.dtpFechaEstreno.TabIndex = 18;
            this.dtpFechaEstreno.ValueChanged += new System.EventHandler(this.dtpFechaEstreno_ValueChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 31);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(186, 37);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(74, 31);
            this.txtId.TabIndex = 16;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblTemporadas
            // 
            this.lblTemporadas.AutoSize = true;
            this.lblTemporadas.Location = new System.Drawing.Point(32, 134);
            this.lblTemporadas.Name = "lblTemporadas";
            this.lblTemporadas.Size = new System.Drawing.Size(113, 25);
            this.lblTemporadas.TabIndex = 3;
            this.lblTemporadas.Text = "Temporadas:";
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(32, 178);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(125, 25);
            this.lblFechaEstreno.TabIndex = 2;
            this.lblFechaEstreno.Text = "Fecha Estreno:";
            this.lblFechaEstreno.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 80);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // Estrenos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 580);
            this.Controls.Add(this.gbInfoEstrenos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dgvListado);
            this.Name = "Estrenos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Estrenos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gbInfoEstrenos.ResumeLayout(false);
            this.gbInfoEstrenos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvListado;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAñadir;
        private GroupBox gbInfoEstrenos;
        private Label lblTemporadas;
        private Label lblFechaEstreno;
        private Label lblNombre;
        private Label lblId;
        private DateTimePicker dtpFechaEstreno;
        private TextBox txtNombre;
        private TextBox txtId;
        private TextBox txtTemporadas;
    }


}