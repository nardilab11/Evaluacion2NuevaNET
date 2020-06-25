using Evaluacion2NuevaNET.Modelo;
using Evaluacion2NuevaNET.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2NuevaNET
{
    public partial class VntLogin : Form
    {
        public VntLogin()
        {
            InitializeComponent();
        }

        private void _btnIngresar_Click(object sender, EventArgs e)
        {
            LINQCajerosDataContext tblCajeros = new LINQCajerosDataContext();
            var usuariosCajero = from cajero in tblCajeros.Cajero select cajero.nombre;
            bool usuarioCorrecto = false;
            string usMin = _txbCajero.Text.ToLower();

            if (usMin.All(char.IsLower))
            {
                if (tblCajeros.Cajero.Any<Cajero>(usuario => usuario.nombre == _txbCajero.Text && usuario.pass == _txbPass.Text))
                {
                    usuarioCorrecto = true;
                }

                if (usuarioCorrecto)
                {
                    VntMenuPrincipal vntMenuPrincipal = new VntMenuPrincipal();
                    vntMenuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario y/o la contraseña ingresados son incorrectos.", "Datos Inválidos");
                }
            }
            else
            {
                MessageBox.Show("Solo se aceptan letras mayúscula y/o minúsculas.","Error");
            }
            
        }
    }
}
