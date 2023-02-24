using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DATABASE;
using DATABASE.LIBRARY.CLADATOS;


namespace DATABASE {
    public class CRUD {
        SqlConnection conectar = new SqlConnection(@"Data Source=DESKTOP-QUV81SK;Initial Catalog=ALMACEN_RODRIGUEZ;Integrated Security=True");

        public DataTable consulta ( string str ) {
            DataTable tl = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(str, conectar);
            sd.Fill(tl);
            return tl;
            }

        public void DATOSCLIENTE ( DATOSCLIENTE CLIENTE, string clave ) {


            switch (clave) {

                case "AÑADIR":

                    SqlCommand cmd = new SqlCommand("ADDCLIENTE", conectar);
                    conectar.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", CLIENTE.ID);
                    cmd.Parameters.AddWithValue("@NOMBRE", CLIENTE.NAMECLIENTE);
                    cmd.Parameters.AddWithValue("@APELLIDO", CLIENTE.APELLIDO);
                    cmd.Parameters.AddWithValue("@TELEFONO", CLIENTE.TELEFONO);
                    cmd.Parameters.AddWithValue("@DIRECCION", CLIENTE.DIRECCION);
                    cmd.Parameters.AddWithValue("@FECHA", CLIENTE.FECHA);

                    cmd.ExecuteNonQuery();
                    break;

                case "BORRAR":

                    SqlCommand bc = new SqlCommand("DELETECLIENTE", conectar);
                    conectar.Open();
                    bc.CommandType = CommandType.StoredProcedure;

                    bc.Parameters.AddWithValue("@ID", CLIENTE.ID);

                    bc.ExecuteNonQuery();
                    break;

                }
            conectar.Close();
            }

        public void DATOSALMACEN ( DATOSPRODUCTOS ALMACEN, string clave ) {

            conectar.Open();
            switch (clave) {
                case "AÑADIR":

                    SqlCommand cmd = new SqlCommand("ADDPRODUCTO", conectar);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", ALMACEN.ID);
                    cmd.Parameters.AddWithValue("@NOMBRE", ALMACEN.NAMEPRODUCTO);
                    cmd.Parameters.AddWithValue("@CANTIDAD", ALMACEN.CANTIDAD);
                    cmd.Parameters.AddWithValue("@DISTRIBUIDOR", ALMACEN.DISTRIBUIDOR);
                    cmd.Parameters.AddWithValue("@PRECIOVENTA", ALMACEN.PRECIOVENTA);
                    cmd.Parameters.AddWithValue("@MEDIDA", ALMACEN.MEDIDA);
                    cmd.Parameters.AddWithValue("@PRECIOCOMPRA", ALMACEN.PRECIOCOMPRA);


                    cmd.ExecuteNonQuery();
                    break;

                case "ACTUALIZAR":

                    SqlCommand cmdCONTROL = new SqlCommand("CONTROLCANTIDAD", conectar);

                    cmdCONTROL.CommandType = CommandType.StoredProcedure;

                    cmdCONTROL.Parameters.AddWithValue("@ID", ALMACEN.ID);
                    cmdCONTROL.Parameters.AddWithValue("@CANTIDAD", ALMACEN.CANTIDAD);


                    cmdCONTROL.ExecuteNonQuery();
                    break;

                case "BORRAR":

                    SqlCommand bfp = new SqlCommand("DELETEPRODUCTO", conectar);

                    bfp.CommandType = CommandType.StoredProcedure;

                    bfp.Parameters.AddWithValue("@ID", ALMACEN.ID);

                    bfp.ExecuteNonQuery();
                    break;

                }
            conectar.Close();
            }

        public void DATOSFACTURA ( DATOSFACTURA FACTURA, string clave ) {

            
            switch (clave) {

                case "AÑADIRFACTURA":

                    SqlCommand cmd = new SqlCommand("ADDFACTURA", conectar);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CLIENTE", FACTURA.NAMECLIENTE);
                    cmd.Parameters.AddWithValue("@IDCLIENTE", FACTURA.IDCLIENTE);
                    cmd.Parameters.AddWithValue("@DIRECCION", FACTURA.DIRECCION);
                    cmd.Parameters.AddWithValue("@ESTADO", FACTURA.ESTADO);
                    cmd.Parameters.AddWithValue("@TOTAL", FACTURA.TOTAL);
                    cmd.Parameters.AddWithValue("@DESCUENTO", FACTURA.DESCUENTO);
                    cmd.Parameters.AddWithValue("@NETO", FACTURA.PAGONETO);
                    cmd.Parameters.AddWithValue("@TIPO", FACTURA.TIPOFACTURA);
                    cmd.Parameters.AddWithValue("@CANTIDAD", FACTURA.CANTIDAD);
                    cmd.Parameters.AddWithValue("@PRECIOVENTA", FACTURA.PRECIOVENTA);
                    cmd.Parameters.AddWithValue("@UNIDAD", FACTURA.MEDIDA);
                    cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

                    conectar.Open();
                    cmd.ExecuteNonQuery();
                    FACTURA.ID = (int)cmd.Parameters["RETURN_VALUE"].Value;


                    break;

                case "BORRARFACTURA":
                    SqlCommand bf = new SqlCommand("DELETEFACTURA", conectar);

                    bf.CommandType = CommandType.StoredProcedure;
                    bf.Parameters.AddWithValue("@ID", FACTURA.ID);

                    bf.ExecuteNonQuery();
                    break;

                }
            conectar.Close();
            }

        private DataTable DatosDetalle(List<int> detail, int IdBill ) {
            DataTable details = new DataTable();
            details.Columns.Add("ID_PRODETAIL");
            details.Columns.Add("ID_PRODUCT");
            details.Columns.Add("CANT_PRODUCT");

            DataRow dr = details.NewRow();
            foreach (List<int> item in detail) { 
                dr["ID_PRODETAIL"] = IdBill;
                dr["ID_PRODUCT"] = item[0];
                dr["CANT_PRODUCT"] = item[1];

                }

            return 
            }

        public void DATOSUSUARIO ( int ID, string NAMEUSER, string PASSWORD ) {
            SqlCommand user = new SqlCommand("ADDUSER", conectar);
            conectar.Open();
            user.CommandType = CommandType.StoredProcedure;

            user.Parameters.AddWithValue("@ID", ID);
            user.Parameters.AddWithValue("@NAME", NAMEUSER);
            user.Parameters.AddWithValue("@PASS", PASSWORD);


            user.ExecuteNonQuery();


            conectar.Close();
            }

        public void PAGO ( int cliente, int factura ) {
            SqlCommand cmd = new SqlCommand("ADDHISTORIAL", conectar);
            conectar.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CLIENTE", cliente);
            cmd.Parameters.AddWithValue("@FACTURA", factura);
            cmd.Parameters.AddWithValue("@FECHA", Convert.ToDateTime(DateTime.Today.ToShortDateString()));


            cmd.ExecuteNonQuery();

            conectar.Close();
            }

        public void AGENDA ( DATOAGENDA AG, string clave ) {

            conectar.Open();
            switch (clave) {
                case "AÑADIR":

                    SqlCommand cmd = new SqlCommand("ADDAGENDA", conectar);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", AG.IDAGENDA);
                    cmd.Parameters.AddWithValue("@NOMBRE", AG.NOMBREAGENDA);
                    cmd.Parameters.AddWithValue("@APELLIDO", AG.APELLIDOAGENDA);
                    cmd.Parameters.AddWithValue("@DIRECCION", AG.DIRECCIONAGENDA);
                    cmd.Parameters.AddWithValue("@TELEFONO", AG.TELEFONO);


                    cmd.ExecuteNonQuery();
                    break;

                case "BORRAR":

                    SqlCommand bfp = new SqlCommand("DELETEAGENDA", conectar);
                    bfp.CommandType = CommandType.StoredProcedure;
                    bfp.Parameters.AddWithValue("@ID", AG.IDAGENDA);

                    bfp.ExecuteNonQuery();
                    break;

                }
            conectar.Close();
            }

        public void AJUSTE ( string us, string pass ) {
            SqlCommand cmd = new SqlCommand("ADDUSER", conectar);
            conectar.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NAME", us);
            cmd.Parameters.AddWithValue("@PASS", pass);



            cmd.ExecuteNonQuery();

            conectar.Close();
            }
        public void ControlCantidadProductos ( int ID, int Cantidad ) {

            DATOSPRODUCTOS dp = new DATOSPRODUCTOS();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT ID_PRODUCTO AS [ID], CAN_PRODUCTO AS [CANTIDAD] FROM PRODUCTO_CANTIDAD WHERE ID_PRODUCTO = '" + ID + "'", conectar);
            da.Fill(dt);
            dp.ID = ID;
            dp.CANTIDAD = int.Parse(dt.Rows[0]["CANTIDAD"].ToString()) - Cantidad;

            DATOSALMACEN(dp, "ACTUALIZAR");
            }
        }
    }
