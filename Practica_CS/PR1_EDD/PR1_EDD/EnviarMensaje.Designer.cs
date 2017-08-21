namespace PR1_EDD
{
    partial class EnviarMensaje
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
            this.button1 = new System.Windows.Forms.Button();
            this.BCXML = new System.Windows.Forms.Button();
            this.BEMSJ = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.etiquetaCargando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BCXML
            // 
            this.BCXML.Location = new System.Drawing.Point(346, 12);
            this.BCXML.Name = "BCXML";
            this.BCXML.Size = new System.Drawing.Size(100, 31);
            this.BCXML.TabIndex = 1;
            this.BCXML.Text = "Cargar XML";
            this.BCXML.UseVisualStyleBackColor = true;
            this.BCXML.Click += new System.EventHandler(this.BCXML_Click);
            // 
            // BEMSJ
            // 
            this.BEMSJ.Enabled = false;
            this.BEMSJ.Location = new System.Drawing.Point(346, 68);
            this.BEMSJ.Name = "BEMSJ";
            this.BEMSJ.Size = new System.Drawing.Size(100, 33);
            this.BEMSJ.TabIndex = 2;
            this.BEMSJ.Text = "Enviar Mensaje";
            this.BEMSJ.UseVisualStyleBackColor = true;
            this.BEMSJ.Click += new System.EventHandler(this.button2_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(12, 12);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB1.Size = new System.Drawing.Size(311, 300);
            this.TB1.TabIndex = 3;
            // 
            // etiquetaCargando
            // 
            this.etiquetaCargando.AutoSize = true;
            this.etiquetaCargando.Location = new System.Drawing.Point(346, 222);
            this.etiquetaCargando.Name = "etiquetaCargando";
            this.etiquetaCargando.Size = new System.Drawing.Size(0, 13);
            this.etiquetaCargando.TabIndex = 4;
            // 
            // EnviarMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 324);
            this.Controls.Add(this.etiquetaCargando);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.BEMSJ);
            this.Controls.Add(this.BCXML);
            this.Controls.Add(this.button1);
            this.Name = "EnviarMensaje";
            this.Text = "Enviar Mensaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BCXML;
        private System.Windows.Forms.Button BEMSJ;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Label etiquetaCargando;
    }
}