namespace EDDemo.Estructuras_Lineales
{
    partial class frmCircular
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
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.cbPosicion = new System.Windows.Forms.ComboBox();
            this.cbDatos = new System.Windows.Forms.ComboBox();
            this.Imprecion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(519, 308);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(162, 55);
            this.btBuscar.TabIndex = 15;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click_1);
            // 
            // btContar
            // 
            this.btContar.Location = new System.Drawing.Point(659, 196);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(188, 45);
            this.btContar.TabIndex = 14;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click_1);
            // 
            // btVaciar
            // 
            this.btVaciar.Location = new System.Drawing.Point(352, 196);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(200, 46);
            this.btVaciar.TabIndex = 13;
            this.btVaciar.Text = "Vaciar";
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click_1);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(659, 106);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(189, 56);
            this.btEliminar.TabIndex = 12;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click_1);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(358, 119);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(196, 46);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click_1);
            // 
            // cbPosicion
            // 
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.Location = new System.Drawing.Point(651, 16);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(197, 24);
            this.cbPosicion.TabIndex = 10;
            // 
            // cbDatos
            // 
            this.cbDatos.FormattingEnabled = true;
            this.cbDatos.Location = new System.Drawing.Point(353, 16);
            this.cbDatos.Name = "cbDatos";
            this.cbDatos.Size = new System.Drawing.Size(201, 24);
            this.cbDatos.TabIndex = 9;
            // 
            // Imprecion
            // 
            this.Imprecion.FormattingEnabled = true;
            this.Imprecion.ItemHeight = 16;
            this.Imprecion.Location = new System.Drawing.Point(1, 12);
            this.Imprecion.Name = "Imprecion";
            this.Imprecion.Size = new System.Drawing.Size(191, 212);
            this.Imprecion.TabIndex = 8;
            // 
            // frmCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 505);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btContar);
            this.Controls.Add(this.btVaciar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.cbPosicion);
            this.Controls.Add(this.cbDatos);
            this.Controls.Add(this.Imprecion);
            this.Name = "frmCircular";
            this.Text = "frmCircular";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.Button btVaciar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.ComboBox cbDatos;
        private System.Windows.Forms.ListBox Imprecion;
    }
}