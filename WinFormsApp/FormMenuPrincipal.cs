using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        public Form CurrentForm { get; set; }

        private void AbrirFormPrincipal(Form menuitem) 
        {
            if (CurrentForm != null) 
            {
                CurrentForm.Close();
            }

            CurrentForm = menuitem;

            menuitem.TopLevel = false;
            menuitem.FormBorderStyle = FormBorderStyle.None;
            menuitem.Dock = DockStyle.Fill;

            panelMenuPrincipal.Controls.Add(menuitem);
            panelMenuPrincipal.Tag = menuitem;

            menuitem.BringToFront();
            menuitem.Show();

            MenuLabelPrincipal.Text = menuitem.Text;
        
        
        
        }

        private void MenuMarcaVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new FormPacientes());
        }

        private void itemVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new FormDoctores());
        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void itemServicios_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new FormServicios());
        }

        private void itemCitas_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new FormCitas());
        }
    }
}
