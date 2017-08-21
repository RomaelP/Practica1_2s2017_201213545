namespace PR1_EDD
{
    partial class FormMN
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonVD = new System.Windows.Forms.Button();
            this.BotonAM = new System.Windows.Forms.Button();
            this.BotonVR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonVD
            // 
            this.BotonVD.Location = new System.Drawing.Point(65, 39);
            this.BotonVD.Name = "BotonVD";
            this.BotonVD.Size = new System.Drawing.Size(211, 34);
            this.BotonVD.TabIndex = 0;
            this.BotonVD.Text = "Ver Dashboard";
            this.BotonVD.UseVisualStyleBackColor = true;
            this.BotonVD.Click += new System.EventHandler(this.BotonVD_Click);
            // 
            // BotonAM
            // 
            this.BotonAM.Location = new System.Drawing.Point(65, 102);
            this.BotonAM.Name = "BotonAM";
            this.BotonAM.Size = new System.Drawing.Size(211, 38);
            this.BotonAM.TabIndex = 1;
            this.BotonAM.Text = "Administrar Mensajes";
            this.BotonAM.UseVisualStyleBackColor = true;
            this.BotonAM.Click += new System.EventHandler(this.BotonAM_Click);
            // 
            // BotonVR
            // 
            this.BotonVR.Location = new System.Drawing.Point(65, 162);
            this.BotonVR.Name = "BotonVR";
            this.BotonVR.Size = new System.Drawing.Size(211, 37);
            this.BotonVR.TabIndex = 2;
            this.BotonVR.Text = "Ver Reportes";
            this.BotonVR.UseVisualStyleBackColor = true;
            this.BotonVR.Click += new System.EventHandler(this.BotonVR_Click);
            // 
            // FormMN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 272);
            this.Controls.Add(this.BotonVR);
            this.Controls.Add(this.BotonAM);
            this.Controls.Add(this.BotonVD);
            this.Name = "FormMN";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonVD;
        private System.Windows.Forms.Button BotonAM;
        private System.Windows.Forms.Button BotonVR;
    }
}

