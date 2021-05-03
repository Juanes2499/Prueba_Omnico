using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OmniconApp.Views;
using OmniconApp.Controllers;

namespace OmniconApp.Views
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        ProductsController controller = new ProductsController();

 
        private Guid GetId()
        {
            try
            {
                return Guid.Parse(dataGridViewProducts.Rows[dataGridViewProducts.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return Guid.Parse("00000000-0000-0000-0000-000000000000");
            }
        }

        private void Products_Load_1(object sender, EventArgs e)
        {
            var lista_productos = controller.consultarProductos();
            dataGridViewProducts.DataSource = lista_productos;
        }

        private void buttonOpenNewProductWindow_Click(object sender, EventArgs e)
        {

            Products_NewRegister newRegisterWindow = new Products_NewRegister(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            newRegisterWindow.ShowDialog();

            //Refrescar
            var lista_productos = controller.consultarProductos();
            dataGridViewProducts.DataSource = lista_productos;
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            Guid id = GetId();

            if(id != null)
            {
                Products_NewRegister editRegisterWindow = new Products_NewRegister(id);
                editRegisterWindow.ShowDialog();

                //Refrescar
                var lista_productos = controller.consultarProductos();
                dataGridViewProducts.DataSource = lista_productos;
            }
        }


        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            Guid id = GetId();

            if (id != Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                string labelNotification = $@"User, do you want to delete the product with ID: {id}?";
                Products_deleteNotification deleteProduct = new Products_deleteNotification(id, labelNotification);
                deleteProduct.ShowDialog();

                //Refrescar
                var lista_productos = controller.consultarProductos();
                dataGridViewProducts.DataSource = lista_productos;
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
