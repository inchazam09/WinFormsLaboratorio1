
namespace WinFormsApp
{
    partial class FormMenuPrincipal
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
            this.panelMenuIzquierda = new System.Windows.Forms.Panel();
            this.itemDoctores = new FontAwesome.Sharp.IconButton();
            this.MenuPacientes = new FontAwesome.Sharp.IconButton();
            this.panelMenuLogo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.MenuLabelPrincipal = new System.Windows.Forms.Label();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.itemCitas = new FontAwesome.Sharp.IconButton();
            this.itemServicios = new FontAwesome.Sharp.IconButton();
            this.panelMenuIzquierda.SuspendLayout();
            this.panelMenuLogo.SuspendLayout();
            this.panelMenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuIzquierda
            // 
            this.panelMenuIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.panelMenuIzquierda.Controls.Add(this.itemServicios);
            this.panelMenuIzquierda.Controls.Add(this.itemCitas);
            this.panelMenuIzquierda.Controls.Add(this.itemDoctores);
            this.panelMenuIzquierda.Controls.Add(this.MenuPacientes);
            this.panelMenuIzquierda.Controls.Add(this.panelMenuLogo);
            this.panelMenuIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIzquierda.Location = new System.Drawing.Point(0, 0);
            this.panelMenuIzquierda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuIzquierda.Name = "panelMenuIzquierda";
            this.panelMenuIzquierda.Size = new System.Drawing.Size(192, 562);
            this.panelMenuIzquierda.TabIndex = 0;
            // 
            // itemDoctores
            // 
            this.itemDoctores.FlatAppearance.BorderSize = 0;
            this.itemDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemDoctores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.itemDoctores.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.itemDoctores.IconColor = System.Drawing.Color.LightBlue;
            this.itemDoctores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemDoctores.Location = new System.Drawing.Point(0, 135);
            this.itemDoctores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemDoctores.Name = "itemDoctores";
            this.itemDoctores.Size = new System.Drawing.Size(161, 44);
            this.itemDoctores.TabIndex = 2;
            this.itemDoctores.Text = "Modulo de Doctores";
            this.itemDoctores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.itemDoctores.UseVisualStyleBackColor = true;
            this.itemDoctores.Click += new System.EventHandler(this.itemVehiculo_Click);
            // 
            // MenuPacientes
            // 
            this.MenuPacientes.FlatAppearance.BorderSize = 0;
            this.MenuPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuPacientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuPacientes.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.MenuPacientes.IconColor = System.Drawing.Color.LightBlue;
            this.MenuPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuPacientes.Location = new System.Drawing.Point(0, 87);
            this.MenuPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPacientes.Name = "MenuPacientes";
            this.MenuPacientes.Size = new System.Drawing.Size(161, 44);
            this.MenuPacientes.TabIndex = 1;
            this.MenuPacientes.Text = "Pacientes";
            this.MenuPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuPacientes.UseVisualStyleBackColor = true;
            this.MenuPacientes.Click += new System.EventHandler(this.MenuMarcaVehiculo_Click);
            // 
            // panelMenuLogo
            // 
            this.panelMenuLogo.Controls.Add(this.iconButton1);
            this.panelMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuLogo.Name = "panelMenuLogo";
            this.panelMenuLogo.Size = new System.Drawing.Size(192, 69);
            this.panelMenuLogo.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconButton1.IconColor = System.Drawing.Color.LightBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(192, 65);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Agencia";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelMenuTop
            // 
            this.panelMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.panelMenuTop.Controls.Add(this.MenuLabelPrincipal);
            this.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTop.Location = new System.Drawing.Point(192, 0);
            this.panelMenuTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuTop.Name = "panelMenuTop";
            this.panelMenuTop.Size = new System.Drawing.Size(1007, 69);
            this.panelMenuTop.TabIndex = 1;
            // 
            // MenuLabelPrincipal
            // 
            this.MenuLabelPrincipal.AutoSize = true;
            this.MenuLabelPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuLabelPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuLabelPrincipal.Location = new System.Drawing.Point(25, 17);
            this.MenuLabelPrincipal.Name = "MenuLabelPrincipal";
            this.MenuLabelPrincipal.Size = new System.Drawing.Size(52, 21);
            this.MenuLabelPrincipal.TabIndex = 0;
            this.MenuLabelPrincipal.Text = "Home";
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuPrincipal.Location = new System.Drawing.Point(192, 69);
            this.panelMenuPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(1007, 493);
            this.panelMenuPrincipal.TabIndex = 2;
            // 
            // itemCitas
            // 
            this.itemCitas.FlatAppearance.BorderSize = 0;
            this.itemCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemCitas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.itemCitas.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.itemCitas.IconColor = System.Drawing.Color.LightBlue;
            this.itemCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemCitas.Location = new System.Drawing.Point(3, 231);
            this.itemCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemCitas.Name = "itemCitas";
            this.itemCitas.Size = new System.Drawing.Size(161, 44);
            this.itemCitas.TabIndex = 3;
            this.itemCitas.Text = "Ver Listado de Citas";
            this.itemCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.itemCitas.UseVisualStyleBackColor = true;
            this.itemCitas.Click += new System.EventHandler(this.itemCitas_Click);
            // 
            // itemServicios
            // 
            this.itemServicios.FlatAppearance.BorderSize = 0;
            this.itemServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemServicios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.itemServicios.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.itemServicios.IconColor = System.Drawing.Color.LightBlue;
            this.itemServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemServicios.Location = new System.Drawing.Point(3, 183);
            this.itemServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemServicios.Name = "itemServicios";
            this.itemServicios.Size = new System.Drawing.Size(161, 44);
            this.itemServicios.TabIndex = 4;
            this.itemServicios.Text = "Modulo de Servicios";
            this.itemServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.itemServicios.UseVisualStyleBackColor = true;
            this.itemServicios.Click += new System.EventHandler(this.itemServicios_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 562);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Controls.Add(this.panelMenuTop);
            this.Controls.Add(this.panelMenuIzquierda);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenuPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuPrincipal_FormClosing);
            this.panelMenuIzquierda.ResumeLayout(false);
            this.panelMenuLogo.ResumeLayout(false);
            this.panelMenuTop.ResumeLayout(false);
            this.panelMenuTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuIzquierda;
        private System.Windows.Forms.Panel panelMenuLogo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelMenuTop;
        private System.Windows.Forms.Label MenuLabelPrincipal;
        private System.Windows.Forms.Panel panelMenuPrincipal;
        private FontAwesome.Sharp.IconButton MenuPacientes;
        private FontAwesome.Sharp.IconButton itemDoctores;
        private FontAwesome.Sharp.IconButton itemServicios;
        private FontAwesome.Sharp.IconButton itemCitas;
    }
}