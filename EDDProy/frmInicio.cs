﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Metodos_de_ordenamiento;
using EDDemo.Recurcividad;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlistaDoble A = new frmlistaDoble();
            A.MdiParent = this;
            A.Show();
        }

        private void circularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircular mCircular = new frmCircular();
            mCircular.MdiParent = this;
            mCircular.Show();
        }

        private void circularDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circularDoble   b = new circularDoble();
            b.MdiParent = this;
            b.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola mCola = new frmCola();
            mCola.MdiParent = this;
            mCola.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenamiento orden = new FrmOrdenamiento();
            orden.MdiParent = this;
            orden.Show();
        }

        private void recursividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecursividad formRecursividad = new FormRecursividad();
            formRecursividad.MdiParent = this;
            formRecursividad.Show();
        }
    }
}
