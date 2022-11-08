using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_ALMACÉN_RODRIGUEZ.CLADATOS;

namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    public partial class AGENDA : Form
    {
        public AGENDA()
        {
            InitializeComponent();
        }

        CONEXION cn = new CONEXION();
        DATOAGENDA dag = new DATOAGENDA();

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtNOMBREAGENDA.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtAPELLIDOAGENDA.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtDIRECCIONAGENDA.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtTELEFONO.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        private void AGENDA_Load(object sender, EventArgs e)
        {
             BUSCAR(@"SELECT ID_AGENDA AS[ID], NOM_AGENDA AS[NOMBRE], APE_AGENDA AS[APELLIDO], DIR_AGENDA AS[DIRECCION],
            TEL_AGENDA AS[TELEFONO] FROM AGENDA ");
        }

        private void btnGUARDARAGENDA_Click(object sender, EventArgs e)
        {
            dag.IDAGENDA = int.Parse(txtID.Text);
            dag.NOMBREAGENDA = txtNOMBREAGENDA.Text;
            dag.APELLIDOAGENDA = txtAPELLIDOAGENDA.Text;
            dag.DIRECCIONAGENDA = txtDIRECCIONAGENDA.Text;
            dag.TELEFONO = (txtTELEFONO.Text);

            cn.AGENDA(dag, "AÑADIR");
            BUSCAR(@"SELECT ID_AGENDA AS [ID], NOM_AGENDA AS [NOMBRE], APE_AGENDA AS [APELLIDO], DIR_AGENDA AS [DIRECCION],
            TEL_AGENDA AS [TELEFONO] FROM AGENDA ");
        }

        private void btnBORRARAGENDA_Click(object sender, EventArgs e)
        {
            cn.AGENDA(dag, "BORRAR");
            BUSCAR(@"SELECT ID_AGENDA AS[ID], NOM_AGENDA AS[NOMBRE], APE_AGENDA AS[APELLIDO], DIR_AGENDA AS[DIRECCION],
            TEL_AGENDA AS[TELEFONO] FROM AGENDA ");
        }

        private void btnLIMPIARAGENDA_Click(object sender, EventArgs e)
        {
            txtID.Text= string.Empty;
            txtNOMBREAGENDA.Text= string.Empty;
            txtAPELLIDOAGENDA.Text= string.Empty;
            txtDIRECCIONAGENDA.Text= string.Empty ;
            txtTELEFONO.Text= string.Empty ;

        }

        public void BUSCAR(string str)
        {
            dataGridView1.DataSource=cn.consulta(str);
        }
    }
}
