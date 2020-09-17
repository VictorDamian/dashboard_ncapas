using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
namespace CapaDatos
{
    public class D_DashBoard
    {
        SqlConnection conexion = new SqlConnection("Server=DANTES\\DANTES; DataBase=PRACTICA_DASHBOARD; Integrated security=true");
        SqlCommand comando;
        SqlDataReader reader;

        //obj es un tipo de dato no instacncia
        public  void grafCategorias(E_DashBoard obj)
        {
            comando = new SqlCommand("ProdPorCategoria", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //columnas
                obj.Cate.Add(reader.GetString(0));
                obj.CantProduc.Add(reader.GetInt32(1));
            }
            reader.Close();
            conexion.Close();
        }
        public void productosPrefe(E_DashBoard obj)
        {
            comando = new SqlCommand("ProdPreferidos", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //columnas
                obj.Producto.Add(reader.GetString(0));
                obj.Cantidad.Add(reader.GetInt32(1));
            }
            reader.Close();
            conexion.Close();
        }
        public void sumarioDatos(E_DashBoard obj)
        {
            comando = new SqlCommand("DashboardDatos2", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            //declaracion de parametros de salida
            SqlParameter par = new SqlParameter("@totVentas", 0); par.Direction = ParameterDirection.Output;
            SqlParameter nprod = new SqlParameter("@nprod", 0); nprod.Direction = ParameterDirection.Output;
            SqlParameter nmarc = new SqlParameter("@nmarc", 0); nmarc.Direction = ParameterDirection.Output;
            SqlParameter ncat = new SqlParameter("@ncateg", 0); ncat.Direction = ParameterDirection.Output;
            SqlParameter nclient = new SqlParameter("@nclient", 0); nclient.Direction = ParameterDirection.Output;
            SqlParameter nprove = new SqlParameter("@nprove", 0); nprove.Direction = ParameterDirection.Output;
            SqlParameter nemple = new SqlParameter("@nemple", 0); nemple.Direction = ParameterDirection.Output;

            //agregamos dichos parametros al comando
            comando.Parameters.Add(par);
            comando.Parameters.Add(nprod);
            comando.Parameters.Add(nmarc);
            comando.Parameters.Add(ncat);
            comando.Parameters.Add(nclient);
            comando.Parameters.Add(nprove);
            comando.Parameters.Add(nemple);

            conexion.Open();//abirmos conexion
            comando.ExecuteNonQuery();//ejecutamos procedimeinto

            //agregamos los valores a los labels
            obj.TotalVentas = comando.Parameters["@totVentas"].Value.ToString();
            obj.CProductos1 = comando.Parameters["@nprod"].Value.ToString();
            obj.CMatcas1 = comando.Parameters["@nmarc"].Value.ToString();
            obj.CCate1 = comando.Parameters["@ncateg"].Value.ToString();
            obj.CClientes1 = comando.Parameters["@nclient"].Value.ToString();
            obj.CProvee1 = comando.Parameters["@nprove"].Value.ToString();
            obj.CEmple1 = comando.Parameters["@nemple"].Value.ToString();

            conexion.Close();
        }
    }
}
