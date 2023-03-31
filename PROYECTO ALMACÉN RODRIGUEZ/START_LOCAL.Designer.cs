namespace INTERFACE {
    partial class INICIO {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( ) {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pantalla = new Panel();
            pantallaright = new Panel();
            dgvDETALLEFACTURA = new DataGridView();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            rdbNOENTREGADO = new RadioButton();
            rdbENTREGADO = new RadioButton();
            groupBox2 = new GroupBox();
            rdbEFECTIVO = new RadioButton();
            rdbCREDITO = new RadioButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            panel5 = new Panel();
            cmbNAMECLIENT = new ComboBox();
            label7 = new Label();
            panel6 = new Panel();
            cmbDIRECTIONCLEINT = new ComboBox();
            label8 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel2 = new Panel();
            txtDESCUENTO = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txtTOTALNETO = new TextBox();
            label4 = new Label();
            txtTotal = new TextBox();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnEliminarRegistro = new Button();
            btnGenerar = new Button();
            btnLimpiar = new Button();
            pantalla_left = new Panel();
            groupBox1 = new GroupBox();
            btnCarga = new Button();
            dgvADDPRODUCTOS = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            txtCANTIDADDETALLE = new TextBox();
            btnBuscarproducto = new Button();
            txtProductos = new TextBox();
            pantalla.SuspendLayout();
            pantallaright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDETALLEFACTURA).BeginInit();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            pantalla_left.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvADDPRODUCTOS).BeginInit();
            SuspendLayout();
            // 
            // pantalla
            // 
            pantalla.Controls.Add(pantallaright);
            pantalla.Controls.Add(pantalla_left);
            pantalla.Dock = DockStyle.Fill;
            pantalla.Location = new Point(0, 0);
            pantalla.Name = "pantalla";
            pantalla.Size = new Size(1400, 700);
            pantalla.TabIndex = 0;
            // 
            // pantallaright
            // 
            pantallaright.BackColor = Color.Black;
            pantallaright.Controls.Add(dgvDETALLEFACTURA);
            pantallaright.Controls.Add(panel1);
            pantallaright.Controls.Add(tableLayoutPanel4);
            pantallaright.Controls.Add(tableLayoutPanel3);
            pantallaright.Dock = DockStyle.Fill;
            pantallaright.Location = new Point(450, 0);
            pantallaright.Name = "pantallaright";
            pantallaright.Padding = new Padding(5);
            pantallaright.Size = new Size(950, 700);
            pantallaright.TabIndex = 2;
            // 
            // dgvDETALLEFACTURA
            // 
            dgvDETALLEFACTURA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDETALLEFACTURA.BackgroundColor = Color.Gray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDETALLEFACTURA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDETALLEFACTURA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDETALLEFACTURA.Dock = DockStyle.Fill;
            dgvDETALLEFACTURA.Location = new Point(5, 167);
            dgvDETALLEFACTURA.Name = "dgvDETALLEFACTURA";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDETALLEFACTURA.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDETALLEFACTURA.RowTemplate.Height = 25;
            dgvDETALLEFACTURA.Size = new Size(940, 387);
            dgvDETALLEFACTURA.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 162);
            panel1.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(rdbNOENTREGADO);
            groupBox3.Controls.Add(rdbENTREGADO);
            groupBox3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(768, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(165, 152);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "ESTADO";
            // 
            // rdbNOENTREGADO
            // 
            rdbNOENTREGADO.Location = new Point(23, 87);
            rdbNOENTREGADO.Name = "rdbNOENTREGADO";
            rdbNOENTREGADO.Size = new Size(130, 43);
            rdbNOENTREGADO.TabIndex = 1;
            rdbNOENTREGADO.TabStop = true;
            rdbNOENTREGADO.Text = "NO ENTREGADO";
            rdbNOENTREGADO.UseVisualStyleBackColor = true;
            // 
            // rdbENTREGADO
            // 
            rdbENTREGADO.AutoSize = true;
            rdbENTREGADO.Location = new Point(23, 36);
            rdbENTREGADO.Name = "rdbENTREGADO";
            rdbENTREGADO.Size = new Size(130, 23);
            rdbENTREGADO.TabIndex = 0;
            rdbENTREGADO.TabStop = true;
            rdbENTREGADO.Text = "ENTREGADO";
            rdbENTREGADO.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(rdbEFECTIVO);
            groupBox2.Controls.Add(rdbCREDITO);
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(590, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(165, 152);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "TIPO";
            // 
            // rdbEFECTIVO
            // 
            rdbEFECTIVO.AutoSize = true;
            rdbEFECTIVO.Location = new Point(21, 97);
            rdbEFECTIVO.Name = "rdbEFECTIVO";
            rdbEFECTIVO.Size = new Size(108, 23);
            rdbEFECTIVO.TabIndex = 1;
            rdbEFECTIVO.TabStop = true;
            rdbEFECTIVO.Text = "EFECTIVO";
            rdbEFECTIVO.UseVisualStyleBackColor = true;
            // 
            // rdbCREDITO
            // 
            rdbCREDITO.AutoSize = true;
            rdbCREDITO.Location = new Point(21, 36);
            rdbCREDITO.Name = "rdbCREDITO";
            rdbCREDITO.Size = new Size(100, 23);
            rdbCREDITO.TabIndex = 0;
            rdbCREDITO.TabStop = true;
            rdbCREDITO.Text = "CREDITO";
            rdbCREDITO.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Controls.Add(panel5, 0, 1);
            tableLayoutPanel2.Controls.Add(panel6, 0, 2);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Size = new Size(581, 150);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(207, 32);
            label6.TabIndex = 11;
            label6.Text = "FACTURADOR";
            // 
            // panel5
            // 
            panel5.Controls.Add(cmbNAMECLIENT);
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(6, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(569, 42);
            panel5.TabIndex = 12;
            // 
            // cmbNAMECLIENT
            // 
            cmbNAMECLIENT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbNAMECLIENT.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cmbNAMECLIENT.ForeColor = Color.Black;
            cmbNAMECLIENT.FormattingEnabled = true;
            cmbNAMECLIENT.Location = new Point(181, 7);
            cmbNAMECLIENT.Name = "cmbNAMECLIENT";
            cmbNAMECLIENT.Size = new Size(367, 30);
            cmbNAMECLIENT.TabIndex = 1;
            cmbNAMECLIENT.Text = " ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(8, 10);
            label7.Name = "label7";
            label7.Size = new Size(93, 22);
            label7.TabIndex = 0;
            label7.Text = "CLIENTE";
            // 
            // panel6
            // 
            panel6.Controls.Add(cmbDIRECTIONCLEINT);
            panel6.Controls.Add(label8);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(6, 101);
            panel6.Name = "panel6";
            panel6.Size = new Size(569, 43);
            panel6.TabIndex = 13;
            // 
            // cmbDIRECTIONCLEINT
            // 
            cmbDIRECTIONCLEINT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbDIRECTIONCLEINT.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDIRECTIONCLEINT.FormattingEnabled = true;
            cmbDIRECTIONCLEINT.Location = new Point(181, 6);
            cmbDIRECTIONCLEINT.Name = "cmbDIRECTIONCLEINT";
            cmbDIRECTIONCLEINT.Size = new Size(367, 30);
            cmbDIRECTIONCLEINT.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(7, 14);
            label8.Name = "label8";
            label8.Size = new Size(116, 22);
            label8.TabIndex = 0;
            label8.Text = "DIRECCION";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel2, 0, 0);
            tableLayoutPanel4.Controls.Add(panel3, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(5, 554);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(940, 81);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDESCUENTO);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 75);
            panel2.TabIndex = 0;
            // 
            // txtDESCUENTO
            // 
            txtDESCUENTO.Anchor = AnchorStyles.Left;
            txtDESCUENTO.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDESCUENTO.Location = new Point(169, 16);
            txtDESCUENTO.Name = "txtDESCUENTO";
            txtDESCUENTO.Size = new Size(100, 29);
            txtDESCUENTO.TabIndex = 1;
            txtDESCUENTO.Text = "00";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 21);
            label2.Name = "label2";
            label2.Size = new Size(139, 24);
            label2.TabIndex = 0;
            label2.Text = "DESCUENTO";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTOTALNETO);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(473, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(464, 75);
            panel3.TabIndex = 0;
            // 
            // txtTOTALNETO
            // 
            txtTOTALNETO.Anchor = AnchorStyles.Right;
            txtTOTALNETO.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTOTALNETO.Location = new Point(279, 37);
            txtTOTALNETO.Name = "txtTOTALNETO";
            txtTOTALNETO.Size = new Size(169, 29);
            txtTOTALNETO.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 39);
            label4.Name = "label4";
            label4.Size = new Size(141, 24);
            label4.TabIndex = 3;
            label4.Text = "TOTAL NETO";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Right;
            txtTotal.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(279, -2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(169, 29);
            txtTotal.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 3);
            label3.Name = "label3";
            label3.Size = new Size(78, 24);
            label3.TabIndex = 0;
            label3.Text = "TOTAL";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Controls.Add(btnEliminarRegistro, 1, 0);
            tableLayoutPanel3.Controls.Add(btnGenerar, 2, 0);
            tableLayoutPanel3.Controls.Add(btnLimpiar, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(5, 635);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(940, 60);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnEliminarRegistro
            // 
            btnEliminarRegistro.Anchor = AnchorStyles.None;
            btnEliminarRegistro.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminarRegistro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarRegistro.Location = new Point(336, 5);
            btnEliminarRegistro.Name = "btnEliminarRegistro";
            btnEliminarRegistro.Size = new Size(173, 49);
            btnEliminarRegistro.TabIndex = 2;
            btnEliminarRegistro.Text = "ELIMINAR REGISTRO";
            btnEliminarRegistro.UseVisualStyleBackColor = false;
            btnEliminarRegistro.Click += btnEliminarRegistro_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.None;
            btnGenerar.BackColor = Color.FromArgb(0, 192, 0);
            btnGenerar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerar.Location = new Point(624, 11);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(255, 38);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "GENERAR FACTURA";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(54, 11);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(173, 38);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pantalla_left
            // 
            pantalla_left.BackColor = Color.FromArgb(64, 64, 64);
            pantalla_left.Controls.Add(groupBox1);
            pantalla_left.Dock = DockStyle.Left;
            pantalla_left.Location = new Point(0, 0);
            pantalla_left.Name = "pantalla_left";
            pantalla_left.Size = new Size(450, 700);
            pantalla_left.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCarga);
            groupBox1.Controls.Add(dgvADDPRODUCTOS);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCANTIDADDETALLE);
            groupBox1.Controls.Add(btnBuscarproducto);
            groupBox1.Controls.Add(txtProductos);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(450, 700);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PRODUCTOS";
            // 
            // btnCarga
            // 
            btnCarga.ForeColor = Color.Black;
            btnCarga.Location = new Point(21, 115);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(32, 24);
            btnCarga.TabIndex = 6;
            btnCarga.Text = "C";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // dgvADDPRODUCTOS
            // 
            dgvADDPRODUCTOS.AllowUserToAddRows = false;
            dgvADDPRODUCTOS.AllowUserToDeleteRows = false;
            dgvADDPRODUCTOS.AllowUserToResizeColumns = false;
            dgvADDPRODUCTOS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvADDPRODUCTOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvADDPRODUCTOS.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvADDPRODUCTOS.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvADDPRODUCTOS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvADDPRODUCTOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvADDPRODUCTOS.ColumnHeadersHeight = 30;
            dgvADDPRODUCTOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvADDPRODUCTOS.DefaultCellStyle = dataGridViewCellStyle4;
            dgvADDPRODUCTOS.EnableHeadersVisualStyles = false;
            dgvADDPRODUCTOS.GridColor = SystemColors.ActiveCaptionText;
            dgvADDPRODUCTOS.Location = new Point(21, 142);
            dgvADDPRODUCTOS.Name = "dgvADDPRODUCTOS";
            dgvADDPRODUCTOS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvADDPRODUCTOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvADDPRODUCTOS.RowTemplate.Height = 25;
            dgvADDPRODUCTOS.Size = new Size(406, 539);
            dgvADDPRODUCTOS.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(307, 80);
            button1.Name = "button1";
            button1.Size = new Size(120, 30);
            button1.TabIndex = 4;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 71);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 3;
            label1.Text = "CANTIDAD";
            // 
            // txtCANTIDADDETALLE
            // 
            txtCANTIDADDETALLE.Location = new Point(127, 68);
            txtCANTIDADDETALLE.Name = "txtCANTIDADDETALLE";
            txtCANTIDADDETALLE.Size = new Size(108, 29);
            txtCANTIDADDETALLE.TabIndex = 2;
            // 
            // btnBuscarproducto
            // 
            btnBuscarproducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarproducto.ForeColor = Color.Black;
            btnBuscarproducto.Location = new Point(324, 27);
            btnBuscarproducto.Name = "btnBuscarproducto";
            btnBuscarproducto.Size = new Size(103, 30);
            btnBuscarproducto.TabIndex = 1;
            btnBuscarproducto.Text = "BUSCAR";
            btnBuscarproducto.UseVisualStyleBackColor = true;
            btnBuscarproducto.Click += btnBuscarproducto_Click;
            // 
            // txtProductos
            // 
            txtProductos.Location = new Point(12, 28);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(223, 29);
            txtProductos.TabIndex = 0;
            // 
            // INICIO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 700);
            Controls.Add(pantalla);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1400, 700);
            Name = "INICIO";
            Text = "Form1";
            Load += INICIO_Load;
            pantalla.ResumeLayout(false);
            pantallaright.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDETALLEFACTURA).EndInit();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            pantalla_left.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvADDPRODUCTOS).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private Panel pantalla;
        private Panel pantallaright;
        private Panel pantalla_left;
        private GroupBox groupBox1;
        private DataGridView dgvADDPRODUCTOS;
        private Button button1;
        private Label label1;
        private TextBox txtCANTIDADDETALLE;
        private Button btnBuscarproducto;
        private TextBox txtProductos;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnEliminarRegistro;
        private Button btnGenerar;
        private Button btnLimpiar;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private Panel panel5;
        private ComboBox cmbNAMECLIENT;
        private Label label7;
        private Panel panel6;
        private Label label8;
        private ComboBox cmbDIRECTIONCLEINT;
        private Panel panel1;
        private GroupBox groupBox3;
        private RadioButton rdbNOENTREGADO;
        private RadioButton rdbENTREGADO;
        private GroupBox groupBox2;
        private RadioButton rdbEFECTIVO;
        private RadioButton rdbCREDITO;
        private Panel panel2;
        private TextBox txtDESCUENTO;
        private Label label2;
        private Panel panel3;
        private TextBox txtTOTALNETO;
        private Label label4;
        private TextBox txtTotal;
        private Label label3;
        private DataGridView dgvDETALLEFACTURA;
        private Button btnCarga;
        }
    }