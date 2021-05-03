using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OmniconApp.Models;
using OmniconApp.Controllers;

namespace OmniconApp.Views
{
    public partial class Products_deleteNotification : Form
    {
        public Guid id;
        public Products_deleteNotification(Guid id, string label)
        {
            InitializeComponent();

            this.id = id;
            messageNotification.Text = label;
        }

        private void buttonConfirmation_Click(object sender, EventArgs e)
        {
            if (id != Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                PRODUCTS deleteProduct = new PRODUCTS();
                deleteProduct.ID = id;

                ProductsController controller = new ProductsController();
                controller.eliminarProducto(deleteProduct);
            }

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
