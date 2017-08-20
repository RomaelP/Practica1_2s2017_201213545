namespace PR1_EDD
{
    partial class RespuestasMensajes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carnetopero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipopero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnetopero,
            this.ipopero,
            this.inorden,
            this.postorden,
            this.resultado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // carnetopero
            // 
            this.carnetopero.HeaderText = "Carnet que Opero";
            this.carnetopero.Name = "carnetopero";
            this.carnetopero.ReadOnly = true;
            // 
            // ipopero
            // 
            this.ipopero.HeaderText = "Ip que Opero";
            this.ipopero.Name = "ipopero";
            this.ipopero.ReadOnly = true;
            // 
            // inorden
            // 
            this.inorden.HeaderText = "INOrden";
            this.inorden.Name = "inorden";
            this.inorden.ReadOnly = true;
            // 
            // postorden
            // 
            this.postorden.HeaderText = "POSTOrden";
            this.postorden.Name = "postorden";
            this.postorden.ReadOnly = true;
            // 
            // resultado
            // 
            this.resultado.HeaderText = "Resultado";
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            // 
            // BtnEP
            // 
            this.BtnEP.Location = new System.Drawing.Point(12, 329);
            this.BtnEP.Name = "BtnEP";
            this.BtnEP.Size = new System.Drawing.Size(210, 23);
            this.BtnEP.TabIndex = 1;
            this.BtnEP.Text = "Empezar por los mas Antiguos";
            this.BtnEP.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Empezar por los mas Recientes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(478, 373);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // RespuestasMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 425);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnEP);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RespuestasMensajes";
            this.Text = "Respuestas a Mensajes Enviados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnetopero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipopero;
        private System.Windows.Forms.DataGridViewTextBoxColumn inorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn postorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado;
        private System.Windows.Forms.Button BtnEP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAtras;
    }
}