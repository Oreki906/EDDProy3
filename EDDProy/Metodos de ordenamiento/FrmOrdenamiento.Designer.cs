namespace EDDemo.Metodos_de_ordenamiento
{
    partial class FrmOrdenamiento
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
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.cbTamaño = new System.Windows.Forms.ComboBox();
            this.lbOrden = new System.Windows.Forms.ListBox();
            this.cbnumb = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnRadix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Location = new System.Drawing.Point(51, 316);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(149, 43);
            this.btnCrearLista.TabIndex = 10;
            this.btnCrearLista.Text = "Burbuja";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            this.btnCrearLista.Click += new System.EventHandler(this.btnCrearLista_Click);
            // 
            // cbTamaño
            // 
            this.cbTamaño.FormattingEnabled = true;
            this.cbTamaño.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbTamaño.Location = new System.Drawing.Point(51, 60);
            this.cbTamaño.Name = "cbTamaño";
            this.cbTamaño.Size = new System.Drawing.Size(57, 24);
            this.cbTamaño.TabIndex = 11;
            this.cbTamaño.SelectedIndexChanged += new System.EventHandler(this.cbTamaño_SelectedIndexChanged);
            // 
            // lbOrden
            // 
            this.lbOrden.FormattingEnabled = true;
            this.lbOrden.ItemHeight = 16;
            this.lbOrden.Location = new System.Drawing.Point(53, 136);
            this.lbOrden.Name = "lbOrden";
            this.lbOrden.Size = new System.Drawing.Size(86, 132);
            this.lbOrden.TabIndex = 13;
            this.lbOrden.SelectedIndexChanged += new System.EventHandler(this.lbOrden_SelectedIndexChanged);
            // 
            // cbnumb
            // 
            this.cbnumb.Location = new System.Drawing.Point(127, 60);
            this.cbnumb.Name = "cbnumb";
            this.cbnumb.Size = new System.Drawing.Size(98, 22);
            this.cbnumb.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(242, 56);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 26);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(231, 316);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(121, 43);
            this.btnShell.TabIndex = 16;
            this.btnShell.Text = "Shell sort";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(399, 321);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(162, 37);
            this.btnQuickSort.TabIndex = 17;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnRadix
            // 
            this.btnRadix.Location = new System.Drawing.Point(602, 321);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(148, 37);
            this.btnRadix.TabIndex = 18;
            this.btnRadix.Text = "RadixSort";
            this.btnRadix.UseVisualStyleBackColor = true;
            this.btnRadix.Click += new System.EventHandler(this.btnRadix_Click);
            // 
            // FrmOrdenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRadix);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbnumb);
            this.Controls.Add(this.lbOrden);
            this.Controls.Add(this.cbTamaño);
            this.Controls.Add(this.btnCrearLista);
            this.Name = "FrmOrdenamiento";
            this.Text = "FrmOrdenamiento";
            this.Load += new System.EventHandler(this.FrmOrdenamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrearLista;
        private System.Windows.Forms.ComboBox cbTamaño;
        private System.Windows.Forms.ListBox lbOrden;
        private System.Windows.Forms.TextBox cbnumb;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnRadix;
    }
}