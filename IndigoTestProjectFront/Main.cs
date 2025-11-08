using IndigoTestProjectFront.Products;

namespace IndigoTestProjectFront
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bProducts_Click(object sender, EventArgs e)
        {
            MainProducts mainProducts = new MainProducts();
            mainProducts.ShowDialog();
        }

        private void bBuyProduct_Click(object sender, EventArgs e)
        {
            MainBuyProducts mainBuyProducts = new MainBuyProducts();
            mainBuyProducts.ShowDialog();
        }
    }
}
