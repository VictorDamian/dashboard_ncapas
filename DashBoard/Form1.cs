using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dashBoard();
        }

        private void dashBoard()
        {
            N_DashBoard neg = new N_DashBoard();
            E_DashBoard obj = new E_DashBoard();

            //llamamos al parametro de dashboard
            neg.DashBoard(obj);

            //recuperamos datos de la entidad para llenar datos del dashboad
            chartProdPrefe.Series[0].Points.DataBindXY(obj.Producto, obj.Cantidad);

            chartProductosCategoria.Series[0].Points.DataBindXY(obj.Cate,obj.CantProduc);

            lblTotalventas.Text = obj.TotalVentas;
            lblCCate.Text = obj.CCate1;
            lblCClient.Text = obj.CClientes1;
            lblCEmple.Text = obj.CEmple1;
            lblCMarcas.Text = obj.CMatcas1;
            lblCProduc.Text = obj.CProductos1;
            lblCProvee.Text = obj.CProvee1;
        }
    }
}
