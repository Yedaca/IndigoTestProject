using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace IndigoTestProject
{
    public partial class MainProducts : Form
    {
        #region "variables"
        bool newRecord;
        #endregion
        public MainProducts()
        {
            InitializeComponent();
        }
        #region "events"
        /// <summary>
        /// Evento KeyDown del campo Código del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                return;
            }
            if (e.KeyCode == Keys.Enter && mtbProductCode.Text.Length > 0) 
            {
                consultProduct(mtbProductCode.Text);
            }
        }
        /// <summary>
        /// Evento click del botón guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSave_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text.Length == 0)
            {
                MessageBox.Show("Debe diligenciar el nombre del producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (mtbQuantity.Text.Length == 0)
            {
                MessageBox.Show("Debe diligenciar la cantidad actual del producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (newRecord == true)
            {

            }
            else
            {

            }
            clean();
        }

        /// <summary>
        /// Evento click de botón eliminar productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        /// <summary>
        /// Evento click del botón limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bClean_Click(object sender, EventArgs e)
        {
            clean();
        }
        #endregion

        #region "Methods"
        /// <summary>
        /// Método para consultar productos
        /// </summary>
        /// <param name="productCode"></param>
        private void consultProduct(string productCode)
        {
            mtbProductCode.Enabled = false;
            tbProductName.Enabled = true;
            mtbQuantity.Enabled = true;
            mtbPrice.Enabled = true;
            bProductImage.Enabled = true;
            bSave.Enabled = true;
            bDelete.Enabled = true;
        }

        /// <summary>
        /// Método para limpiar e inhabilitar los controles del formulario
        /// </summary>
        private void clean()
        {
            mtbProductCode.Enabled = true;
            mtbProductCode.Text = null;
            tbProductName.Enabled = false;
            tbProductName.Text = null;
            mtbQuantity.Enabled = false;
            mtbQuantity.Text = null;
            mtbPrice.Text = null;
            mtbPrice.Enabled = false;
            bProductImage.Enabled = false;
            bProductImage.Image = null;
            bSave.Enabled = false;
            bDelete.Enabled = false;
        }

        #endregion
                
    }
}
