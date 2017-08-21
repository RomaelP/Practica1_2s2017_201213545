namespace PR1_EDD
{
    partial class ColaMensajes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbPostorden = new System.Windows.Forms.TextBox();
            this.txbInorden = new System.Windows.Forms.TextBox();
            this.txbOperacion = new System.Windows.Forms.TextBox();
            this.txbIp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCarnet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BOperar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.etiTam = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.txbPostorden);
            this.panel1.Controls.Add(this.txbInorden);
            this.panel1.Controls.Add(this.txbOperacion);
            this.panel1.Controls.Add(this.txbIp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbCarnet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 378);
            this.panel1.TabIndex = 0;
            // 
            // txbPostorden
            // 
            this.txbPostorden.Location = new System.Drawing.Point(346, 317);
            this.txbPostorden.Name = "txbPostorden";
            this.txbPostorden.Size = new System.Drawing.Size(139, 20);
            this.txbPostorden.TabIndex = 10;
            // 
            // txbInorden
            // 
            this.txbInorden.Location = new System.Drawing.Point(346, 246);
            this.txbInorden.Name = "txbInorden";
            this.txbInorden.Size = new System.Drawing.Size(139, 20);
            this.txbInorden.TabIndex = 9;
            // 
            // txbOperacion
            // 
            this.txbOperacion.Location = new System.Drawing.Point(346, 176);
            this.txbOperacion.Name = "txbOperacion";
            this.txbOperacion.Size = new System.Drawing.Size(139, 20);
            this.txbOperacion.TabIndex = 8;
            // 
            // txbIp
            // 
            this.txbIp.Location = new System.Drawing.Point(346, 97);
            this.txbIp.Name = "txbIp";
            this.txbIp.Size = new System.Drawing.Size(139, 20);
            this.txbIp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Operacion en POSTORDEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Operacion en INORDEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado de la Operacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ip que envio el Mensaje";
            // 
            // txbCarnet
            // 
            this.txbCarnet.Location = new System.Drawing.Point(346, 33);
            this.txbCarnet.Name = "txbCarnet";
            this.txbCarnet.Size = new System.Drawing.Size(139, 20);
            this.txbCarnet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(343, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carnet que envio el Mensaje";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 371);
            this.textBox1.TabIndex = 0;
            // 
            // BOperar
            // 
            this.BOperar.Location = new System.Drawing.Point(12, 12);
            this.BOperar.Name = "BOperar";
            this.BOperar.Size = new System.Drawing.Size(142, 34);
            this.BOperar.TabIndex = 1;
            this.BOperar.Text = "OPERAR";
            this.BOperar.UseVisualStyleBackColor = true;
            this.BOperar.Click += new System.EventHandler(this.BOperar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(448, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(69, 34);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // etiTam
            // 
            this.etiTam.AutoSize = true;
            this.etiTam.Location = new System.Drawing.Point(178, 13);
            this.etiTam.Name = "etiTam";
            this.etiTam.Size = new System.Drawing.Size(13, 13);
            this.etiTam.TabIndex = 4;
            this.etiTam.Text = "--";
            // 
            // ColaMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 443);
            this.Controls.Add(this.etiTam);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.BOperar);
            this.Controls.Add(this.panel1);
            this.Name = "ColaMensajes";
            this.Text = "ColaMensajes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbPostorden;
        private System.Windows.Forms.TextBox txbInorden;
        private System.Windows.Forms.TextBox txbOperacion;
        private System.Windows.Forms.TextBox txbIp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCarnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BOperar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label etiTam;

    }
}