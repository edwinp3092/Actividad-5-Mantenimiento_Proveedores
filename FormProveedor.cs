using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormProveedor : Form
    {
        ProveedorBL _Proveedor;

        public FormProveedor()
        {
            InitializeComponent();

            _Proveedor = new ProveedorBL();
            infoProveedorBindingSource.DataSource = _Proveedor.ObtenerProveedor();
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idProveTextBox.Text != "")
            {
                var resultado3 = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado3 == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idProveTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _Proveedor.EliminarProveedor(id);

            if (resultado == true)
            {
                infoProveedorBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el proveedor");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _Proveedor.CancelarCambios();
        }

        private void infoProveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            infoProveedorBindingSource.EndEdit();
            var proveedor = (Proveedor)infoProveedorBindingSource.Current;

            var resultado3 = _Proveedor.GuardarProveedor(proveedor);

            if (resultado3.Exitoso == true)
            {
                infoProveedorBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Proveedor Guardado");
            }
            else
            {
                MessageBox.Show(resultado3.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _Proveedor.AgregarProveedor();
            infoProveedorBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {

        }

        private void infoProveedorBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }
    }
}
