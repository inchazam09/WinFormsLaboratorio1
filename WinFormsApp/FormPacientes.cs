using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace WinFormsApp
{
    public partial class FormPacientes : Form
    {
        public FormPacientes()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewPacientes.AutoGenerateColumns = false;
                GridViewPacientes.DataSource = IApp.PacientesService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        
        }

        public void LimpiarDatos() 
        {
            
            txtPacientesId.Text = null;
            txtNombre.Text = null;
            txtApellidos.Text = null;
            txtCedula.Text = null;
            cmbNacionalidad.SelectedIndex = -1;
            txtEdad.Text = null;
            txtDireccion.Text = null;
            txtTelefono.Text = null;
            txtEnfermedades.Text = null;
            txtDireccion.Text = null;
            chckAlergias.Checked = true;
        
        }

        

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            panelForm.Visible = true;
        }

        public int? GetSelectedRowGrid() 
        {
            if (GridViewPacientes.SelectedRows.Count > 0)
            {
                var row = GridViewPacientes.SelectedRows[0];
                return Convert.ToInt32(row.Cells["MarcaVehiculoId"].Value);
            }
            else
            {
                return null;
            }    
        
        
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();

                var IdSelected = GetSelectedRowGrid();

                if (IdSelected.HasValue)
                {
                    var result = IApp.PacientesService.GetById(new PacientesEntity()
                    { PacientesId = IdSelected });

                    txtPacientesId.Text = result.PacientesId.ToString();
                    txtNombre.Text = result.Nombre;
                    txtApellidos.Text = result.Apellidos;
                    cmbNacionalidad.SelectedValue = result.Nacionalidad;
                    txtCedula.Text = result.Cedula;
                    txtEdad.Text = result.Edad;
                    txtEnfermedades.Text = result.Enfermedades;
                    txtDireccion.Text = result.Direccion;
                    txtTelefono.Text = result.Telefono;
                    chckAlergias.Checked = result.Alergias;
                    //chckEstado.Checked = result.Estado;
                    panelForm.Visible = true;
                }
                else 
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
                panelForm.Visible = false;

                var IdSelected = GetSelectedRowGrid();

                if (IdSelected.HasValue)
                {
                    var result = IApp.PacientesService.Delete(new PacientesEntity()
                    { PacientesId = IdSelected });

                    if (result.CodeError == 0)
                    {
                        MessageBox.Show("El registro se elimino correctamente");
                        CargarDatos();
                    }
                    else
                    {
                        throw new Exception(result.MsgError);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public bool ValidacionFormulario()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo Descripción es obligatorio");
                return false;
            }

            return true;       
        
        
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionFormulario())
                {
                    var PacientesId = string.IsNullOrEmpty(txtPacientesId.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(txtPacientesId.Text);//Editar

                    var entity = new PacientesEntity
                    { 
                        PacientesId= PacientesId,
                        Nombre=txtNombre.Text,
                        Apellidos=txtApellidos.Text,
                        Nacionalidad= Convert.ToInt32(cmbNacionalidad.SelectedValue),
                        Cedula = txtCedula.Text,
                        Edad =  txtEdad.Text,
                        Enfermedades= txtEnfermedades.Text,
                        Direccion= txtDireccion.Text,
                        Telefono=txtTelefono.Text,
                        Estado = chckAlergias.Checked
                      // 
                    };

                    var result = new DBEntity();
                    if (entity.PacientesId.HasValue)
                    {
                        //Actualización
                        result = IApp.PacientesService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                    }
                    else
                    {
                        result = IApp.PacientesService.Create(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se insertó correctamente");

                    }

                    if (result.CodeError != 0) throw new Exception(result.MsgError);

                    LimpiarDatos();
                    CargarDatos();
                    panelForm.Visible = false;         

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridViewPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
