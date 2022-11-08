using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DATA
{
    public class CONNETION
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=DESKTOP-QUV81SK;Initial Catalog=ALMACEN_RODRIGUEZ;Integrated Security=True");

        public DataTable consulta(string str)
        {
            DataTable tl = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(str, conectar);
            sd.Fill(tl);
            return tl;
        }


    }
}
