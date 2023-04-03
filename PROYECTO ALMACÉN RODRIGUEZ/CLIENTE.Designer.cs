namespace PROYECTO_ALMACÉN_RODRIGUEZ {
    partial class CLIENTE {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLIENTE));
            pantallaCLIENTE = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            gbEDITARCLIENTE = new GroupBox();
            txtTELEFONO = new TextBox();
            txtDIRECCION = new TextBox();
            txtApellido = new TextBox();
            txtNOMBRECLIENTE = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnGUARDARCLIENTE = new Button();
            btnLIMPIARCLIENTE = new Button();
            panel3 = new Panel();
            dgvCLIENTES = new DataGridView();
            panel4 = new Panel();
            btnBUSCARCLIENTES = new Button();
            txtCLIENTESSEARCH = new TextBox();
            btnBORRARCLIENTE = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnATRASCLIENTE = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TXTID = new TextBox();
            pantallaCLIENTE.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            gbEDITARCLIENTE.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCLIENTES).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pantallaCLIENTE
            // 
            pantallaCLIENTE.Controls.Add(tableLayoutPanel2);
            pantallaCLIENTE.Controls.Add(tableLayoutPanel1);
            pantallaCLIENTE.Dock = DockStyle.Fill;
            pantallaCLIENTE.Location = new Point(0, 0);
            pantallaCLIENTE.Name = "pantallaCLIENTE";
            pantallaCLIENTE.Size = new Size(1149, 611);
            pantallaCLIENTE.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Black;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(gbEDITARCLIENTE, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 100);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1149, 511);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // gbEDITARCLIENTE
            // 
            gbEDITARCLIENTE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbEDITARCLIENTE.Controls.Add(TXTID);
            gbEDITARCLIENTE.Controls.Add(txtTELEFONO);
            gbEDITARCLIENTE.Controls.Add(txtDIRECCION);
            gbEDITARCLIENTE.Controls.Add(txtApellido);
            gbEDITARCLIENTE.Controls.Add(txtNOMBRECLIENTE);
            gbEDITARCLIENTE.Controls.Add(label6);
            gbEDITARCLIENTE.Controls.Add(label5);
            gbEDITARCLIENTE.Controls.Add(label4);
            gbEDITARCLIENTE.Controls.Add(label2);
            gbEDITARCLIENTE.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbEDITARCLIENTE.ForeColor = Color.White;
            gbEDITARCLIENTE.Location = new Point(3, 3);
            gbEDITARCLIENTE.Name = "gbEDITARCLIENTE";
            gbEDITARCLIENTE.Size = new Size(338, 402);
            gbEDITARCLIENTE.TabIndex = 2;
            gbEDITARCLIENTE.TabStop = false;
            gbEDITARCLIENTE.Text = "EDITOR";
            // 
            // txtTELEFONO
            // 
            txtTELEFONO.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTELEFONO.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTELEFONO.Location = new Point(9, 273);
            txtTELEFONO.Name = "txtTELEFONO";
            txtTELEFONO.Size = new Size(287, 29);
            txtTELEFONO.TabIndex = 8;
            // 
            // txtDIRECCION
            // 
            txtDIRECCION.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDIRECCION.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDIRECCION.Location = new Point(9, 204);
            txtDIRECCION.Name = "txtDIRECCION";
            txtDIRECCION.Size = new Size(287, 29);
            txtDIRECCION.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.Location = new Point(9, 132);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(287, 29);
            txtApellido.TabIndex = 6;
            // 
            // txtNOMBRECLIENTE
            // 
            txtNOMBRECLIENTE.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNOMBRECLIENTE.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNOMBRECLIENTE.Location = new Point(9, 54);
            txtNOMBRECLIENTE.Name = "txtNOMBRECLIENTE";
            txtNOMBRECLIENTE.Size = new Size(287, 29);
            txtNOMBRECLIENTE.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(9, 251);
            label6.Name = "label6";
            label6.Size = new Size(97, 19);
            label6.TabIndex = 3;
            label6.Text = "TELEFONO";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(9, 182);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 2;
            label5.Text = "DIRECCION";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(9, 110);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 1;
            label4.Text = "APELLIDO";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(9, 32);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 0;
            label2.Text = "NOMBRE";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGUARDARCLIENTE);
            panel2.Controls.Add(btnLIMPIARCLIENTE);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 411);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 97);
            panel2.TabIndex = 3;
            // 
            // btnGUARDARCLIENTE
            // 
            btnGUARDARCLIENTE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGUARDARCLIENTE.BackColor = Color.Cyan;
            btnGUARDARCLIENTE.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGUARDARCLIENTE.Location = new Point(208, 27);
            btnGUARDARCLIENTE.Margin = new Padding(10);
            btnGUARDARCLIENTE.Name = "btnGUARDARCLIENTE";
            btnGUARDARCLIENTE.Padding = new Padding(2);
            btnGUARDARCLIENTE.Size = new Size(127, 37);
            btnGUARDARCLIENTE.TabIndex = 1;
            btnGUARDARCLIENTE.Text = "GUARDAR";
            btnGUARDARCLIENTE.UseVisualStyleBackColor = false;
            btnGUARDARCLIENTE.Click += btnGUARDARCLIENTE_Click;
            // 
            // btnLIMPIARCLIENTE
            // 
            btnLIMPIARCLIENTE.Anchor = AnchorStyles.Left;
            btnLIMPIARCLIENTE.BackColor = Color.FromArgb(192, 0, 0);
            btnLIMPIARCLIENTE.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLIMPIARCLIENTE.Location = new Point(3, 27);
            btnLIMPIARCLIENTE.Margin = new Padding(10);
            btnLIMPIARCLIENTE.Name = "btnLIMPIARCLIENTE";
            btnLIMPIARCLIENTE.Padding = new Padding(2);
            btnLIMPIARCLIENTE.Size = new Size(127, 37);
            btnLIMPIARCLIENTE.TabIndex = 0;
            btnLIMPIARCLIENTE.Text = "LIMPIAR";
            btnLIMPIARCLIENTE.UseVisualStyleBackColor = false;
            btnLIMPIARCLIENTE.Click += btnLIMPIARCLIENTE_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvCLIENTES);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(347, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(799, 402);
            panel3.TabIndex = 4;
            // 
            // dgvCLIENTES
            // 
            dgvCLIENTES.AllowUserToAddRows = false;
            dgvCLIENTES.AllowUserToDeleteRows = false;
            dgvCLIENTES.AllowUserToResizeColumns = false;
            dgvCLIENTES.AllowUserToResizeRows = false;
            dgvCLIENTES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCLIENTES.BackgroundColor = Color.Gray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCLIENTES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCLIENTES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCLIENTES.Dock = DockStyle.Fill;
            dgvCLIENTES.EnableHeadersVisualStyles = false;
            dgvCLIENTES.GridColor = Color.Black;
            dgvCLIENTES.Location = new Point(10, 10);
            dgvCLIENTES.Name = "dgvCLIENTES";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCLIENTES.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCLIENTES.RowTemplate.Height = 25;
            dgvCLIENTES.Size = new Size(779, 382);
            dgvCLIENTES.TabIndex = 0;
            dgvCLIENTES.DoubleClick += dgvCLIENTES_DoubleClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnBUSCARCLIENTES);
            panel4.Controls.Add(txtCLIENTESSEARCH);
            panel4.Controls.Add(btnBORRARCLIENTE);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(347, 411);
            panel4.Name = "panel4";
            panel4.Size = new Size(799, 97);
            panel4.TabIndex = 5;
            // 
            // btnBUSCARCLIENTES
            // 
            btnBUSCARCLIENTES.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBUSCARCLIENTES.Location = new Point(263, 27);
            btnBUSCARCLIENTES.Name = "btnBUSCARCLIENTES";
            btnBUSCARCLIENTES.Size = new Size(124, 35);
            btnBUSCARCLIENTES.TabIndex = 7;
            btnBUSCARCLIENTES.Text = "BUSCAR";
            btnBUSCARCLIENTES.UseVisualStyleBackColor = true;
            btnBUSCARCLIENTES.Click += btnBUSCARCLIENTES_Click;
            // 
            // txtCLIENTESSEARCH
            // 
            txtCLIENTESSEARCH.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtCLIENTESSEARCH.Location = new Point(10, 27);
            txtCLIENTESSEARCH.Name = "txtCLIENTESSEARCH";
            txtCLIENTESSEARCH.Size = new Size(237, 35);
            txtCLIENTESSEARCH.TabIndex = 6;
            // 
            // btnBORRARCLIENTE
            // 
            btnBORRARCLIENTE.Anchor = AnchorStyles.Right;
            btnBORRARCLIENTE.BackColor = Color.FromArgb(192, 0, 0);
            btnBORRARCLIENTE.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBORRARCLIENTE.Location = new Point(558, 27);
            btnBORRARCLIENTE.Margin = new Padding(10);
            btnBORRARCLIENTE.Name = "btnBORRARCLIENTE";
            btnBORRARCLIENTE.Padding = new Padding(2);
            btnBORRARCLIENTE.Size = new Size(225, 37);
            btnBORRARCLIENTE.TabIndex = 5;
            btnBORRARCLIENTE.Text = "ELIMINAR REGISTRO";
            btnBORRARCLIENTE.UseVisualStyleBackColor = false;
            btnBORRARCLIENTE.Click += btnBORRARCLIENTE_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(btnATRASCLIENTE, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1149, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnATRASCLIENTE
            // 
            btnATRASCLIENTE.BackColor = SystemColors.ActiveCaption;
            btnATRASCLIENTE.BackgroundImage = (Image)resources.GetObject("btnATRASCLIENTE.BackgroundImage");
            btnATRASCLIENTE.BackgroundImageLayout = ImageLayout.Stretch;
            btnATRASCLIENTE.Dock = DockStyle.Fill;
            btnATRASCLIENTE.Location = new Point(3, 3);
            btnATRASCLIENTE.Name = "btnATRASCLIENTE";
            btnATRASCLIENTE.Size = new Size(166, 94);
            btnATRASCLIENTE.TabIndex = 0;
            btnATRASCLIENTE.UseVisualStyleBackColor = false;
            btnATRASCLIENTE.Click += btnATRASCLIENTE_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(175, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 94);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(10);
            pictureBox1.Size = new Size(137, 86);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(146, 6);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(250, 76);
            label1.TabIndex = 0;
            label1.Text = "CLIENTE";
            // 
            // TXTID
            // 
            TXTID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TXTID.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TXTID.Location = new Point(279, 363);
            TXTID.Name = "TXTID";
            TXTID.ReadOnly = true;
            TXTID.Size = new Size(53, 29);
            TXTID.TabIndex = 9;
            // 
            // CLIENTE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 611);
            Controls.Add(pantallaCLIENTE);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CLIENTE";
            Text = "CLIENTE";
            Load += CLIENTE_Load;
            pantallaCLIENTE.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            gbEDITARCLIENTE.ResumeLayout(false);
            gbEDITARCLIENTE.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCLIENTES).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private Panel pantallaCLIENTE;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnATRASCLIENTE;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox gbEDITARCLIENTE;
        private TextBox txtApellido;
        private TextBox txtNOMBRECLIENTE;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txtTELEFONO;
        private TextBox txtDIRECCION;
        private Panel panel2;
        private Button btnGUARDARCLIENTE;
        private Button btnLIMPIARCLIENTE;
        private Panel panel3;
        private DataGridView dgvCLIENTES;
        private Button btnBORRARCLIENTE;
        private Panel panel4;
        private Button btnBUSCARCLIENTES;
        private TextBox txtCLIENTESSEARCH;
        private TextBox TXTID;
        }
    }