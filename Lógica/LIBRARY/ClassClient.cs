﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATABASE.LIBRARY.CLADATOS;
using DATABASE;
using System.Windows.Forms;

namespace Lógica.LIBRARY {
    public class ClassClient:Report {

        private CONNETION bridgetobd = new CONNETION();
        public DATOSCLIENTE cn = new DATOSCLIENTE();

        public ClassClient ( ) {
           
            }

        public void DataView( ref DataGridView dt, String key ) {

            if (key != String.Empty) {
                dt.DataSource = bridgetobd.consulta("SELECT * FROM PRINCIPAL CLIENT WHERE NOMBRE = '%" + key + "%'");
                }
            
             dt.DataSource = bridgetobd.consulta("SELECT * FROM PRINCIPAL CLIENT");
            }
        public void SaveDataClient ( List<object> client) {
            cn.ID = int.Parse(client[0].ToString());
            cn.NAMECLIENTE = client[1].ToString();
            cn.APELLIDO = client[2].ToString();
            cn.DIRECCION = client[3].ToString();
            cn.TELEFONO = client[4].ToString();

            bridgetobd.DATOSCLIENTE(cn);

            }

        public void DeleteDataClient (int id ) {
            cn.ID = id;
            bridgetobd.DATOSCLIENTE(cn);
            }

        }
    }
