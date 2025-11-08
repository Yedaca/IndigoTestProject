using IndigoTestProjectFront.Service;
using IndigoTestProjectFront.Service.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndigoTestProjectFront
{
    public partial class MainBuyProducts : Form
    {
        #region "variables"
        private readonly AppService _AppService = new AppService();
        #endregion
        public MainBuyProducts()
        {
            InitializeComponent();
        }
        #region "events"
        /// <summary>
        /// Evento load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainBuyProducts_Load(object sender, EventArgs e)
        {
            loadProducts();
        }
        /// <summary>
        /// Evento click del botón comprar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bBuy_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<SalesModel> salesModels = new List<SalesModel>();
            foreach (DataGridViewRow fila in dgvProducts.Rows)
            {
                salesModels.Add(new SalesModel()
                {
                    ProductId = Convert.ToInt32(fila.Cells["Id"].Value),
                    Quantity = Convert.ToInt32(fila.Cells["Quantity"].Value),
                    Date = DateTime.Now
                });
            }
            var response = await _AppService.PutAsync<ResponseModel>("api/BuyProduct/saveSale", salesModels);
            if (response.Status == true)
            {
                MessageBox.Show("Actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Ocurrió un problema al guardar el producto - {response.Message}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            loadProducts();
        }
        #endregion
        #region "Methods"
        private async void loadProducts()
        {
            Cursor.Current = Cursors.WaitCursor;
            var response = await _AppService.GetAsync<ResponseModel>("api/Product/consultProduct");
            var productsList = JsonConvert.DeserializeObject<List<ProductsModel>>(response.Data.ToString());
            dgvProducts.DataSource = productsList;
            Cursor.Current = Cursors.Default;
        }
        #endregion

    }
}
