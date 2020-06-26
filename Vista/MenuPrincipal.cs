using Evaluacion2NuevaNET.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2NuevaNET.Vista
{
    public partial class VntMenuPrincipal : Form
    {
        private float totalAcum = 0;
        public VntMenuPrincipal()
        {
            InitializeComponent();
        }

        private void _btnCerrarCaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total recaudado: $" + this.totalAcum + "\n¡Hasta luego!", "Resumen");
            VntLogin vntLogin = new VntLogin();
            vntLogin.Show();
            this.Hide();
        }

        private void _btnAgregarPedido_Click(object sender, EventArgs e)
        {
           
            if (_txbPzInd.Text.Length == 0 || _txbPzMed.Text.Length == 0 || _txbPzFam.Text.Length == 0 || _txbBebInd.Text.Length == 0 || _txbBebFam.Text.Length == 0)
            { MessageBox.Show("Debe llenar todos los campos.", "Error"); }
            else 
            {
                if (!(_txbPzInd.Text.All(char.IsDigit)) || !(_txbPzMed.Text.All(char.IsDigit)) || !(_txbPzFam.Text.All(char.IsDigit)) || !(_txbBebInd.Text.All(char.IsDigit)) || !(_txbBebFam.Text.All(char.IsDigit)))
                { MessageBox.Show("Los campos deben tener solo números.", "Error"); }
                else
                {
                    if (_txbPzInd.Text.Length > 2 || _txbPzMed.Text.Length > 2 || _txbPzFam.Text.Length > 2 || _txbBebInd.Text.Length > 2 || _txbBebFam.Text.Length > 2)
                    { MessageBox.Show("Cantidad mayor a 99 en uno de los campos.", "Cantidad Inválida"); }
                    else
                    {
                        if ((_txbPzInd.Text != "0" && _txbPzMed.Text != "0") || (_txbPzInd.Text != "0" && _txbPzFam.Text != "0") || (_txbPzMed.Text != "0" && _txbPzFam.Text != "0"))
                        { MessageBox.Show("Solo un tipo de pizza por pedido.", "Error");}
                        else
                        {
                            //Crear LINQ y variables
                            Random r = new Random();
                            LINQVentasDataContext tblVentas = new LINQVentasDataContext();
                            LINQClientesDataContext tblClientes = new LINQClientesDataContext();
                            LINQProductosDataContext tblProd = new LINQProductosDataContext();
                            LINQCajerosDataContext tblCajeros = new LINQCajerosDataContext();
                            var ventas = from venta in tblVentas.Venta select venta;
                            var clientes = from cliente in tblClientes.Cliente select cliente;
                            var productos = from producto in tblProd.Producto select producto;
                            var cajeros = from cajero in tblCajeros.Cajero select cajero;

                            //Crear clases
                            Venta nuevaVenta = new Venta();
                            Producto nuevoProd = new Producto();

                            //Crear producto
                            int prodId = r.Next(1000);
                            string prodNombre = "";
                            float prodPrecio = 0;
                            int prodCant = 0;
                            if (Int32.Parse(_txbPzInd.Text) > 0)
                            {
                                prodNombre = "Pizza Ind/";
                                prodPrecio = 8000 * Int32.Parse(_txbPzInd.Text);
                                prodCant = Int32.Parse(_txbPzInd.Text);
                            }
                            else if (Int32.Parse(_txbPzMed.Text) > 0)
                            {
                                prodNombre = "Pizza Med/";
                                prodPrecio = 12000 * Int32.Parse(_txbPzMed.Text);
                                prodCant = Int32.Parse(_txbPzMed.Text);
                            }
                            else if (Int32.Parse(_txbPzFam.Text) > 0)
                            {
                                prodNombre = "Pizza Fam/";
                                prodPrecio = 22000 * Int32.Parse(_txbPzFam.Text);
                                prodCant = Int32.Parse(_txbPzFam.Text);
                            }
                            if (Int32.Parse(_txbBebInd.Text) > 0)
                            {
                                prodNombre = prodNombre + "Bebida Ind/";
                                prodPrecio = prodPrecio + (1500 * Int32.Parse(_txbBebInd.Text));
                                prodCant = prodCant + Int32.Parse(_txbBebInd.Text);
                            }
                            if (Int32.Parse(_txbBebFam.Text) > 0)
                            {
                                prodNombre = prodNombre + "Bebida Fam";
                                prodPrecio = prodPrecio + (5000 * Int32.Parse(_txbBebFam.Text));
                                prodCant = prodCant + Int32.Parse(_txbBebFam.Text);
                            }
                            nuevoProd.id = prodId;
                            nuevoProd.nombre = prodNombre;
                            nuevoProd.precio = prodPrecio;
                            nuevoProd.cantidad = prodCant;

                            this.totalAcum = this.totalAcum + prodPrecio;
                            _lblTotalAcml.Text = "$" + this.totalAcum.ToString();

                            //Crear venta
                            string fechaVenta = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + r.Next(1000).ToString();
                            nuevaVenta.fecha = Int32.Parse(fechaVenta);
                            nuevaVenta.idProducto = nuevoProd.id;
                            nuevaVenta.idCajero = cajeros.First().rut;
                            nuevaVenta.idCliente = clientes.First().phone;

                            //Añadir producto
                            tblProd.Producto.InsertOnSubmit(nuevoProd);
                            tblProd.SubmitChanges();

                            //Añadir venta
                            tblVentas.Venta.InsertOnSubmit(nuevaVenta);
                            tblVentas.SubmitChanges();

                            //Añadir la fuente del GridView
                            _gvProd.DataSource = productos;
                            _gvVentas.DataSource = ventas;
                        }
                    }
                }
            }
        }

        private void VntMenuPrincipal_Load(object sender, EventArgs e)
        {
            LINQVentasDataContext tblVentas = new LINQVentasDataContext();
            LINQProductosDataContext tblProd = new LINQProductosDataContext();
            var ventas = from venta in tblVentas.Venta select venta;
            var productos = from producto in tblProd.Producto select producto;
            _gvVentas.DataSource = ventas;
            _gvProd.DataSource = productos;

        }
    }
}
