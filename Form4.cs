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
    public partial class Form4 : Form
    {
        public String item = null;
        public String ench = null;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            trackBar1.Value = int.Parse(label1.Text);
            trackBar2.Value = int.Parse(label2.Text);
            trackBar3.Value = int.Parse(label3.Text);
            trackBar4.Value = int.Parse(label4.Text);
            trackBar5.Value = int.Parse(label5.Text);
            trackBar6.Value = int.Parse(label6.Text);
            trackBar7.Value = int.Parse(label7.Text);
        }

        public void picture(String n)
        {
            nothing.Visible = false;
            DiamondPickaxe.Visible = false;
            GoldenPickaxe.Visible = false;
            IronPickaxe.Visible = false;
            StonePickaxe.Visible = false;
            WoodenPickaxe.Visible = false;
            DiamondShovel.Visible = false;
            IronShovel.Visible = false;
            GoldenShovel.Visible = false;
            StoneShovel.Visible = false;
            WoodenShovel.Visible = false;
            Lighter.Visible = false;
            FishingRod.Visible = false;
            switch (n)
            {
                case ("Diamond Pickaxe"): DiamondPickaxe.Visible = true; break;
                case ("Iron Pickaxe"): IronPickaxe.Visible = true; break;
                case ("Golden Pickaxe"): GoldenPickaxe.Visible = true; break;
                case ("Stone Pickaxe"): StonePickaxe.Visible = true; break;
                case ("Wooden Pickaxe"): WoodenPickaxe.Visible = true; break;
                case ("Diamond Shovel"): DiamondShovel.Visible = true; break;
                case ("Golden Shovel"): GoldenShovel.Visible = true; break;
                case ("Iron Shovel"): IronShovel.Visible = true; break;
                case ("Stone Shovels"): StoneShovel.Visible = true; break;
                case ("Wooden Shovel"): WoodenShovel.Visible = true; break;
                case ("Lighter"): Lighter.Visible = true; break;
                case ("Fishing Rod"): FishingRod.Visible = true; break; 
                default: break;
            }
        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar3.Value.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar4.Value.ToString();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar5.Value.ToString();
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar6.Value.ToString();
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar7.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> options = new List<string>();
            List<string> enchi = new List<string>();
            enchi.Add(textBox1.Text);
            enchi.Add(textBox2.Text);
            enchi.Add(textBox3.Text);
            enchi.Add(textBox4.Text);
            enchi.Add(textBox5.Text);
            enchi.Add(textBox6.Text);
            enchi.Add(textBox7.Text);
            options.Add(trackBar1.Value.ToString());
            options.Add(trackBar2.Value.ToString());
            options.Add(trackBar3.Value.ToString());
            options.Add(trackBar4.Value.ToString());
            options.Add(trackBar5.Value.ToString());
            options.Add(trackBar6.Value.ToString());
            options.Add(trackBar7.Value.ToString());
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++){
                int nui = checkedListBox1.CheckedIndices[i];
                String encantamiento = enchi[nui].Replace("Lure", "62").Replace("Luck of the Sea", "61").Replace("Fortune", "35").Replace("Unbreaking", "34").Replace("Silk Touch", "33").Replace("Looting", "21").Replace("Efficiency", "32").Replace("Mending", "70");
                ench = ench + "{id:" + encantamiento + ",lvl:" + options[nui] + "},";
            }
            ench = ench.Replace("},]}", "}]}");
            String command = "/give @p " + item + " 1 0 {ench:[" + ench + "]}";
            textBox8.Text = command;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String option = comboBox1.SelectedItem.ToString();
            picture(option);
            item = option.ToLower().Replace(" ", "_");
            if (option.Contains("Pickaxe")){
                textBox1.Text = "Efficiency";
                textBox2.Text = "Silk Touch";
                textBox3.Text = "Unbreaking";
                textBox4.Text = "Fortune";
                textBox5.Text = "Mending";
                textBox6.Text = "";
                textBox7.Text = "";
            } else if (option.Contains("Shovel")) {
                textBox1.Text = "Efficiency";
                textBox2.Text = "Silk Touch";
                textBox3.Text = "Unbreaking";
                textBox4.Text = "Mending";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            } else if (option.Contains("Fishing")) {
                textBox1.Text = "Luck of the Sea";
                textBox2.Text = "Lure";
                textBox3.Text = "Unbreaking";
                textBox4.Text = "Mending";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            } else if (option.Contains("Lighter")){
                textBox1.Text = "Unbreaking";
                textBox2.Text = "Mending";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
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
    }
}
