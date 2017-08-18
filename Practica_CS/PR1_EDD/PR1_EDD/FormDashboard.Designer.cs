    namespace PR1_EDD
{
    partial class FormDashboard
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
            this.components = new System.ComponentModel.Container();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Nodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonCJ = new System.Windows.Forms.Button();
            this.Btrs = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.etiqueta1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nodo,
            this.ip,
            this.carnet,
            this.estado});
            this.dgv1.Location = new System.Drawing.Point(12, 34);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(443, 233);
            this.dgv1.TabIndex = 0;
            // 
            // Nodo
            // 
            this.Nodo.HeaderText = "Nodo";
            this.Nodo.Name = "Nodo";
            this.Nodo.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.HeaderText = "ip";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // carnet
            // 
            this.carnet.HeaderText = "carnet";
            this.carnet.Name = "carnet";
            this.carnet.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // BotonCJ
            // 
            this.BotonCJ.Location = new System.Drawing.Point(494, 59);
            this.BotonCJ.Name = "BotonCJ";
            this.BotonCJ.Size = new System.Drawing.Size(95, 37);
            this.BotonCJ.TabIndex = 6;
            this.BotonCJ.Text = "Cargar JSON";
            this.BotonCJ.UseVisualStyleBackColor = true;
            this.BotonCJ.Click += new System.EventHandler(this.BotonCJ_Click);
            // 
            // Btrs
            // 
            this.Btrs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btrs.Location = new System.Drawing.Point(494, 117);
            this.Btrs.Name = "Btrs";
            this.Btrs.Size = new System.Drawing.Size(95, 37);
            this.Btrs.TabIndex = 7;
            this.Btrs.Text = "Atras";
            this.Btrs.UseVisualStyleBackColor = true;
            this.Btrs.Click += new System.EventHandler(this.Btrs_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // etiqueta1
            // 
            this.etiqueta1.AutoSize = true;
            this.etiqueta1.Location = new System.Drawing.Point(481, 254);
            this.etiqueta1.Name = "etiqueta1";
            this.etiqueta1.Size = new System.Drawing.Size(0, 13);
            this.etiqueta1.TabIndex = 8;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 287);
            this.Controls.Add(this.etiqueta1);
            this.Controls.Add(this.Btrs);
            this.Controls.Add(this.BotonCJ);
            this.Controls.Add(this.dgv1);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button BotonCJ;
        private System.Windows.Forms.Button Btrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label etiqueta1;
    }
}