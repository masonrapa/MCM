using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMD
{
    public partial class Form5 : Form
    {
        public String item = null;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            trackBar1.Value = int.Parse(label1.Text);
            trackBar2.Value = int.Parse(label2.Text);
        }
        public void picture(String n)
        {
            nothing.Visible = false;
            speed.Visible = false;
            haste.Visible = false;
            miningfatige.Visible = false;
            strenght.Visible = false;
            weakness.Visible = false;
            jumpboost.Visible = false;
            regeneration.Visible = false;
            firerestistance.Visible = false;
            watherbreathing.Visible = false;
            blindness.Visible = false;
            hunger.Visible = false;
            wither.Visible = false;
            saturation.Visible = false;
            absortion.Visible = false;
            luck.Visible = false;
            unluck.Visible = false;
            healthboost.Visible = false;
            invisibility.Visible = false;
            nightvision.Visible = false;
            poison.Visible = false;
            damage.Visible = false;
            nausea.Visible = false;
            wither.Visible = false;
            slowness.Visible = false;
            instanthealth.Visible = false;
            resistance.Visible = false;
            watherbreathing.Visible = false;
            glowing.Visible = false;
            Levitation.Visible = false;
            switch (n)
            {
                case ("Speed"): speed.Visible = true; break;
                case ("Haste"): haste.Visible = true; break;
                case ("Mining Fatigue"): miningfatige.Visible = true; break;
                case ("Strength"): strenght.Visible = true; break;
                case ("Weakness"): weakness.Visible = true; break;
                case ("Jump Boost"): jumpboost.Visible = true; break;
                case ("Regeneration"): regeneration.Visible = true; break;
                case ("Fire Resistance"): firerestistance.Visible = true; break;
                case ("Blindness"): blindness.Visible = true; break;
                case ("Hunger"): hunger.Visible = true; break;
                case ("Saturation"): saturation.Visible = true; break;
                case ("Absorption"): absortion.Visible = true; break;
                case ("Luck"): luck.Visible = true; break;
                case ("Bad Luck"): unluck.Visible = true; break;
                case ("Health Boost"): healthboost.Visible = true; break;
                case ("Invisibility"): invisibility.Visible = true; break;
                case ("Night Vision"): nightvision.Visible = true; break;
                case ("Poison"): poison.Visible = true; break;
                case ("Instant Damage"): damage.Visible = true; break;
                case ("Nausea"): nausea.Visible = true; break;
                case ("Wither"): wither.Visible = true; break;
                case ("Slowness"): slowness.Visible = true; break;
                case ("Instant Health"): instanthealth.Visible = true; break;
                case ("Resistance"): resistance.Visible = true; break;
                case ("Water Breathing"): watherbreathing.Visible = true; break;
                case ("Glowing"): watherbreathing.Visible = true; break;
                case ("Levitation"): Levitation.Visible = true; break;

                default: break;
            }
        }

        private void speed_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nj = this.Contenedor.Controls.Count;
            for (int j = 0; j < nj; j++)
            {
                this.Contenedor.Controls.RemoveAt(0);
            }
            Form fh = new Form0() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = comboBox1.SelectedItem.ToString();
            picture(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nivel = trackBar1.Value.ToString();
            String tempo = trackBar2.Value.ToString();
            String command = "/effect @p "+item.Replace("Speed","1").Replace("Slowness","2").Replace("Haste","3").Replace("Mining Fatigue","4").Replace("Strength","5").Replace("Instant Health","6").Replace("Instant Damage","7").Replace("Jump Boost","8").Replace("Nausea","9").Replace("Regeneration","10").Replace("Resistance","11").Replace("Fire Resistance","12").Replace("Water Breathing","13").Replace("Invisibility","14").Replace("Blindness","15").Replace("Night Vision","16").Replace("Hunger","17").Replace("Weakness","18").Replace("Poison","19").Replace("Wither","20").Replace("Health Boost","21").Replace("Absorption","22").Replace("Saturation","23").Replace("Glowing","24").Replace("Levitation","25").Replace("Luck","26").Replace("Bad Luck","27") +" "+nivel+" "+tempo;
            textBox8.Text = command;
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hunger_Click(object sender, EventArgs e)
        {

        }

        private void damage_Click(object sender, EventArgs e)
        {

        }

        private void wither_Click(object sender, EventArgs e)
        {

        }

        private void weakness_Click(object sender, EventArgs e)
        {

        }

        private void miningfatige_Click(object sender, EventArgs e)
        {

        }

        private void nausea_Click(object sender, EventArgs e)
        {

        }

        private void poison_Click(object sender, EventArgs e)
        {

        }

        private void blindness_Click(object sender, EventArgs e)
        {

        }

        private void unluck_Click(object sender, EventArgs e)
        {

        }

        private void watherbreathing_Click(object sender, EventArgs e)
        {

        }

        private void strenght_Click(object sender, EventArgs e)
        {

        }

        private void saturation_Click(object sender, EventArgs e)
        {

        }

        private void regeneration_Click(object sender, EventArgs e)
        {

        }

        private void nightvision_Click(object sender, EventArgs e)
        {

        }

        private void luck_Click(object sender, EventArgs e)
        {

        }

        private void jumpboost_Click(object sender, EventArgs e)
        {

        }

        private void invisibility_Click(object sender, EventArgs e)
        {

        }

        private void healthboost_Click(object sender, EventArgs e)
        {

        }

        private void haste_Click(object sender, EventArgs e)
        {

        }

        private void firerestistance_Click(object sender, EventArgs e)
        {

        }

        private void absortion_Click(object sender, EventArgs e)
        {

        }
    }
}
