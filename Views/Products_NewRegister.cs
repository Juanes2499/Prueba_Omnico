using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OmniconApp.Controllers;
using OmniconApp.Models;

namespace OmniconApp.Views
{
    public partial class Products_NewRegister : Form
    {
        ProductsController controller = new ProductsController();

        public Guid id;
        public Products_NewRegister(Guid id)
        {
            InitializeComponent();

            this.id = id;
            if(id != Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                cargarDatos(id);
            }
        }

        private void cargarDatos(Guid id)
        {
            var productoById = controller.consultarProductosById(id);
            textBoxProductName.Text = productoById.PRODUCT;
            textBoxQuantity.Text = productoById.QUANTITY.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Products_NewRegister_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateNewRegister_Click(object sender, EventArgs e)
        {
            if (id == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                PRODUCTS newProduct = new PRODUCTS();
                newProduct.PRODUCT = textBoxProductName.Text;
                newProduct.QUANTITY = decimal.Parse(textBoxQuantity.Text);

                controller.crearProducto(newProduct);
            }
            else
            {
                PRODUCTS updateProduct = new PRODUCTS();
                updateProduct.ID = id;
                updateProduct.PRODUCT = textBoxProductName.Text;
                updateProduct.QUANTITY = decimal.Parse(textBoxQuantity.Text);

                controller.actualizarProducto(updateProduct);
            }

            this.Close();
        }
    }
}
