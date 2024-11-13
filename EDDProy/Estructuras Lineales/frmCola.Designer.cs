namespace EDDemo.Estructuras_Lineales
{
    partial class frmCola
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.btContar = new System.Windows.Forms.Button();
            this.btVaciar = new System.Windows.Forms.Button();
            this.Imprecion = new System.Windows.Forms.ListBox();
            this.btDesencolar = new System.Windows.Forms.Button();
            this.btEncolar = new System.Windows.Forms.Button();
            this.cbDatos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.ForeColor = System.Drawing.Color.Black;
            this.btBuscar.Location = new System.Drawing.Point(622, 113);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(169, 42);
            this.btBuscar.TabIndex = 13;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btContar
            // 
            this.btContar.ForeColor = System.Drawing.Color.Black;
            this.btContar.Location = new System.Drawing.Point(310, 359);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(209, 49);
            this.btContar.TabIndex = 12;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click);
            // 
            // btVaciar
            // 
            this.btVaciar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btVaciar.Location = new System.Drawing.Point(310, 278);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(210, 51);
            this.btVaciar.TabIndex = 11;
            this.btVaciar.Text = "Vaciar";
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // Imprecion
            // 
            this.Imprecion.FormattingEnabled = true;
            this.Imprecion.ItemHeight = 16;
            this.Imprecion.Location = new System.Drawing.Point(5, 21);
            this.Imprecion.Name = "Imprecion";
            this.Imprecion.Size = new System.Drawing.Size(197, 292);
            this.Imprecion.TabIndex = 10;
            // 
            // btDesencolar
            // 
            this.btDesencolar.ForeColor = System.Drawing.Color.Black;
            this.btDesencolar.Location = new System.Drawing.Point(310, 186);
            this.btDesencolar.Name = "btDesencolar";
            this.btDesencolar.Size = new System.Drawing.Size(211, 54);
            this.btDesencolar.TabIndex = 9;
            this.btDesencolar.Text = "Desencolar";
            this.btDesencolar.UseVisualStyleBackColor = true;
            this.btDesencolar.Click += new System.EventHandler(this.btDesencolar_Click);
            // 
            // btEncolar
            // 
            this.btEncolar.ForeColor = System.Drawing.Color.Black;
            this.btEncolar.Location = new System.Drawing.Point(310, 111);
            this.btEncolar.Name = "btEncolar";
            this.btEncolar.Size = new System.Drawing.Size(211, 45);
            this.btEncolar.TabIndex = 8;
            this.btEncolar.Text = "Encolar";
            this.btEncolar.UseVisualStyleBackColor = true;
            this.btEncolar.Click += new System.EventHandler(this.btEncolar_Click);
            // 
            // cbDatos
            // 
            this.cbDatos.FormattingEnabled = true;
            this.cbDatos.Location = new System.Drawing.Point(293, 9);
            this.cbDatos.Name = "cbDatos";
            this.cbDatos.Size = new System.Drawing.Size(259, 24);
            this.cbDatos.TabIndex = 7;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btContar);
            this.Controls.Add(this.btVaciar);
            this.Controls.Add(this.Imprecion);
            this.Controls.Add(this.btDesencolar);
            this.Controls.Add(this.btEncolar);
            this.Controls.Add(this.cbDatos);
            this.Name = "frmCola";
            this.Text = "frmCola";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.Button btVaciar;
        private System.Windows.Forms.ListBox Imprecion;
        private System.Windows.Forms.Button btDesencolar;
        private System.Windows.Forms.Button btEncolar;
        private System.Windows.Forms.ComboBox cbDatos;
    }
}