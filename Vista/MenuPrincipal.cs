using Evaluacion2NuevaNET.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2NuevaNET.Vista
{
    public partial class VntMenuPrincipal : Form
    {
        public VntMenuPrincipal()
        {
            InitializeComponent();
        }

        private void _btnCerrarCaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total recaudado: " + "\n¡Hasta luego!", "Resumen");

            VntLogin vntLogin = new VntLogin();
            vntLogin.Show();
            this.Hide();
        }

        private void _btnAgregarPedido_Click(object sender, EventArgs e)
        {
            LINQVentasDataContext tblVentas = new LINQVentasDataContext();
            var ventas = from venta in tblVentas.Venta select venta;

            //Hacer el LINQ con Producto

            Venta nuevaVenta = new Venta();
            nuevaVenta.fecha = Int32.Parse(DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());
            _gvVentas.DataSource = ventas;
            

        }

        private void VntMenuPrincipal_Load(object sender, EventArgs e)
        {
            LINQVentasDataContext tblVentas = new LINQVentasDataContext();
            var ventas = from venta in tblVentas.Venta select venta;
            _gvVentas.DataSource = ventas;

        }
    }
}
