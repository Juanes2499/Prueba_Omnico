using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmniconApp.Models;

namespace OmniconApp.Controllers
{
    public class ProductsController
    {
        public List<PRODUCTS> consultarProductos()
        {
            List<PRODUCTS> lista_productos = new List<PRODUCTS>();
            PRODUCTS productos = new PRODUCTS();

            using (OmniconEntities db = new OmniconEntities())
            {
                lista_productos = db.PRODUCTS.AsNoTracking().ToList();
            }

            return lista_productos;
        }

        public bool crearProducto(PRODUCTS products)
        {
            string fechaActual = DateTime.UtcNow.ToString("d");

            PRODUCTS createProduct = new PRODUCTS();
            using (OmniconEntities db = new OmniconEntities())
            {
                createProduct.ID = Guid.NewGuid();
                createProduct.PRODUCT = products.PRODUCT;
                createProduct.QUANTITY = products.QUANTITY;
                createProduct.MODIFIED_DATE = DateTime.Parse(fechaActual);

                db.PRODUCTS.Add(createProduct);
                db.SaveChanges();

                return true;

            }
        }

        public PRODUCTS consultarProductosById(Guid id)
        {
            PRODUCTS productoById = new PRODUCTS();

            using (OmniconEntities db = new OmniconEntities())
            {
                productoById = db.PRODUCTS.Find(id);
            }

            return productoById;
        }

        public void actualizarProducto(PRODUCTS products)
        {
            string fechaActual = DateTime.UtcNow.ToString("d");

            using (OmniconEntities db = new OmniconEntities())
            {
                var update = (from a in db.PRODUCTS where a.ID == products.ID select a).FirstOrDefault();
                update.PRODUCT = products.PRODUCT;
                update.QUANTITY = products.QUANTITY;
                update.MODIFIED_DATE = DateTime.Parse(fechaActual);

                db.SaveChanges();
            }
        }

        public bool eliminarProducto(PRODUCTS product)
        {
            using(OmniconEntities db = new OmniconEntities())
            {
                db.PRODUCTS.Remove(db.PRODUCTS.Find(product.ID));
                db.SaveChanges();
                return true;
            }
        }
    }
}
