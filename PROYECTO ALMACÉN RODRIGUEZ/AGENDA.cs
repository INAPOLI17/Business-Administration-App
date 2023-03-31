using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lógica.LIBRARY;

namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    public partial class AGENDA : Form
    {
        public AGENDA()
        {
            InitializeComponent();
            schedule = new List<object>();
            scheduleClass = new Schedule();
            }

        private List<object> schedule;
        private Schedule scheduleClass;

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
            schedule.Add(txtID);
            schedule.Add(txtNOMBREAGENDA);
            schedule.Add(txtAPELLIDOAGENDA);
            schedule.Add(txtDIRECCIONAGENDA);
            schedule.Add(txtTELEFONO);

        }

        private void btnGUARDARAGENDA_Click(object sender, EventArgs e)
        {
            scheduleClass.SaveDataSchedule(schedule);
            BUSCAR();
        }

        private void btnBORRARAGENDA_Click(object sender, EventArgs e)
        {
            scheduleClass.DeleteDataSchedule(int.Parse(txtID.Text));
            BUSCAR();
        }

        private void btnLIMPIARAGENDA_Click(object sender, EventArgs e)
        {
            txtID.Text= string.Empty;
            txtNOMBREAGENDA.Text= string.Empty;
            txtAPELLIDOAGENDA.Text= string.Empty;
            txtDIRECCIONAGENDA.Text= string.Empty ;
            txtTELEFONO.Text= string.Empty ;

        }

        public void BUSCAR()
        {
            scheduleClass.Filldata(ref dataGridView1);
        }
    }
}
