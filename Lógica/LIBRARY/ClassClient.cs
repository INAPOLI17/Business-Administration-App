using System;
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
                dt.DataSource = bridgetobd.consulta("SELECT * FROM [PRINCIPAL CLIENT] WHERE NOMBRE = '%" + key + "%'");
                }
            
             dt.DataSource = bridgetobd.consulta("SELECT * FROM [PRINCIPAL CLIENT]");
            }
        public void SaveDataClient ( List<TextBox> client) {
            
            cn.NAMECLIENTE = client[1].Text;
            cn.APELLIDO = client[2].Text;
            cn.DIRECCION = client[3].Text;
            cn.TELEFONO = client[4].Text;

            bridgetobd.CREATEDATOSCLIENTE(cn);

            }

        public void UpdateDataClient ( List<TextBox> client ) {
            cn.ID = int.Parse(client[0].Text);
            cn.NAMECLIENTE = client[1].Text;
            cn.APELLIDO = client[2].Text;
            cn.DIRECCION = client[3].Text;
            cn.TELEFONO = client[4].Text;

            bridgetobd.CREATEDATOSCLIENTE(cn);

            }

        public void DeleteDataClient (int id ) {
            bridgetobd.DeleteCliente(id);
            }

        }
    }
