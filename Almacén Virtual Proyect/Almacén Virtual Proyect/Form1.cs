using Modelo.pf;

namespace Almacén_Virtual_Proyect
{
    public partial class Form1 : Form
    {

            Controlador.pf.Controller cl= new Controlador.pf.Controller();  
        public Form1()
        {
            InitializeComponent();
        }
        //....#
        //....Botones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cl.Activar(txtProducto, txtPrecio, txtIDproducto, txtCantidad, txtMarca, btnRegistro);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            cl.AgregaraLista(txtProducto, txtPrecio, txtIDproducto, txtCantidad, txtMarca,dgvProducAlmacenados,epAdvertencia);
            cl.VaciarRegresar(txtProducto, txtPrecio, txtIDproducto, txtCantidad, txtMarca);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cl.ActivarBusqueda(txtBuscar, btnBuscar);
        }

        private void tsBoorartodo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            cl.EliminarunProduc(dgvProducAlmacenados);
        }

        private void tsBorrartodo_Click(object sender, EventArgs e)
        {
            cl.LimpiarLista(dgvProducAlmacenados);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cl.BuscarEnLista(txtBuscar, dgvProducAlmacenados);
        }

        private void tlbReservar_Click(object sender, EventArgs e)
        {
            Form2 frm= new Form2(); 

            frm.ShowDialog();   
        }

        private void dgvProducAlmacenados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducAlmacenados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void lbProductosDeComparacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (rbMenores.Checked == true)
            {
                cl.MostrarConsultaMenor(dgvConsculta, txtConsultao);

            }

            if (rbMayores.Checked == true) 
            {
                cl.MostrarConsultaMayor(dgvConsculta, txtConsultao);
            
            }
        }
    }
}