using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    public partial class ALMACEN : Form
    {
        public ALMACEN()
        {
            InitializeComponent();
        }

        CONEXION cn = new CONEXION();
        DATOSPRODUCTOS dp = new DATOSPRODUCTOS();

        

        private void btnATRASALMACEN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BUSCAR (string STRSQL)
        {
            dvgALMACEN.DataSource = cn.consulta(STRSQL);
        }

        private void ALMACEN_Load(object sender, EventArgs e)
        {
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO], PRCA.CAN_PRODUCTO AS [CANTIDAD], PRID.MED_PRODUCTO AS [MEDIDA], PRPR.PVEN_PRODUCTO AS [PRECIO VENTA],
PRDI.DIST_PRODUCTO AS [DISTRIBUIDOR], PRPR.PCOM_PRODUCTO AS [PRECIO COMPRA] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON 
PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO INNER JOIN PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO INNER JOIN PRODUCTO_DISTRIBUIDOR 
AS PRDI ON PRID.ID_PRODUCTO = PRDI.ID_PRODUCTO ;");
        }

        private void txtBUSCARPRODUCTO_Click(object sender, EventArgs e)
        {
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO], PRCA.CAN_PRODUCTO AS [CANTIDAD], PRID.MED_PRODUCTO AS [MEDIDA], PRPR.PVEN_PRODUCTO AS [PRECIO VENTA],
PRDI.DIST_PRODUCTO AS [DISTRIBUIDOR], PRPR.PCOM_PRODUCTO AS [PRECIO COMPRA] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON 
PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO INNER JOIN PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO INNER JOIN PRODUCTO_DISTRIBUIDOR 
AS PRDI ON PRID.ID_PRODUCTO = PRDI.ID_PRODUCTO WHERE PRID.ID_PRODUCTO LIKE '%" + txtBUSCARPRODUCTO.Text+"%'");
        }

        private void dvgALMACEN_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = dvgALMACEN.SelectedCells[0].Value.ToString();
            txtNOMBREPRODUCTO.Text = dvgALMACEN.SelectedCells[1].Value.ToString();
            txtCANTIDAD.Text = dvgALMACEN.SelectedCells[2].Value.ToString();
            cmbUNIDADMEDIDA.Text = dvgALMACEN.SelectedCells[3].Value.ToString();
            txtPRECIOVENTA.Text = dvgALMACEN.SelectedCells[4].Value.ToString();
            txtDISTRIBUIDOR.Text = dvgALMACEN.SelectedCells[5].Value.ToString();
            txtPRECIOCOMPRA.Text = dvgALMACEN.SelectedCells[6].Value.ToString();

        }

        private void btnLIMPIARALMACEN_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtNOMBREPRODUCTO.Text = string.Empty;
            txtCANTIDAD.Text= string.Empty;
            txtDISTRIBUIDOR.Text= string.Empty;
            txtPRECIOCOMPRA.Text = string.Empty;
            txtPRECIOVENTA.Text= string.Empty;
            cmbUNIDADMEDIDA.SelectedIndex.ToString(" "); 
        }

        private void btnGUARDARALMACEN_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty){
                dp.ID = cn.GENERARID("ALMACEN");
            }
            else
            {
                dp.ID = int.Parse(txtID.Text);
            }
            dp.NAMEPRODUCTO = txtNOMBREPRODUCTO.Text;
            dp.CANTIDAD = int.Parse(txtCANTIDAD.Text);
            dp.DISTRIBUIDOR = txtDISTRIBUIDOR.Text;
            dp.MEDIDA = cmbUNIDADMEDIDA.SelectedItem.ToString();
            dp.PRECIOCOMPRA = int.Parse(txtPRECIOCOMPRA.Text);
            dp.PRECIOVENTA = int.Parse(txtPRECIOVENTA.Text);
            MessageBox.Show(dp.MEDIDA.ToString());

            cn.DATOSALMACEN(dp, "AÑADIR");
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO], PRCA.CAN_PRODUCTO AS [CANTIDAD], PRID.MED_PRODUCTO AS [MEDIDA], PRPR.PVEN_PRODUCTO AS [PRECIO VENTA],
PRDI.DIST_PRODUCTO AS [DISTRIBUIDOR], PRPR.PCOM_PRODUCTO AS [PRECIO COMPRA] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON 
PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO INNER JOIN PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO INNER JOIN PRODUCTO_DISTRIBUIDOR 
AS PRDI ON PRID.ID_PRODUCTO = PRDI.ID_PRODUCTO ;");

        }

        private void btnELIMINARREGISTROALMACEN_Click(object sender, EventArgs e)
        {
            cn.DATOSALMACEN( dp , "BORRAR");
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO], PRCA.CAN_PRODUCTO AS [CANTIDAD], PRID.MED_PRODUCTO AS [MEDIDA], PRPR.PVEN_PRODUCTO AS [PRECIO VENTA],
PRDI.DIST_PRODUCTO AS [DISTRIBUIDOR], PRPR.PCOM_PRODUCTO AS [PRECIO COMPRA] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON 
PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO INNER JOIN PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO INNER JOIN PRODUCTO_DISTRIBUIDOR 
AS PRDI ON PRID.ID_PRODUCTO = PRDI.ID_PRODUCTO ;");

        }
    }
}
