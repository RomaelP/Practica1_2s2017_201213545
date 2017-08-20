namespace PR1_EDD
{
    partial class AdministradorMSJS
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
            this.BEnviarM = new System.Windows.Forms.Button();
            this.BVerC = new System.Windows.Forms.Button();
            this.BVerR = new System.Windows.Forms.Button();
            this.BAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BEnviarM
            // 
            this.BEnviarM.Location = new System.Drawing.Point(84, 44);
            this.BEnviarM.Name = "BEnviarM";
            this.BEnviarM.Size = new System.Drawing.Size(164, 37);
            this.BEnviarM.TabIndex = 3;
            this.BEnviarM.Text = "Enviar Mensaje";
            this.BEnviarM.UseVisualStyleBackColor = true;
            this.BEnviarM.Click += new System.EventHandler(this.BEnviarM_Click);
            // 
            // BVerC
            // 
            this.BVerC.Location = new System.Drawing.Point(84, 106);
            this.BVerC.Name = "BVerC";
            this.BVerC.Size = new System.Drawing.Size(164, 41);
            this.BVerC.TabIndex = 1;
            this.BVerC.Text = "Ver Cola De Mensajes";
            this.BVerC.UseVisualStyleBackColor = true;
            this.BVerC.Click += new System.EventHandler(this.BVerC_Click);
            // 
            // BVerR
            // 
            this.BVerR.Location = new System.Drawing.Point(84, 173);
            this.BVerR.Name = "BVerR";
            this.BVerR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BVerR.Size = new System.Drawing.Size(164, 37);
            this.BVerR.TabIndex = 2;
            this.BVerR.Text = "Ver Respuesta de Mensaje";
            this.BVerR.UseVisualStyleBackColor = true;
            this.BVerR.Click += new System.EventHandler(this.button3_Click);
            // 
            // BAtras
            // 
            this.BAtras.Location = new System.Drawing.Point(267, 234);
            this.BAtras.Name = "BAtras";
            this.BAtras.Size = new System.Drawing.Size(75, 31);
            this.BAtras.TabIndex = 3;
            this.BAtras.Text = "Atras";
            this.BAtras.UseVisualStyleBackColor = true;
            this.BAtras.Click += new System.EventHandler(this.BAtras_Click);
            // 
            // AdministradorMSJS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 277);
            this.Controls.Add(this.BAtras);
            this.Controls.Add(this.BVerR);
            this.Controls.Add(this.BVerC);
            this.Controls.Add(this.BEnviarM);
            this.Name = "AdministradorMSJS";
            this.Text = "Administrador de Mensajes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BEnviarM;
        private System.Windows.Forms.Button BVerC;
        private System.Windows.Forms.Button BVerR;
        private System.Windows.Forms.Button BAtras;
    }
}