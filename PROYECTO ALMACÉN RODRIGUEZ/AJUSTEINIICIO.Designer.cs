namespace PROYECTO_ALMACÉN_RODRIGUEZ {
    partial class AJUSTEINIICIO {
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
            pantallaAJUSTEINICIO = new Panel();
            groupBox1 = new GroupBox();
            btnAPLICAR = new Button();
            txtPASSNEWCONFIRM = new TextBox();
            txtPASSNEW = new TextBox();
            txtPASSACTUALLY = new TextBox();
            txtNAMEUSER = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pantallaAJUSTEINICIO.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pantallaAJUSTEINICIO
            // 
            pantallaAJUSTEINICIO.Controls.Add(groupBox1);
            pantallaAJUSTEINICIO.Dock = DockStyle.Fill;
            pantallaAJUSTEINICIO.Location = new Point(0, 0);
            pantallaAJUSTEINICIO.Name = "pantallaAJUSTEINICIO";
            pantallaAJUSTEINICIO.Size = new Size(1044, 556);
            pantallaAJUSTEINICIO.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(btnAPLICAR);
            groupBox1.Controls.Add(txtPASSNEWCONFIRM);
            groupBox1.Controls.Add(txtPASSNEW);
            groupBox1.Controls.Add(txtPASSACTUALLY);
            groupBox1.Controls.Add(txtNAMEUSER);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(130, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(777, 397);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "AJUSTE INICIO";
            // 
            // btnAPLICAR
            // 
            btnAPLICAR.BackColor = Color.FromArgb(224, 224, 224);
            btnAPLICAR.Location = new Point(517, 344);
            btnAPLICAR.Name = "btnAPLICAR";
            btnAPLICAR.Size = new Size(193, 47);
            btnAPLICAR.TabIndex = 8;
            btnAPLICAR.Text = "APLICAR";
            btnAPLICAR.UseVisualStyleBackColor = false;
            btnAPLICAR.Click += btnAPLICAR_Click;
            // 
            // txtPASSNEWCONFIRM
            // 
            txtPASSNEWCONFIRM.Anchor = AnchorStyles.None;
            txtPASSNEWCONFIRM.Location = new Point(355, 268);
            txtPASSNEWCONFIRM.Name = "txtPASSNEWCONFIRM";
            txtPASSNEWCONFIRM.Size = new Size(355, 35);
            txtPASSNEWCONFIRM.TabIndex = 7;
            // 
            // txtPASSNEW
            // 
            txtPASSNEW.Anchor = AnchorStyles.None;
            txtPASSNEW.Location = new Point(355, 191);
            txtPASSNEW.Name = "txtPASSNEW";
            txtPASSNEW.Size = new Size(355, 35);
            txtPASSNEW.TabIndex = 6;
            // 
            // txtPASSACTUALLY
            // 
            txtPASSACTUALLY.Anchor = AnchorStyles.None;
            txtPASSACTUALLY.Location = new Point(355, 118);
            txtPASSACTUALLY.Name = "txtPASSACTUALLY";
            txtPASSACTUALLY.Size = new Size(355, 35);
            txtPASSACTUALLY.TabIndex = 5;
            // 
            // txtNAMEUSER
            // 
            txtNAMEUSER.Anchor = AnchorStyles.None;
            txtNAMEUSER.Location = new Point(355, 52);
            txtNAMEUSER.Name = "txtNAMEUSER";
            txtNAMEUSER.Size = new Size(355, 35);
            txtNAMEUSER.TabIndex = 4;
            // 
            // label4
            // 
            label4.Location = new Point(32, 268);
            label4.Name = "label4";
            label4.Size = new Size(250, 66);
            label4.TabIndex = 3;
            label4.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 197);
            label3.Name = "label3";
            label3.Size = new Size(267, 29);
            label3.TabIndex = 2;
            label3.Text = "CONTRASEÑA NUEVA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 124);
            label2.Name = "label2";
            label2.Size = new Size(283, 29);
            label2.TabIndex = 1;
            label2.Text = "CONTRASEÑA ACTUAL";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(32, 58);
            label1.Name = "label1";
            label1.Size = new Size(275, 29);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE DE USUARIO";
            // 
            // AJUSTEINIICIO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 556);
            Controls.Add(pantallaAJUSTEINICIO);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AJUSTEINIICIO";
            Text = "AJUSTEINIICIO";
            Load += AJUSTEINIICIO_Load;
            pantallaAJUSTEINICIO.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            }

        #endregion

        private Panel pantallaAJUSTEINICIO;
        private GroupBox groupBox1;
        private TextBox txtNAMEUSER;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAPLICAR;
        private TextBox txtPASSNEWCONFIRM;
        private TextBox txtPASSNEW;
        private TextBox txtPASSACTUALLY;
        }
    }