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
    public partial class Form2 : Form
    {
        public String item = null;
        public String ench = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            trackBar1.Value = int.Parse(label1.Text);
            trackBar2.Value = int.Parse(label2.Text);
            trackBar3.Value = int.Parse(label3.Text);
            trackBar4.Value = int.Parse(label4.Text);
            trackBar5.Value = int.Parse(label5.Text);
            trackBar6.Value = int.Parse(label6.Text);
            trackBar7.Value = int.Parse(label7.Text);
        }

        public void picture(String n){
            nothing.Visible = false;
            IronSword.Visible = false;
            DiamondSword.Visible = false;
            Bow.Visible = false;
            GoldenSword.Visible = false;
            StoneSword.Visible = false;
            WoodenSword.Visible = false;
            DiamondAxe.Visible = false;
            GoldenAxe.Visible = false;
            IronAxe.Visible = false;
            StoneAxe.Visible = false;
            WoodenAxe.Visible = false;
            switch (n){
                case ("Diamond Sword"): DiamondSword.Visible = true; break;
                case ("Golden Sword"): GoldenSword.Visible = true; break;
                case ("Iron Sword"): IronSword.Visible = true; break;
                case ("Stone Sword"): StoneSword.Visible = true; break;
                case ("Wooden Sword"): WoodenSword.Visible = true; break;
                case ("Diamond Axe"): DiamondAxe.Visible = true; break;
                case ("Golden Axe"): GoldenAxe.Visible = true; break;
                case ("Iron Axe"): IronAxe.Visible = true; break;
                case ("Stone Axe"): StoneAxe.Visible = true; break;
                case ("Wooden Axe"): WoodenAxe.Visible = true; break;
                case ("Bow"): Bow.Visible = true; break;
                default: break;
            }
        }

        public void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String option = comboBox1.SelectedItem.ToString();
            picture(option);
            item = option.ToLower().Replace(" ", "_");
            if (option == "Bow") {
                textBox1.Text = "Power";
                textBox2.Text = "Punch";
                textBox3.Text = "Flame";
                textBox4.Text = "Infinity";
                textBox5.Text = "Mending";
                textBox6.Text = "Unbreaking";
                textBox7.Text = "";
            } else if (option == "Diamond Sword" || option == "Golden Sword" || option == "Iron Sword" || option == "Stone Sword" || option == "Wooden Sword" || option == "Diamond Axe" || option == "Iron Axe" || option == "Golden Axe" || option == "Stone Axe" || option == "Wooden Axe"){             
                textBox1.Text = "Sharpness";
                textBox2.Text = "Smite";
                textBox3.Text = "Bane of Arthropods";
                textBox4.Text = "Knockback";
                textBox5.Text = "Fire Aspect";
                textBox6.Text = "Looting";
                textBox7.Text = "Sweeping Edge";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
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
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++) {
                int nui = checkedListBox1.CheckedIndices[i];
                String encantamiento = enchi[nui].Replace("Sharpness", "16").Replace("Smite", "17").Replace("Bane of Arthropods", "18").Replace("Knockback", "19").Replace("Fire Aspect", "20").Replace("Looting", "21").Replace("Sweeping Edge", "22").Replace("Power", "48").Replace("Punch", "49").Replace("Flame", "50").Replace("Infinity", "51").Replace("Mending","70").Replace("Unbreaking", "34");
                ench = ench+"{id:"+encantamiento+",lvl:"+options[nui]+"},";
            }
            ench = ench.Replace("},]}", "}]}");
            String command = "/give @p "+item+" 1 0 {ench:["+ench+"]}";
            textBox8.Text = command;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nj = this.Contenedor.Controls.Count;
            for (int j = 0; j < nj; j++){
                this.Contenedor.Controls.RemoveAt(0);
            }
            Form fh = new Form0() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
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

        private void WoodenSword_Click(object sender, EventArgs e)
        {

        }
    }
}
