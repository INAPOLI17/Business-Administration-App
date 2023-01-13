﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGIC;

namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    public partial class CLIENTE : Form
    {
        public CLIENTE()
        {
            InitializeComponent();
            Data = new List<object>();
            Data.Add(TXTID);
            Data.Add(txtNOMBRECLIENTE);
            Data.Add(txtApellido);
            Data.Add(txtDIRECCION);
            Data.Add(txtTELEFONO);

            function = new LOGICA();
        }

        private LOGICA function;
        private List<object> Data; 

        private void btnATRASCLIENTE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBUSCARCLIENTES_Click(object sender, EventArgs e)
        {
            BUSCAR(@"SELECT CLDI.ID_CLIENTE AS [ID], CLID.NOM_CLIENTE AS [NOMBRE], CLID.APE_CLIENTE AS [APELLIDO], CLDI.DIR_CLIENTE AS [DIRECCION],
CLTE.TEL_CLIENTE AS [TELEFONO], CLID.FEC_CLIENTE AS [FECHA] FROM CLIENTE_ID AS CLID INNER JOIN CLIENTE_DIRECCION AS CLDI ON CLID.ID_CLIENTE = CLDI.ID_CLIENTE
INNER JOIN CLIENTE_TELEFONO AS CLTE ON CLID.ID_CLIENTE = CLTE.ID_CLIENTE WHERE CLID.NOM_CLIENTE LIKE '%"+txtCLIENTES.Text+"%'");
        }

        public void BUSCAR (string STRSQL)
        {
            dgvCLIENTES.DataSource = cn.consulta(STRSQL);
        }

        private void CLIENTE_Load(object sender, EventArgs e)
        {
            BUSCAR(@"SELECT CI.ID_CLIENTE AS [ID], CI.NOM_CLIENTE AS [NOMBRE], CI.APE_CLIENTE AS [APELLIDO], CD.DIR_CLIENTE, CT.TEL_CLIENTE AS [TELEFONO], CI.FEC_CLIENTE AS [FECHA]
FROM CLIENTE_ID AS CI INNER JOIN CLIENTE_DIRECCION AS CD ON CI.ID_CLIENTE = CD.ID_CLIENTE INNER JOIN CLIENTE_TELEFONO AS CT ON CI.ID_CLIENTE = CT.ID_CLIENTE");

            TXTID.Text = cn.GENERARID("CLIENTE").ToString();
        }

        private void dgvCLIENTES_DoubleClick(object sender, EventArgs e)
        {
            TXTID.Text = dgvCLIENTES.SelectedCells[0].Value.ToString();
            txtNOMBRECLIENTE.Text = dgvCLIENTES.SelectedCells[1].Value.ToString();
            txtApellido.Text = dgvCLIENTES.SelectedCells[2].Value.ToString();
            txtDIRECCION.Text = dgvCLIENTES.SelectedCells[3].Value.ToString();
            txtTELEFONO.Text = dgvCLIENTES.SelectedCells[4].Value.ToString();

        }

        private void btnLIMPIARCLIENTE_Click(object sender, EventArgs e)
        {
            foreach (var i in Data) {
                Data[i].Text = string.Empty;
                }
        }

        private void btnGUARDARCLIENTE_Click(object sender, EventArgs e)
        {
            function.client.SaveDataClient(Data);
            BUSCAR(@"SELECT CI.ID_CLIENTE AS [ID], CI.NOM_CLIENTE AS [NOMBRE], CI.APE_CLIENTE AS [APELLIDO], CD.DIR_CLIENTE, CT.TEL_CLIENTE AS [TELEFONO], CI.FEC_CLIENTE AS [FECHA]
FROM CLIENTE_ID AS CI INNER JOIN CLIENTE_DIRECCION AS CD ON CI.ID_CLIENTE = CD.ID_CLIENTE INNER JOIN CLIENTE_TELEFONO AS CT ON CI.ID_CLIENTE = CT.ID_CLIENTE");
        }

        private void btnBORRARCLIENTE_Click(object sender, EventArgs e)
        {

            function.client.DeleteDataClient(int.Parse(dgvCLIENTES.SelectedCells[0].Value.ToString()));
            BUSCAR(@"SELECT CI.ID_CLIENTE AS [ID], CI.NOM_CLIENTE AS [NOMBRE], CI.APE_CLIENTE AS [APELLIDO], CD.DIR_CLIENTE, CT.TEL_CLIENTE AS [TELEFONO], 
CI.FEC_CLIENTE AS [FECHA] FROM CLIENTE_ID AS CI INNER JOIN CLIENTE_DIRECCION AS CD ON CI.ID_CLIENTE = CD.ID_CLIENTE INNER JOIN CLIENTE_TELEFONO AS CT ON 
CI.ID_CLIENTE = CT.ID_CLIENTE");
        }
    }
}
