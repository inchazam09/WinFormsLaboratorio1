using Entity;
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
    public partial class FormDoctores : Form
    {
        public FormDoctores()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewDoctores.AutoGenerateColumns = false;
                GridViewDoctores.DataSource = IApp.DoctoresService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        public void LimpiarDatos()
        {
            txtDoctoresId.Text = null;
            txtNombre.Text = null;
            txtApellidos.Text = null;
            txtCedula.Text = null;
            cmbEspecialidad.SelectedIndex = -1;
            txtDireccion.Text = null;
            txtTelefono.Text = null;

        }

        public int? GetSelectedRowGrid()
        {
            if (GridViewDoctores.SelectedRows.Count > 0)
            
            {
                var row = GridViewDoctores.SelectedRows[0];
                return Convert.ToInt32(row.Cells["DoctoresId"].Value);
            }
            else
            {
                return null;
            }


        }

        public bool ValidacionFormulario()
        {

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio");
                return false;
            }


            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("El campo Apellidos es obligatorio");
                return false;
            }


            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("El campo Modelo es obligatorio");
                return false;
            }

            if (string.IsNullOrEmpty(cmbEspecialidad.SelectedValue?.ToString()))
            {
                MessageBox.Show("El campo Especialidad es obligatorio");
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("El campo Modelo es obligatorio");
                return false;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("El campo Telefono es obligatorio");
                return false;
            }

            return true;


        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            panelFormDoctores.Visible = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();

                var IdSelected = GetSelectedRowGrid();

                if (IdSelected.HasValue)
                {
                    var result = IApp.DoctoresService.GetById(new DoctoresEntity()
                    { DoctoresId = IdSelected });

                    txtDoctoresId.Text = result.DoctoresId.ToString();
                    
                    txtNombre.Text = result.Nombre;
                    txtApellidos.Text = result.Apellidos;
                    txtCedula.Text = result.Cedula;
                    cmbEspecialidad.SelectedValue = result.Especialidad;
                    txtDireccion.Text = result.Direccion;
                    txtTelefono.Text = result.Telefono;
                    panelFormDoctores.Visible = true;
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

       
        public void EliminarRegistro()
        {

            var IdSelected = GetSelectedRowGrid();

            if (IdSelected.HasValue)
            {
                //mandamos a eliminar el registro desde la base de datos
                var result = IApp.DoctoresService.Delete(new DoctoresEntity()
                {
                    DoctoresId = IdSelected
                });
                //si el mensaje de error es igual a cero  se elimino correctamente
                if (result.CodeError == 0)
                {
                    MessageBox.Show("El Registro Se elimino Correctamente!");
                    // cargamos de nuevos los datos en la tabla 
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
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                panelFormDoctores.Visible = false;

                var Respuesta = MessageBox.Show("Seguro que desea Eliminar este registro?"
                    , "Eliminar", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {
                    EliminarRegistro();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormDoctores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionFormulario())
                {
                    var DoctoresId = string.IsNullOrEmpty(txtDoctoresId.Text)
                                            ? (int?)null // Insertar
                                            : Convert.ToInt32(txtDoctoresId.Text); //Editar

                    var entity = new DoctoresEntity
                    {
                        DoctoresId = DoctoresId,
                         
                        Nombre = txtNombre.Text,
                        Apellidos = txtApellidos.Text,
                        Cedula = txtCedula.Text,
                        Especialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue),
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text
                        
                    };

                    var result = new DBEntity();

                    if (entity.DoctoresId.HasValue)
                    {
                        //actualizar
                        result = IApp.DoctoresService.Update(entity);

                        if (result.CodeError == 0)
                            MessageBox.Show("Se Actualizo el registro correctamente!");

                    }
                    else
                    {
                        //Insertar
                        result = IApp.DoctoresService.Create(entity);

                        if (result.CodeError == 0)
                            MessageBox.Show("Se guardo el registro correctamente!");
                    }

                    //verificamos que la base de datos no retorne un error
                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    //limpiamos  refrescamos y desaparecemos el form
                    LimpiarDatos();
                    CargarDatos();
                    panelFormDoctores.Visible = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
