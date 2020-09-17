using System.Collections;
namespace CapaEntidades
{
    public class E_DashBoard
    {
        //atributos
        ArrayList cate = new ArrayList();
        ArrayList cantProduc = new ArrayList();

        //atributo preferidos
        ArrayList producto = new ArrayList();
        ArrayList cantidad = new ArrayList();

        string totalVentas;
        string CProductos;
        string CMatcas;
        string CCate;
        string CClientes;
        string CProvee;
        string CEmple;

        public ArrayList Cate { get => cate; set => cate = value; }
        public ArrayList CantProduc { get => cantProduc; set => cantProduc = value; }
        public ArrayList Cantidad { get => cantidad; set => cantidad = value; }
        public ArrayList Producto { get => producto; set => producto = value; }
        public string TotalVentas { get => totalVentas; set => totalVentas = value; }
        public string CProductos1 { get => CProductos; set => CProductos = value; }
        public string CMatcas1 { get => CMatcas; set => CMatcas = value; }
        public string CCate1 { get => CCate; set => CCate = value; }
        public string CClientes1 { get => CClientes; set => CClientes = value; }
        public string CProvee1 { get => CProvee; set => CProvee = value; }
        public string CEmple1 { get => CEmple; set => CEmple = value; }
    }
}
