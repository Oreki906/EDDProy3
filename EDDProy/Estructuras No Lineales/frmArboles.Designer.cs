
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblrecorridoniveles = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPodar = new System.Windows.Forms.Button();
            this.btnelimpred = new System.Windows.Forms.Button();
            this.btnelimsuces = new System.Windows.Forms.Button();
            this.Altura = new System.Windows.Forms.Button();
            this.btncontho = new System.Windows.Forms.Button();
            this.btnContnod = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnlleno = new System.Windows.Forms.Button();
            this.rbOrientacion1 = new System.Windows.Forms.RadioButton();
            this.rbOrientacion2 = new System.Windows.Forms.RadioButton();
            this.btncompleto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(57, 19);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 31);
            this.txtDato.TabIndex = 0;
            this.txtDato.TextChanged += new System.EventHandler(this.txtDato_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 19);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(8, 354);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(1169, 490);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(684, 5);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 51);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(8, 197);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(83, 29);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(138, 104);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(83, 40);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(8, 26);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(42, 16);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(138, 59);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(83, 42);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(54, 66);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(80, 28);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.ValueChanged += new System.EventHandler(this.txtNodos_ValueChanged);
            // 
            // lblrecorridoniveles
            // 
            this.lblrecorridoniveles.AutoSize = true;
            this.lblrecorridoniveles.Location = new System.Drawing.Point(271, 251);
            this.lblrecorridoniveles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrecorridoniveles.Name = "lblrecorridoniveles";
            this.lblrecorridoniveles.Size = new System.Drawing.Size(71, 16);
            this.lblrecorridoniveles.TabIndex = 21;
            this.lblrecorridoniveles.Text = "PostOrden";
            this.lblrecorridoniveles.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(271, 194);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoInOrden.TabIndex = 19;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(199, 162);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(68, 16);
            this.lblPreOrden.TabIndex = 18;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(209, 194);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(57, 16);
            this.lblInOrden.TabIndex = 17;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(271, 224);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoPostOrden.TabIndex = 16;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(195, 224);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(74, 16);
            this.lblPostOrden.TabIndex = 15;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(231, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 39);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar dato";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPodar
            // 
            this.btnPodar.Location = new System.Drawing.Point(684, 62);
            this.btnPodar.Name = "btnPodar";
            this.btnPodar.Size = new System.Drawing.Size(83, 39);
            this.btnPodar.TabIndex = 19;
            this.btnPodar.Text = "Podar";
            this.btnPodar.UseVisualStyleBackColor = true;
            this.btnPodar.Click += new System.EventHandler(this.btnPodar_Click);
            // 
            // btnelimpred
            // 
            this.btnelimpred.Location = new System.Drawing.Point(231, 5);
            this.btnelimpred.Name = "btnelimpred";
            this.btnelimpred.Size = new System.Drawing.Size(111, 51);
            this.btnelimpred.TabIndex = 20;
            this.btnelimpred.Text = "Eliminar predecesor";
            this.btnelimpred.UseVisualStyleBackColor = true;
            this.btnelimpred.Click += new System.EventHandler(this.btnelimpred_Click);
            // 
            // btnelimsuces
            // 
            this.btnelimsuces.Location = new System.Drawing.Point(348, 4);
            this.btnelimsuces.Name = "btnelimsuces";
            this.btnelimsuces.Size = new System.Drawing.Size(121, 52);
            this.btnelimsuces.TabIndex = 21;
            this.btnelimsuces.Text = "Eliminar sucesor ";
            this.btnelimsuces.UseVisualStyleBackColor = true;
            this.btnelimsuces.Click += new System.EventHandler(this.btnelimsuces_Click);
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(475, 5);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(89, 51);
            this.Altura.TabIndex = 22;
            this.Altura.Text = "Calcular Altura";
            this.Altura.UseVisualStyleBackColor = true;
            this.Altura.Click += new System.EventHandler(this.Altura_Click);
            // 
            // btncontho
            // 
            this.btncontho.Location = new System.Drawing.Point(348, 62);
            this.btncontho.Name = "btncontho";
            this.btncontho.Size = new System.Drawing.Size(121, 39);
            this.btncontho.TabIndex = 23;
            this.btncontho.Text = "contar hojas";
            this.btncontho.UseVisualStyleBackColor = true;
            this.btncontho.Click += new System.EventHandler(this.btncontho_Click);
            // 
            // btnContnod
            // 
            this.btnContnod.Location = new System.Drawing.Point(570, 4);
            this.btnContnod.Name = "btnContnod";
            this.btnContnod.Size = new System.Drawing.Size(109, 52);
            this.btnContnod.TabIndex = 24;
            this.btnContnod.Text = "Contar Nodos";
            this.btnContnod.UseVisualStyleBackColor = true;
            this.btnContnod.Click += new System.EventHandler(this.btnContnod_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1177, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnlleno
            // 
            this.btnlleno.Location = new System.Drawing.Point(475, 62);
            this.btnlleno.Name = "btnlleno";
            this.btnlleno.Size = new System.Drawing.Size(89, 39);
            this.btnlleno.TabIndex = 26;
            this.btnlleno.Text = "Esta lleno?";
            this.btnlleno.UseVisualStyleBackColor = true;
            this.btnlleno.Click += new System.EventHandler(this.btnlleno_Click_1);
            // 
            // rbOrientacion1
            // 
            this.rbOrientacion1.AutoSize = true;
            this.rbOrientacion1.Location = new System.Drawing.Point(4, 158);
            this.rbOrientacion1.Margin = new System.Windows.Forms.Padding(2);
            this.rbOrientacion1.Name = "rbOrientacion1";
            this.rbOrientacion1.Size = new System.Drawing.Size(73, 20);
            this.rbOrientacion1.TabIndex = 15;
            this.rbOrientacion1.TabStop = true;
            this.rbOrientacion1.Text = "Vertical";
            this.rbOrientacion1.UseVisualStyleBackColor = true;
            // 
            // rbOrientacion2
            // 
            this.rbOrientacion2.AutoSize = true;
            this.rbOrientacion2.Location = new System.Drawing.Point(91, 158);
            this.rbOrientacion2.Margin = new System.Windows.Forms.Padding(2);
            this.rbOrientacion2.Name = "rbOrientacion2";
            this.rbOrientacion2.Size = new System.Drawing.Size(88, 20);
            this.rbOrientacion2.TabIndex = 16;
            this.rbOrientacion2.TabStop = true;
            this.rbOrientacion2.Text = "Horizontal";
            this.rbOrientacion2.UseVisualStyleBackColor = true;
            // 
            // btncompleto
            // 
            this.btncompleto.Location = new System.Drawing.Point(570, 62);
            this.btncompleto.Name = "btncompleto";
            this.btncompleto.Size = new System.Drawing.Size(109, 39);
            this.btncompleto.TabIndex = 27;
            this.btncompleto.Text = "Esta completo?";
            this.btncompleto.UseVisualStyleBackColor = true;
            this.btncompleto.Click += new System.EventHandler(this.btncompleto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Niveles";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(271, 162);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoPreOrden.TabIndex = 20;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            this.lblRecorridoPreOrden.Click += new System.EventHandler(this.lblRecorridoPreOrden_Click_1);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 850);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncompleto);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblrecorridoniveles);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.btnlleno);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.btnContnod);
            this.Controls.Add(this.btncontho);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.btnelimsuces);
            this.Controls.Add(this.btnelimpred);
            this.Controls.Add(this.btnPodar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rbOrientacion2);
            this.Controls.Add(this.rbOrientacion1);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPodar;
        private System.Windows.Forms.Button btnelimpred;
        private System.Windows.Forms.Button btnelimsuces;
        private System.Windows.Forms.Button Altura;
        private System.Windows.Forms.Button btncontho;
        private System.Windows.Forms.Button btnContnod;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnlleno;
        private System.Windows.Forms.RadioButton rbOrientacion1;
        private System.Windows.Forms.RadioButton rbOrientacion2;
        private System.Windows.Forms.Label lblrecorridoniveles;
        private System.Windows.Forms.Button btncompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
    }
}