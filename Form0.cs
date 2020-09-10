using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CMD
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fh = new Form2() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            int nj = this.Contenedor.Controls.Count;
            for (int j = 0; j < nj; j++) {
                this.Contenedor.Controls.RemoveAt(0);
            }
            Form fh = new Form2() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int nj = this.Contenedor.Controls.Count;
            for (int j = 0; j < nj; j++)
            {
                this.Contenedor.Controls.RemoveAt(0);
            }
            Form fh = new Form3() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int nj = this.Contenedor.Controls.Count;
            for (int j = 0; j < nj; j++)
            {
                this.Contenedor.Controls.RemoveAt(0);
            }
            Form fh = new Form4() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int nj = this.Contenedor.Controls.Count;
            for (int j = 0; j < nj; j++)
            {
                this.Contenedor.Controls.RemoveAt(0);
            }
            Form fh = new Form5() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }
    }
}
