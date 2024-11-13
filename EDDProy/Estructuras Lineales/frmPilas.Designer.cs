
namespace EDDemo
{
    partial class frmPilas
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
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(609, 91);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(153, 47);
            this.btBuscar.TabIndex = 12;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btContar
            // 
            this.btContar.Location = new System.Drawing.Point(329, 349);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(176, 47);
            this.btContar.TabIndex = 11;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click);
            // 
            // btVaciar
            // 
            this.btVaciar.Location = new System.Drawing.Point(329, 267);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(176, 60);
            this.btVaciar.TabIndex = 10;
            this.btVaciar.Text = "vaciar";
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // Imprecion
            // 
            this.Imprecion.FormattingEnabled = true;
            this.Imprecion.ItemHeight = 16;
            this.Imprecion.Location = new System.Drawing.Point(76, 29);
            this.Imprecion.Name = "Imprecion";
            this.Imprecion.Size = new System.Drawing.Size(142, 260);
            this.Imprecion.TabIndex = 9;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(324, 189);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(180, 51);
            this.btEliminar.TabIndex = 8;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(329, 91);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(177, 54);
            this.btAgregar.TabIndex = 7;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(309, 29);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(247, 22);
            this.txtDatos.TabIndex = 13;
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 440);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btContar);
            this.Controls.Add(this.btVaciar);
            this.Controls.Add(this.Imprecion);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPilas";
            this.Text = "frmPilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.Button btVaciar;
        private System.Windows.Forms.ListBox Imprecion;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txtDatos;
    }
}