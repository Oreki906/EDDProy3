namespace EDDemo.Recurcividad
{
    partial class FormRecursividad
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
            this.cbDato1 = new System.Windows.Forms.ComboBox();
            this.cbDato2 = new System.Windows.Forms.ComboBox();
            this.btnExponente = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVariable1 = new System.Windows.Forms.Label();
            this.lblVariable2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnTamano = new System.Windows.Forms.Button();
            this.btnFibo = new System.Windows.Forms.Button();
            this.lblObj = new System.Windows.Forms.Label();
            this.cbObjetivo = new System.Windows.Forms.ComboBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btTorre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDato1
            // 
            this.cbDato1.FormattingEnabled = true;
            this.cbDato1.Location = new System.Drawing.Point(56, 174);
            this.cbDato1.Name = "cbDato1";
            this.cbDato1.Size = new System.Drawing.Size(69, 24);
            this.cbDato1.TabIndex = 0;
            // 
            // cbDato2
            // 
            this.cbDato2.FormattingEnabled = true;
            this.cbDato2.Location = new System.Drawing.Point(208, 174);
            this.cbDato2.Name = "cbDato2";
            this.cbDato2.Size = new System.Drawing.Size(59, 24);
            this.cbDato2.TabIndex = 1;
            // 
            // btnExponente
            // 
            this.btnExponente.Location = new System.Drawing.Point(56, 41);
            this.btnExponente.Name = "btnExponente";
            this.btnExponente.Size = new System.Drawing.Size(98, 38);
            this.btnExponente.TabIndex = 2;
            this.btnExponente.Text = "Exponente";
            this.btnExponente.UseVisualStyleBackColor = true;
            this.btnExponente.Click += new System.EventHandler(this.btnExponente_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(208, 42);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(114, 37);
            this.btnFactorial.TabIndex = 3;
            this.btnFactorial.Text = "Factorial";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(55, 316);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 16);
            this.lblMostrar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "que operacion quires hacer?";
            // 
            // lblVariable1
            // 
            this.lblVariable1.AutoSize = true;
            this.lblVariable1.Location = new System.Drawing.Point(55, 146);
            this.lblVariable1.Name = "lblVariable1";
            this.lblVariable1.Size = new System.Drawing.Size(44, 16);
            this.lblVariable1.TabIndex = 6;
            this.lblVariable1.Text = "label2";
            // 
            // lblVariable2
            // 
            this.lblVariable2.AutoSize = true;
            this.lblVariable2.Location = new System.Drawing.Point(210, 146);
            this.lblVariable2.Name = "lblVariable2";
            this.lblVariable2.Size = new System.Drawing.Size(44, 16);
            this.lblVariable2.TabIndex = 7;
            this.lblVariable2.Text = "label2";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(310, 174);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(67, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(310, 203);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 28);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(339, 47);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(129, 31);
            this.btnSuma.TabIndex = 10;
            this.btnSuma.Text = "Suma Arreglo";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnTamano
            // 
            this.btnTamano.Location = new System.Drawing.Point(58, 208);
            this.btnTamano.Name = "btnTamano";
            this.btnTamano.Size = new System.Drawing.Size(66, 22);
            this.btnTamano.TabIndex = 11;
            this.btnTamano.Text = "Confirmar";
            this.btnTamano.UseVisualStyleBackColor = true;
            this.btnTamano.Click += new System.EventHandler(this.btnTamano_Click);
            // 
            // btnFibo
            // 
            this.btnFibo.Location = new System.Drawing.Point(486, 47);
            this.btnFibo.Name = "btnFibo";
            this.btnFibo.Size = new System.Drawing.Size(116, 31);
            this.btnFibo.TabIndex = 12;
            this.btnFibo.Text = "Fibonacci";
            this.btnFibo.UseVisualStyleBackColor = true;
            this.btnFibo.Click += new System.EventHandler(this.btnFibo_Click);
            // 
            // lblObj
            // 
            this.lblObj.AutoSize = true;
            this.lblObj.Location = new System.Drawing.Point(61, 243);
            this.lblObj.Name = "lblObj";
            this.lblObj.Size = new System.Drawing.Size(51, 16);
            this.lblObj.TabIndex = 13;
            this.lblObj.Text = "busco?";
            // 
            // cbObjetivo
            // 
            this.cbObjetivo.FormattingEnabled = true;
            this.cbObjetivo.Location = new System.Drawing.Point(61, 263);
            this.cbObjetivo.Name = "cbObjetivo";
            this.cbObjetivo.Size = new System.Drawing.Size(50, 24);
            this.cbObjetivo.TabIndex = 14;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(622, 50);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(96, 27);
            this.btnBusqueda.TabIndex = 15;
            this.btnBusqueda.Text = "busqueda binaria";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(434, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 164);
            this.listBox1.TabIndex = 16;
            // 
            // btTorre
            // 
            this.btTorre.Location = new System.Drawing.Point(51, 96);
            this.btTorre.Name = "btTorre";
            this.btTorre.Size = new System.Drawing.Size(102, 34);
            this.btTorre.TabIndex = 17;
            this.btTorre.Text = "hanoi";
            this.btTorre.UseVisualStyleBackColor = true;
            this.btTorre.Click += new System.EventHandler(this.btTorre_Click);
            // 
            // FormRecursividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.btTorre);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.cbObjetivo);
            this.Controls.Add(this.lblObj);
            this.Controls.Add(this.btnFibo);
            this.Controls.Add(this.btnTamano);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblVariable2);
            this.Controls.Add(this.lblVariable1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnExponente);
            this.Controls.Add(this.cbDato2);
            this.Controls.Add(this.cbDato1);
            this.Name = "FormRecursividad";
            this.Text = "FormRecursividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDato1;
        private System.Windows.Forms.ComboBox cbDato2;
        private System.Windows.Forms.Button btnExponente;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVariable1;
        private System.Windows.Forms.Label lblVariable2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnTamano;
        private System.Windows.Forms.Button btnFibo;
        private System.Windows.Forms.Label lblObj;
        private System.Windows.Forms.ComboBox cbObjetivo;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btTorre;
    }
}