using IndigoTestProjectFront.Service;
using IndigoTestProjectFront.Service.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace IndigoTestProjectFront.Products
{
    public partial class MainProducts : Form
    {
        #region "variables"
        private readonly AppService _AppService = new AppService();
        int ProductId;
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
        private async void bSave_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text.Length == 0)
            {
                MessageBox.Show("Debe diligenciar el nombre del producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (mtbQuantity.Text.Length == 0)
            {
                MessageBox.Show("Debe diligenciar la cantidad actual del producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            var product = new ProductsModel
            {
                Id = ProductId,
                ProductCode = mtbProductCode.Text,
                ProductName = tbProductName.Text,
                Quantity = int.Parse(mtbQuantity.Text),
                Price = int.Parse(mtbPrice.Text)
            };
            var response = await _AppService.PutAsync<ResponseModel>("api/Product/saveProduct", product);
            if (response.Status == true)
            {
                MessageBox.Show("Actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Ocurrió un problema al guardar el producto - {response.Message}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            clean();
        }

        /// <summary>
        /// Evento click de botón eliminar productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var response = await _AppService.DeleteAsync<ResponseModel>("api/Product/deleteProduct?Id=", ProductId);
                if (response.Status == true)
                {
                    MessageBox.Show("Eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Ocurrió un problema al eliminar el producto - {response.Message}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                clean();
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
        private async void consultProduct(string productCode)
        {
            var response = await _AppService.GetAsyncByCode<ResponseModel>("api/Product/consultProductByCode?ProductCode=", productCode);
            if (response.Data != null)
            {            
                var product = JsonConvert.DeserializeObject<ProductsModel>(response.Data.ToString());
                ProductId = product.Id;
                tbProductName.Text = product.ProductName;
                mtbQuantity.Text = product.Quantity.ToString();
                mtbPrice.Text = product.Price.ToString();
            }
            mtbProductCode.Enabled = false;
            tbProductName.Enabled = true;
            mtbQuantity.Enabled = true;
            mtbPrice.Enabled = true;
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
            bSave.Enabled = false;
            bDelete.Enabled = false;
        }

        #endregion
                
    }
}
