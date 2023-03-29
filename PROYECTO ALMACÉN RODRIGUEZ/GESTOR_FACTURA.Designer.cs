namespace PROYECTO_ALMACÉN_RODRIGUEZ {
    partial class GESTOR_FACTURA {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( ) {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GESTOR_FACTURA));
            pantallaGESTORFACTURA = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            gbEDITORVISUALIZADOR = new GroupBox();
            checkFECHA = new CheckBox();
            checkCLIENTE = new CheckBox();
            btnCAMBIARESTADO = new Button();
            btnPAGARFACTURA = new Button();
            btnBUCARFACTURA = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtCLIENTEGESTOR = new TextBox();
            panel3 = new Panel();
            dgvGESTORFACTURA = new DataGridView();
            panel4 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnATRASGESTOR = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pantallaGESTORFACTURA.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            gbEDITORVISUALIZADOR.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGESTORFACTURA).BeginInit();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pantallaGESTORFACTURA
            // 
            pantallaGESTORFACTURA.Controls.Add(tableLayoutPanel2);
            pantallaGESTORFACTURA.Controls.Add(tableLayoutPanel1);
            pantallaGESTORFACTURA.Dock = DockStyle.Fill;
            pantallaGESTORFACTURA.Location = new Point(0, 0);
            pantallaGESTORFACTURA.Name = "pantallaGESTORFACTURA";
            pantallaGESTORFACTURA.Size = new Size(1158, 593);
            pantallaGESTORFACTURA.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Black;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 1);
            tableLayoutPanel2.Controls.Add(panel5, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 112);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1158, 481);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(gbEDITORVISUALIZADOR);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(457, 378);
            panel2.TabIndex = 0;
            // 
            // gbEDITORVISUALIZADOR
            // 
            gbEDITORVISUALIZADOR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbEDITORVISUALIZADOR.Controls.Add(checkFECHA);
            gbEDITORVISUALIZADOR.Controls.Add(checkCLIENTE);
            gbEDITORVISUALIZADOR.Controls.Add(btnCAMBIARESTADO);
            gbEDITORVISUALIZADOR.Controls.Add(btnPAGARFACTURA);
            gbEDITORVISUALIZADOR.Controls.Add(btnBUCARFACTURA);
            gbEDITORVISUALIZADOR.Controls.Add(dateTimePicker1);
            gbEDITORVISUALIZADOR.Controls.Add(txtCLIENTEGESTOR);
            gbEDITORVISUALIZADOR.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            gbEDITORVISUALIZADOR.ForeColor = Color.White;
            gbEDITORVISUALIZADOR.Location = new Point(19, 13);
            gbEDITORVISUALIZADOR.Name = "gbEDITORVISUALIZADOR";
            gbEDITORVISUALIZADOR.Size = new Size(425, 352);
            gbEDITORVISUALIZADOR.TabIndex = 0;
            gbEDITORVISUALIZADOR.TabStop = false;
            gbEDITORVISUALIZADOR.Text = "EDITOR Y VISUALIZADOR";
            // 
            // checkFECHA
            // 
            checkFECHA.AutoSize = true;
            checkFECHA.Location = new Point(17, 114);
            checkFECHA.Name = "checkFECHA";
            checkFECHA.Size = new Size(94, 26);
            checkFECHA.TabIndex = 8;
            checkFECHA.Text = "FECHA";
            checkFECHA.UseVisualStyleBackColor = true;
            checkFECHA.CheckedChanged += checkFECHA_CheckedChanged;
            // 
            // checkCLIENTE
            // 
            checkCLIENTE.AutoSize = true;
            checkCLIENTE.Location = new Point(17, 28);
            checkCLIENTE.Name = "checkCLIENTE";
            checkCLIENTE.Size = new Size(112, 26);
            checkCLIENTE.TabIndex = 7;
            checkCLIENTE.Text = "CLIENTE";
            checkCLIENTE.UseVisualStyleBackColor = true;
            checkCLIENTE.CheckedChanged += checkCLIENTE_CheckedChanged;
            // 
            // btnCAMBIARESTADO
            // 
            btnCAMBIARESTADO.Anchor = AnchorStyles.Left;
            btnCAMBIARESTADO.BackColor = Color.FromArgb(128, 255, 255);
            btnCAMBIARESTADO.ForeColor = Color.Black;
            btnCAMBIARESTADO.Location = new Point(17, 300);
            btnCAMBIARESTADO.Name = "btnCAMBIARESTADO";
            btnCAMBIARESTADO.Size = new Size(232, 30);
            btnCAMBIARESTADO.TabIndex = 6;
            btnCAMBIARESTADO.Text = "CAMBIAR ESTADO";
            btnCAMBIARESTADO.UseVisualStyleBackColor = false;
            btnCAMBIARESTADO.Click += btnCAMBIARESTADO_Click;
            // 
            // btnPAGARFACTURA
            // 
            btnPAGARFACTURA.Anchor = AnchorStyles.Left;
            btnPAGARFACTURA.BackColor = Color.FromArgb(128, 255, 255);
            btnPAGARFACTURA.ForeColor = Color.Black;
            btnPAGARFACTURA.Location = new Point(17, 246);
            btnPAGARFACTURA.Name = "btnPAGARFACTURA";
            btnPAGARFACTURA.Size = new Size(232, 30);
            btnPAGARFACTURA.TabIndex = 5;
            btnPAGARFACTURA.Text = "PAGAR FACTURA";
            btnPAGARFACTURA.UseVisualStyleBackColor = false;
            btnPAGARFACTURA.Click += btnPAGARFACTURA_Click;
            // 
            // btnBUCARFACTURA
            // 
            btnBUCARFACTURA.Anchor = AnchorStyles.Left;
            btnBUCARFACTURA.ForeColor = Color.Black;
            btnBUCARFACTURA.Location = new Point(287, 147);
            btnBUCARFACTURA.Name = "btnBUCARFACTURA";
            btnBUCARFACTURA.Size = new Size(106, 30);
            btnBUCARFACTURA.TabIndex = 4;
            btnBUCARFACTURA.Text = "BUSCAR";
            btnBUCARFACTURA.UseVisualStyleBackColor = true;
            btnBUCARFACTURA.Click += btnBUCARFACTURA_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(17, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(174, 29);
            dateTimePicker1.TabIndex = 3;            
            // 
            // txtCLIENTEGESTOR
            // 
            txtCLIENTEGESTOR.Location = new Point(17, 59);
            txtCLIENTEGESTOR.Name = "txtCLIENTEGESTOR";
            txtCLIENTEGESTOR.Size = new Size(270, 29);
            txtCLIENTEGESTOR.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvGESTORFACTURA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(466, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(689, 378);
            panel3.TabIndex = 0;
            // 
            // dgvGESTORFACTURA
            // 
            dgvGESTORFACTURA.AllowUserToAddRows = false;
            dgvGESTORFACTURA.AllowUserToDeleteRows = false;
            dgvGESTORFACTURA.AllowUserToOrderColumns = true;
            dgvGESTORFACTURA.AllowUserToResizeColumns = false;
            dgvGESTORFACTURA.AllowUserToResizeRows = false;
            dgvGESTORFACTURA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGESTORFACTURA.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGESTORFACTURA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGESTORFACTURA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGESTORFACTURA.Dock = DockStyle.Fill;
            dgvGESTORFACTURA.EnableHeadersVisualStyles = false;
            dgvGESTORFACTURA.GridColor = SystemColors.ActiveCaptionText;
            dgvGESTORFACTURA.Location = new Point(10, 10);
            dgvGESTORFACTURA.Name = "dgvGESTORFACTURA";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGESTORFACTURA.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGESTORFACTURA.RowTemplate.Height = 25;
            dgvGESTORFACTURA.Size = new Size(669, 358);
            dgvGESTORFACTURA.TabIndex = 0;
            dgvGESTORFACTURA.DoubleClick += dgvGESTORFACTURA_DoubleClick;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 387);
            panel4.Name = "panel4";
            panel4.Size = new Size(457, 91);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(466, 387);
            panel5.Name = "panel5";
            panel5.Size = new Size(689, 91);
            panel5.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(372, 26);
            button1.Name = "button1";
            button1.Size = new Size(307, 38);
            button1.TabIndex = 0;
            button1.Text = "ELIMINAR REGISTRO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(btnATRASGESTOR, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1158, 112);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnATRASGESTOR
            // 
            btnATRASGESTOR.BackColor = SystemColors.ActiveCaption;
            btnATRASGESTOR.BackgroundImage = (Image)resources.GetObject("btnATRASGESTOR.BackgroundImage");
            btnATRASGESTOR.BackgroundImageLayout = ImageLayout.Stretch;
            btnATRASGESTOR.Dock = DockStyle.Fill;
            btnATRASGESTOR.Location = new Point(3, 3);
            btnATRASGESTOR.Name = "btnATRASGESTOR";
            btnATRASGESTOR.Size = new Size(167, 106);
            btnATRASGESTOR.TabIndex = 0;
            btnATRASGESTOR.UseVisualStyleBackColor = false;
            btnATRASGESTOR.Click += btnATRASGESTOR_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(176, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(979, 106);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 32);
            label1.Name = "label1";
            label1.Size = new Size(427, 44);
            label1.TabIndex = 1;
            label1.Text = "GESTOR DE FACTURA";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // GESTOR_FACTURA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 593);
            Controls.Add(pantallaGESTORFACTURA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GESTOR_FACTURA";
            Text = "GESTOR_FACTURA";
            Load += GESTOR_FACTURA_Load;
            pantallaGESTORFACTURA.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            gbEDITORVISUALIZADOR.ResumeLayout(false);
            gbEDITORVISUALIZADOR.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGESTORFACTURA).EndInit();
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private Panel pantallaGESTORFACTURA;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnATRASGESTOR;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private GroupBox gbEDITORVISUALIZADOR;
        private DateTimePicker dateTimePicker1;
        private TextBox txtCLIENTEGESTOR;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private CheckBox checkFECHA;
        private CheckBox checkCLIENTE;
        private Button btnCAMBIARESTADO;
        private Button btnPAGARFACTURA;
        private Button btnBUCARFACTURA;
        private DataGridView dgvGESTORFACTURA;
        private Button button1;
        }
    }