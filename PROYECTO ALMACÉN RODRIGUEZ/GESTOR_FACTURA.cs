using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ALMACÉN_RODRIGUEZ {
    public partial class GESTOR_FACTURA : Form {
        public GESTOR_FACTURA ( ) {
            InitializeComponent();


        }

        private void btnATRASGESTOR_Click ( object sender, EventArgs e ) {
            this.Close();
            }

        private void GESTOR_FACTURA_Load ( object sender, EventArgs e ) {
            BUSCAR(@"SELECT FAID.ID_FACTURA AS [ID], FAID.NOM_CLIENTE AS [CLIENTE], FAID.FEC_FACTURA AS [FECHA], FADI.DIR_FACTURA AS [DIRECCION],
FAES.EST_FACTURA AS [ESTADO], FAES.TIP_FACTURA AS [TIPO], FAID.TOT_FACTURA AS [TOTAL] FROM [FACTURA ID] AS FAID INNER JOIN FACTURA_DIRECCION AS FADI ON FAID.ID_FACTURA = FADI.ID_FACTURA INNER JOIN FACTURA_ESTADO AS
FAES ON FAID.ID_FACTURA = FAES.ID_FACTURA ");

            txtCLIENTEGESTOR.Enabled = false;
            dateTimePicker1.Enabled = false;
            btnBUCARFACTURA.Enabled = false;
            btnCAMBIARESTADO.Enabled = false;
            btnPAGARFACTURA.Enabled = false;

            }

        private void BUSCAR ( string STRSQL ) {
            dgvGESTORFACTURA.DataSource = cn.consulta(STRSQL);
            }

        Func<CheckBox, bool> Active = e => e.Checked = true;

        public void Validation (ref CheckBox date, ref CheckBox name ) {
            txtCLIENTEGESTOR.Enabled = Active(name);
            dateTimePicker1.Enabled = Active(date);
            btnBUCARFACTURA.Enabled = Active(date) || Active(name);
            }
        private void btnBUCARFACTURA_Click ( object sender, EventArgs e ) {
                
            }

        private void checkCLIENTE_CheckedChanged ( object sender, EventArgs e ) {
            Validation(ref checkFECHA, ref checkCLIENTE);
            }

        private void checkFECHA_CheckedChanged ( object sender, EventArgs e ) {
            Validation(ref checkFECHA, ref checkCLIENTE);
            }

        private void dgvGESTORFACTURA_DoubleClick ( object sender, EventArgs e ) {
            df.ID = int.Parse(dgvGESTORFACTURA.SelectedCells[0].Value.ToString());
            df.NAMECLIENTE = dgvGESTORFACTURA.SelectedCells[2].Value.ToString();
            btnBUCARFACTURA.Enabled = true;
            dateTimePicker1.Enabled = true;
            }

        private void btnPAGARFACTURA_Click ( object sender, EventArgs e ) {
            df.TIPOFACTURA = "EFECTIVO";
            cn.DATOSFACTURA(df, "ESTADO");
            cn.DATOSFACTURA(df, "PAGO");
            }

        private void btnCAMBIARESTADO_Click ( object sender, EventArgs e ) {
            df.TIPOFACTURA = string.Empty;

            if (dgvGESTORFACTURA.SelectedCells[4].Value.ToString() == "ENTREGADO") {
                df.ESTADO = "NO ENTREGADO";
                } else {
                df.ESTADO = "ENTREGADO";
                }

            cn.DATOSFACTURA(df, "ESTADO");
            }

        private void button1_Click ( object sender, EventArgs e ) {
            btnBUCARFACTURA.Focus();
            }

       
        }
    }
