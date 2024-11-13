namespace EDDemo.Estructuras_Lineales
{
    partial class frmlistaDoble
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
            this.btAnt = new System.Windows.Forms.Button();
            this.Imprecion = new System.Windows.Forms.ListBox();
            this.btContar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btVaciar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.cbPosicion = new System.Windows.Forms.ComboBox();
            this.cbDatos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(708, 435);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(149, 56);
            this.btBuscar.TabIndex = 17;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click_1);
            // 
            // btAnt
            // 
            this.btAnt.Location = new System.Drawing.Point(335, 441);
            this.btAnt.Name = "btAnt";
            this.btAnt.Size = new System.Drawing.Size(140, 51);
            this.btAnt.TabIndex = 16;
            this.btAnt.Text = "Imprimir Anteriores";
            this.btAnt.UseVisualStyleBackColor = true;
            this.btAnt.Click += new System.EventHandler(this.btAnt_Click_1);
            // 
            // Imprecion
            // 
            this.Imprecion.FormattingEnabled = true;
            this.Imprecion.ItemHeight = 16;
            this.Imprecion.Location = new System.Drawing.Point(53, 59);
            this.Imprecion.Name = "Imprecion";
            this.Imprecion.Size = new System.Drawing.Size(180, 276);
            this.Imprecion.TabIndex = 15;
            // 
            // btContar
            // 
            this.btContar.Location = new System.Drawing.Point(710, 313);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(148, 78);
            this.btContar.TabIndex = 14;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click_1);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(708, 210);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(151, 55);
            this.btEliminar.TabIndex = 13;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click_1);
            // 
            // btVaciar
            // 
            this.btVaciar.Location = new System.Drawing.Point(341, 321);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(150, 72);
            this.btVaciar.TabIndex = 12;
            this.btVaciar.Text = "Vaciar";
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click_1);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(335, 211);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(156, 55);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click_1);
            // 
            // cbPosicion
            // 
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.Location = new System.Drawing.Point(710, 108);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(190, 24);
            this.cbPosicion.TabIndex = 10;
            // 
            // cbDatos
            // 
            this.cbDatos.FormattingEnabled = true;
            this.cbDatos.Location = new System.Drawing.Point(335, 108);
            this.cbDatos.Name = "cbDatos";
            this.cbDatos.Size = new System.Drawing.Size(271, 24);
            this.cbDatos.TabIndex = 9;
            // 
            // frmlistaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 540);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btAnt);
            this.Controls.Add(this.Imprecion);
            this.Controls.Add(this.btContar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btVaciar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.cbPosicion);
            this.Controls.Add(this.cbDatos);
            this.Name = "frmlistaDoble";
            this.Text = "frmlistaDoble";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAnt;
        private System.Windows.Forms.ListBox Imprecion;
        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btVaciar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.ComboBox cbDatos;
    }
}