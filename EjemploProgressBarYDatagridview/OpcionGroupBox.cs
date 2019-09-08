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
    public partial class OpcionGroupBox : Form
    {
        public OpcionGroupBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbgenero.Visible = true;
            gbnacionalidad.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbgenero.Visible = false;
            gbnacionalidad.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(18, 382);
            groupBox1.Visible = false;

            groupBox2.Location = new Point(59, 248);
            groupBox2.Visible = true;

            groupBox3.Location = new Point(255, 382);
            groupBox3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(59, 248); 
            groupBox1.Visible = true;

            groupBox2.Location = new Point(18, 382);
            groupBox2.Visible = false;

            groupBox3.Location = new Point(255, 382);
            groupBox3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(255, 382);
            groupBox1.Visible = false;

            groupBox2.Location = new Point(18, 382);
            groupBox2.Visible = false;

            groupBox3.Location = new Point(59, 248); 
            groupBox3.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
