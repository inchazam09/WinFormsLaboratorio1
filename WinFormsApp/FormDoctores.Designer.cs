
namespace WinFormsApp
{
    partial class FormDoctores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.GridViewDoctores = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFormDoctores = new System.Windows.Forms.Panel();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtTelefono = new System.Windows.Forms.RichTextBox();
            this.Telefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.RichTextBox();
            this.lbDefectos = new System.Windows.Forms.Label();
            this.lbTieneDefectos = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.labelMarcaVehiculo = new System.Windows.Forms.Label();
            this.txtDoctoresId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoctores)).BeginInit();
            this.panelFormDoctores.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 32;
            this.BtnEliminar.Location = new System.Drawing.Point(226, 504);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(101, 32);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 32;
            this.BtnEditar.Location = new System.Drawing.Point(129, 504);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(82, 32);
            this.BtnEditar.TabIndex = 8;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnNuevo.IconColor = System.Drawing.Color.White;
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevo.IconSize = 32;
            this.BtnNuevo.Location = new System.Drawing.Point(29, 504);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(86, 32);
            this.BtnNuevo.TabIndex = 7;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // GridViewDoctores
            // 
            this.GridViewDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDoctores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellidos,
            this.Cedula,
            this.Especialidad,
            this.Direccion,
            this.dataGridViewTextBoxColumn1});
            this.GridViewDoctores.Location = new System.Drawing.Point(0, -3);
            this.GridViewDoctores.Name = "GridViewDoctores";
            this.GridViewDoctores.ReadOnly = true;
            this.GridViewDoctores.RowTemplate.Height = 25;
            this.GridViewDoctores.Size = new System.Drawing.Size(744, 455);
            this.GridViewDoctores.TabIndex = 34;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "DoctoresId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "Especialidad";
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Especialidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn1.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // panelFormDoctores
            // 
            this.panelFormDoctores.Controls.Add(this.cmbEspecialidad);
            this.panelFormDoctores.Controls.Add(this.txtNombre);
            this.panelFormDoctores.Controls.Add(this.btnGuardar);
            this.panelFormDoctores.Controls.Add(this.txtTelefono);
            this.panelFormDoctores.Controls.Add(this.Telefono);
            this.panelFormDoctores.Controls.Add(this.txtDireccion);
            this.panelFormDoctores.Controls.Add(this.lbDefectos);
            this.panelFormDoctores.Controls.Add(this.lbTieneDefectos);
            this.panelFormDoctores.Controls.Add(this.txtCedula);
            this.panelFormDoctores.Controls.Add(this.txtApellidos);
            this.panelFormDoctores.Controls.Add(this.lbModelo);
            this.panelFormDoctores.Controls.Add(this.lbMatricula);
            this.panelFormDoctores.Controls.Add(this.labelMarcaVehiculo);
            this.panelFormDoctores.Controls.Add(this.txtDoctoresId);
            this.panelFormDoctores.Controls.Add(this.label1);
            this.panelFormDoctores.Location = new System.Drawing.Point(764, 11);
            this.panelFormDoctores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFormDoctores.Name = "panelFormDoctores";
            this.panelFormDoctores.Size = new System.Drawing.Size(442, 455);
            this.panelFormDoctores.TabIndex = 33;
            this.panelFormDoctores.Visible = false;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Oftalmología ",
            "Obstetricia ",
            "Dermatología"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(113, 191);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 23);
            this.cmbEspecialidad.TabIndex = 29;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 56);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(296, 23);
            this.txtNombre.TabIndex = 28;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 32;
            this.btnGuardar.Location = new System.Drawing.Point(185, 355);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 34);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(110, 291);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(296, 23);
            this.txtTelefono.TabIndex = 25;
            this.txtTelefono.Text = "";
            this.txtTelefono.Visible = false;
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(22, 299);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(55, 15);
            this.Telefono.TabIndex = 20;
            this.Telefono.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(110, 242);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(296, 23);
            this.txtDireccion.TabIndex = 19;
            this.txtDireccion.Text = "";
            this.txtDireccion.Visible = false;
            // 
            // lbDefectos
            // 
            this.lbDefectos.AutoSize = true;
            this.lbDefectos.Location = new System.Drawing.Point(22, 250);
            this.lbDefectos.Name = "lbDefectos";
            this.lbDefectos.Size = new System.Drawing.Size(57, 15);
            this.lbDefectos.TabIndex = 18;
            this.lbDefectos.Text = "Direccion";
            this.lbDefectos.Visible = false;
            // 
            // lbTieneDefectos
            // 
            this.lbTieneDefectos.AutoSize = true;
            this.lbTieneDefectos.Location = new System.Drawing.Point(22, 200);
            this.lbTieneDefectos.Name = "lbTieneDefectos";
            this.lbTieneDefectos.Size = new System.Drawing.Size(72, 15);
            this.lbTieneDefectos.TabIndex = 16;
            this.lbTieneDefectos.Text = "Especialidad";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(113, 149);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(293, 23);
            this.txtCedula.TabIndex = 12;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(110, 106);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(296, 23);
            this.txtApellidos.TabIndex = 11;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(19, 152);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(50, 15);
            this.lbModelo.TabIndex = 10;
            this.lbModelo.Text = "Cedula :";
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Location = new System.Drawing.Point(22, 109);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(62, 15);
            this.lbMatricula.TabIndex = 8;
            this.lbMatricula.Text = "Apellidos :";
            // 
            // labelMarcaVehiculo
            // 
            this.labelMarcaVehiculo.AutoSize = true;
            this.labelMarcaVehiculo.Location = new System.Drawing.Point(16, 56);
            this.labelMarcaVehiculo.Name = "labelMarcaVehiculo";
            this.labelMarcaVehiculo.Size = new System.Drawing.Size(54, 15);
            this.labelMarcaVehiculo.TabIndex = 2;
            this.labelMarcaVehiculo.Text = "Nombre:";
            // 
            // txtDoctoresId
            // 
            this.txtDoctoresId.Location = new System.Drawing.Point(387, 2);
            this.txtDoctoresId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoctoresId.Name = "txtDoctoresId";
            this.txtDoctoresId.Size = new System.Drawing.Size(52, 23);
            this.txtDoctoresId.TabIndex = 1;
            this.txtDoctoresId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario";
            // 
            // FormDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 552);
            this.Controls.Add(this.GridViewDoctores);
            this.Controls.Add(this.panelFormDoctores);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDoctores";
            this.Text = "Vehiculo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDoctores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoctores)).EndInit();
            this.panelFormDoctores.ResumeLayout(false);
            this.panelFormDoctores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private System.Windows.Forms.DataGridView GridViewDoctores;
        private System.Windows.Forms.Panel panelFormDoctores;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.RichTextBox txtTelefono;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.RichTextBox txtDireccion;
        private System.Windows.Forms.Label lbDefectos;
        private System.Windows.Forms.Label lbTieneDefectos;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.Label labelMarcaVehiculo;
        private System.Windows.Forms.TextBox txtDoctoresId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewComboBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
    }
}