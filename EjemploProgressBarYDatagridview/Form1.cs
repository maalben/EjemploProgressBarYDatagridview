using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploProgressBarYDatagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pgbCargaInicial.Value < 100) {
                //pgbCargaInicial.Value = pgbCargaInicial.Value + 1;
                pgbCargaInicial.Value++;
                label1.Text = "Cargando "+pgbCargaInicial.Value.ToString() + "%";
            } else {
                timer1.Stop();
                //MessageBox.Show("El progressBar ya está completado.");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }

        }
    }
}
