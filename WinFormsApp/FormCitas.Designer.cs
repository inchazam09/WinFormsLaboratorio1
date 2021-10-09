
namespace WinFormsApp
{
    partial class FormCitas
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtTipoServicio = new System.Windows.Forms.TextBox();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.labelTipoServicio = new System.Windows.Forms.Label();
            this.txtCitaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridViewMarcaVehiculo = new System.Windows.Forms.DataGridView();
            this.CitaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMarcaVehiculo)).BeginInit();
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
            this.BtnEliminar.Location = new System.Drawing.Point(581, 483);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(101, 32);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
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
            this.BtnEditar.Location = new System.Drawing.Point(484, 483);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(82, 32);
            this.BtnEditar.TabIndex = 8;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
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
            this.BtnNuevo.Location = new System.Drawing.Point(384, 483);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(86, 32);
            this.BtnNuevo.TabIndex = 7;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.cmbHora);
            this.panelForm.Controls.Add(this.textBox1);
            this.panelForm.Controls.Add(this.dateTimePicker1);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.BtnGuardar);
            this.panelForm.Controls.Add(this.txtTipoServicio);
            this.panelForm.Controls.Add(this.labelPaciente);
            this.panelForm.Controls.Add(this.labelTipoServicio);
            this.panelForm.Controls.Add(this.txtCitaId);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Location = new System.Drawing.Point(620, 18);
            this.panelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(456, 399);
            this.panelForm.TabIndex = 6;
            this.panelForm.Visible = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 32;
            this.BtnGuardar.Location = new System.Drawing.Point(225, 333);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 34);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtTipoServicio
            // 
            this.txtTipoServicio.Location = new System.Drawing.Point(159, 90);
            this.txtTipoServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipoServicio.Name = "txtTipoServicio";
            this.txtTipoServicio.Size = new System.Drawing.Size(265, 23);
            this.txtTipoServicio.TabIndex = 4;
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(35, 145);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(55, 15);
            this.labelPaciente.TabIndex = 3;
            this.labelPaciente.Text = "Paciente:";
            // 
            // labelTipoServicio
            // 
            this.labelTipoServicio.AutoSize = true;
            this.labelTipoServicio.Location = new System.Drawing.Point(35, 95);
            this.labelTipoServicio.Name = "labelTipoServicio";
            this.labelTipoServicio.Size = new System.Drawing.Size(93, 15);
            this.labelTipoServicio.TabIndex = 2;
            this.labelTipoServicio.Text = "Tipo de Servicio:";
            // 
            // txtCitaId
            // 
            this.txtCitaId.Location = new System.Drawing.Point(389, 10);
            this.txtCitaId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCitaId.Name = "txtCitaId";
            this.txtCitaId.Size = new System.Drawing.Size(64, 23);
            this.txtCitaId.TabIndex = 1;
            this.txtCitaId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario";
            // 
            // GridViewMarcaVehiculo
            // 
            this.GridViewMarcaVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMarcaVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CitaId,
            this.TipoServicio,
            this.Paciente,
            this.Fecha,
            this.Hora});
            this.GridViewMarcaVehiculo.Location = new System.Drawing.Point(12, 11);
            this.GridViewMarcaVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewMarcaVehiculo.Name = "GridViewMarcaVehiculo";
            this.GridViewMarcaVehiculo.ReadOnly = true;
            this.GridViewMarcaVehiculo.RowHeadersWidth = 51;
            this.GridViewMarcaVehiculo.RowTemplate.Height = 29;
            this.GridViewMarcaVehiculo.Size = new System.Drawing.Size(602, 409);
            this.GridViewMarcaVehiculo.TabIndex = 5;
            // 
            // CitaId
            // 
            this.CitaId.DataPropertyName = "CitaId";
            this.CitaId.HeaderText = "Id";
            this.CitaId.MinimumWidth = 6;
            this.CitaId.Name = "CitaId";
            this.CitaId.ReadOnly = true;
            this.CitaId.Width = 125;
            // 
            // TipoServicio
            // 
            this.TipoServicio.DataPropertyName = "TipoServicio";
            this.TipoServicio.HeaderText = "TipoServicio";
            this.TipoServicio.MinimumWidth = 6;
            this.TipoServicio.Name = "TipoServicio";
            this.TipoServicio.ReadOnly = true;
            this.TipoServicio.Width = 125;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "Paciente";
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.MinimumWidth = 6;
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            this.Paciente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Paciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Paciente.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Hora";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "Hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 23);
            this.textBox1.TabIndex = 10;
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "5:00 am ",
            "6:00 am",
            "7:00 am",
            "8:00 am",
            "9:00 am",
            "10:00 am",
            "11:00 am",
            "12:00 pm",
            "01:00 pm",
            "02:00 pm",
            "03:00 pm",
            "04:00 pm",
            "05:00 pm",
            "06:00 pm",
            "07:00 pm"});
            this.cmbHora.Location = new System.Drawing.Point(159, 245);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(66, 23);
            this.cmbHora.TabIndex = 11;
            // 
            // FormCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 526);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.GridViewMarcaVehiculo);
            this.Name = "FormCitas";
            this.Text = "FormCitas";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMarcaVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox txtTipoServicio;
        private System.Windows.Forms.Label labelPaciente;
        private System.Windows.Forms.Label labelTipoServicio;
        private System.Windows.Forms.TextBox txtCitaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridViewMarcaVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
    }
}