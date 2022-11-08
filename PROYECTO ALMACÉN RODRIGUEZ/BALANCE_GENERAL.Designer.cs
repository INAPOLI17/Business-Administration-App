namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    partial class BALANCE_GENERAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pantallaBALANCEGENERAL = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPRESENTARBALANCE = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBALANCEGENERAL = new System.Windows.Forms.DataGridView();
            this.pantallaBALANCEGENERAL.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBALANCEGENERAL)).BeginInit();
            this.SuspendLayout();
            // 
            // pantallaBALANCEGENERAL
            // 
            this.pantallaBALANCEGENERAL.Controls.Add(this.tableLayoutPanel2);
            this.pantallaBALANCEGENERAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pantallaBALANCEGENERAL.Location = new System.Drawing.Point(0, 0);
            this.pantallaBALANCEGENERAL.Name = "pantallaBALANCEGENERAL";
            this.pantallaBALANCEGENERAL.Size = new System.Drawing.Size(1069, 577);
            this.pantallaBALANCEGENERAL.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1069, 577);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPRESENTARBALANCE);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(421, 455);
            this.panel2.TabIndex = 0;
            // 
            // btnPRESENTARBALANCE
            // 
            this.btnPRESENTARBALANCE.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPRESENTARBALANCE.Location = new System.Drawing.Point(22, 187);
            this.btnPRESENTARBALANCE.Name = "btnPRESENTARBALANCE";
            this.btnPRESENTARBALANCE.Size = new System.Drawing.Size(186, 39);
            this.btnPRESENTARBALANCE.TabIndex = 2;
            this.btnPRESENTARBALANCE.Text = "PRESENTAR";
            this.btnPRESENTARBALANCE.UseVisualStyleBackColor = true;
            this.btnPRESENTARBALANCE.Click += new System.EventHandler(this.btnPRESENTARBALANCE_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(354, 29);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2022, 10, 7, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "FECHA";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBALANCEGENERAL);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(430, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(30);
            this.panel3.Size = new System.Drawing.Size(636, 455);
            this.panel3.TabIndex = 1;
            // 
            // dgvBALANCEGENERAL
            // 
            this.dgvBALANCEGENERAL.AllowUserToAddRows = false;
            this.dgvBALANCEGENERAL.AllowUserToDeleteRows = false;
            this.dgvBALANCEGENERAL.AllowUserToResizeColumns = false;
            this.dgvBALANCEGENERAL.AllowUserToResizeRows = false;
            this.dgvBALANCEGENERAL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBALANCEGENERAL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBALANCEGENERAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBALANCEGENERAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBALANCEGENERAL.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBALANCEGENERAL.Location = new System.Drawing.Point(30, 30);
            this.dgvBALANCEGENERAL.Name = "dgvBALANCEGENERAL";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBALANCEGENERAL.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBALANCEGENERAL.RowTemplate.Height = 25;
            this.dgvBALANCEGENERAL.Size = new System.Drawing.Size(576, 395);
            this.dgvBALANCEGENERAL.TabIndex = 0;
            // 
            // BALANCE_GENERAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 577);
            this.Controls.Add(this.pantallaBALANCEGENERAL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BALANCE_GENERAL";
            this.Text = "BALANCE_GENERAL";
            this.Load += new System.EventHandler(this.BALANCE_GENERAL_Load);
            this.pantallaBALANCEGENERAL.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBALANCEGENERAL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pantallaBALANCEGENERAL;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Button btnPRESENTARBALANCE;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Panel panel3;
        private DataGridView dgvBALANCEGENERAL;
    }
}