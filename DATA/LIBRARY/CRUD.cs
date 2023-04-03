﻿using DATABASE.LIBRARY.CLADATOS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DATABASE {
    public class CRUD {

        SqlConnection conectar = new SqlConnection(@"Data Source=DESKTOP-QUV81SK;Initial Catalog=ALMACEN_RODRIGUEZ;Integrated Security=True");

        public DataTable consulta ( string str ) {
            DataTable tl = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(str, conectar);
            sd.Fill(tl);
            return tl;
            }

        public void CREATEDATOSCLIENTE ( DATOSCLIENTE CLIENTE ) {

            SqlCommand cmd = new SqlCommand("ADDCLIENTE", conectar);
            conectar.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", CLIENTE.ID);
            cmd.Parameters.AddWithValue("@NOMBRE", CLIENTE.NAMECLIENTE);
            cmd.Parameters.AddWithValue("@APELLIDO", CLIENTE.APELLIDO);
            cmd.Parameters.AddWithValue("@TELEFONO", CLIENTE.TELEFONO);
            cmd.Parameters.AddWithValue("@DIRECCION", CLIENTE.DIRECCION);

            cmd.ExecuteNonQuery();

            conectar.Close();
            }

        public void UPDATEDATOSCLIENTE ( DATOSCLIENTE CLIENTE ) {

            SqlCommand cmd = new SqlCommand("ADDCLIENTE", conectar);
            conectar.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NOMBRE", CLIENTE.NAMECLIENTE);
            cmd.Parameters.AddWithValue("@APELLIDO", CLIENTE.APELLIDO);
            cmd.Parameters.AddWithValue("@TELEFONO", CLIENTE.TELEFONO);
            cmd.Parameters.AddWithValue("@DIRECCION", CLIENTE.DIRECCION);

            cmd.ExecuteNonQuery();

            conectar.Close();
            }

        public void DeleteCliente ( int id ) {

            SqlCommand bf = new SqlCommand("DELETE", conectar);

            bf.CommandType = CommandType.StoredProcedure;

            bf.Parameters.AddWithValue("@ID", id);

            conectar.Open();
            bf.ExecuteNonQuery();
            conectar.Close();

            }

        public void DATOSALMACEN ( DATOSFACTURA ALMACEN, string clave ) {

            SqlCommand cmd = new SqlCommand("ADDPRODUCTO", conectar);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ALMACEN.ID);
            cmd.Parameters.AddWithValue("@NOMBRE", ALMACEN.NAMEPRODUCTO);
            cmd.Parameters.AddWithValue("@CANTIDAD", ALMACEN.CANTIDAD);
            cmd.Parameters.AddWithValue("@DISTRIBUIDOR", ALMACEN.DISTRIBUIDOR);
            cmd.Parameters.AddWithValue("@PRECIOVENTA", ALMACEN.PRECIOVENTA);
            cmd.Parameters.AddWithValue("@MEDIDA", ALMACEN.MEDIDA);
            cmd.Parameters.AddWithValue("@PRECIOCOMPRA", ALMACEN.PRECIOCOMPRA);

            conectar.Open();
            cmd.ExecuteNonQuery();

            conectar.Close();
            }

        public bool DATOSFACTURA ( DataGridView detail, DATOSFACTURA FACTURA ) {

            try {
                SqlCommand cmd = new SqlCommand("ADDFACTURA", conectar);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDCLIENTE", FACTURA.IDCLIENTE);
                cmd.Parameters.AddWithValue("@ESTADO", FACTURA.ESTADO);
                cmd.Parameters.AddWithValue("@TOTAL", FACTURA.TOTAL);
                cmd.Parameters.AddWithValue("@DESCUENTO", FACTURA.DESCUENTO);
                cmd.Parameters.AddWithValue("@TIPO", FACTURA.TIPOFACTURA);
                cmd.Parameters.AddWithValue("@LISTA", DatosDetalle(detail));


                conectar.Open();
                cmd.ExecuteNonQuery();



                conectar.Close();
                return true;
                }
            catch (Exception ex) {
                return false;
                }
            }

        private DataTable DatosDetalle ( DataGridView detail ) {
            DataTable details = new DataTable();
            details.Columns.Add("ID_PRODETAIL");
            details.Columns.Add("ID_PRODUCT");
            details.Columns.Add("CANT_PRODUCT");

            DataRow dr = details.NewRow();
            foreach (DataGridViewRow item in detail.Rows) {
                dr["ID_PRODUCT"] = int.Parse(item.Cells["ID"].Value.ToString());
                dr["CANT_PRODUCT"] = int.Parse(item.Cells["CANTIDAD"].Value.ToString());

                }

            return details;
            }

        public void DATOSFACTURA ( DATOSFACTURA status ) {
            try {
                SqlCommand cmd = new SqlCommand("ADDFACTURA", conectar);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ESTADO", status.ESTADO);

                conectar.Open();
                cmd.ExecuteNonQuery();

                conectar.Close();
                }
            catch (Exception ex) {
                return;
                }
            }

        public void DeleteRegisterBill ( int id ) {

            SqlCommand bf = new SqlCommand("DELETEFACTURA", conectar);

            bf.CommandType = CommandType.StoredProcedure;

            bf.Parameters.AddWithValue("@ID", id);

            conectar.Open();
            bf.ExecuteNonQuery();
            conectar.Close();

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

        public void AGENDA ( DATOAGENDA AG ) {

            SqlCommand cmd = new SqlCommand("ADDAGENDA", conectar);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", AG.IDAGENDA);
            cmd.Parameters.AddWithValue("@NOMBRE", AG.NOMBREAGENDA);
            cmd.Parameters.AddWithValue("@APELLIDO", AG.APELLIDOAGENDA);
            cmd.Parameters.AddWithValue("@DIRECCION", AG.DIRECCIONAGENDA);
            cmd.Parameters.AddWithValue("@TELEFONO", AG.TELEFONO);

            conectar.Open();
            cmd.ExecuteNonQuery();
            conectar.Close();
            }

        public void DeleteRegisterSchedule ( int id ) {
            SqlCommand bf = new SqlCommand("DELETEAGENDA", conectar);

            bf.CommandType = CommandType.StoredProcedure;

            bf.Parameters.AddWithValue("@ID", id);

            conectar.Open();
            bf.ExecuteNonQuery();
            conectar.Close();
            }

        }
    }
