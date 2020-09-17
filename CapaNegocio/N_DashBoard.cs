using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_DashBoard
    {
        public void DashBoard(E_DashBoard obj)
        {
            D_DashBoard acceso = new D_DashBoard();
            //estos datos reciben como parametro una clase como tipo
            //y de negocio se envia como valor el objeto
            acceso.productosPrefe(obj);
            acceso.grafCategorias(obj);
            acceso.sumarioDatos(obj);
        }

    }
}
