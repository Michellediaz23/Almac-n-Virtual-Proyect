using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Almacén_Virtual_Proyect
{
    public partial class Form2 : Form
    {

        Form1 frm = new Form1();
        int conteo = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void lblProductoAreservar_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            pBProgreso.Value = 0;
            conteo = 0;
        }

        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            conteo = conteo + 2;

            if (pBProgreso.Value < 100)
                pBProgreso.Value = conteo;


            if (pBProgreso.Value == 100)
            {
                timerTiempo.Enabled = false;
                frm.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int conteo2 = 0;
            if ((txtUsuario.Text != "") && (txtContraseña.Text != ""))
            {
                if ((txtUsuario.Text == "Owner") && (txtContraseña.Text == "Buenardo567"))
                {
                    timerTiempo.Enabled = true;
                    pBProgreso.Value = 0;
                 
                    this.timerTiempo.Start();

                

                }

                if (txtUsuario.Text != "Owner")
                {
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtUsuario.Focus();
                }

                if (txtContraseña.Text != "Buenardo567")
                {
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtUsuario.Focus();
                }
            }


            
        }
    }
    
}
