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
    public partial class Form3 : Form
    {
        public String item = null;
        public String ench = null;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            trackBar14.Value = int.Parse(label14.Text);
            trackBar13.Value = int.Parse(label13.Text);
            trackBar12.Value = int.Parse(label12.Text);
            trackBar11.Value = int.Parse(label11.Text);
            trackBar10.Value = int.Parse(label10.Text);
            trackBar9.Value = int.Parse(label9.Text);
            trackBar8.Value = int.Parse(label8.Text);
        }

        public void picture(String n){
            Console.WriteLine(n);
            nothing.Visible = false;
            LeatherHelmet.Visible = false;
            LeatherChestplate.Visible = false;
            LeatherLeggings.Visible = false;
            LeatherBoots.Visible = false;
            ChainmailHelmet.Visible = false;
            ChainmailChestplate.Visible = false;
            ChainmailLeggings.Visible = false;
            ChainmailBoots.Visible = false;
            GoldenHelmet.Visible = false;
            GoldenChestplate.Visible = false;
            GoldenLeggings.Visible = false;
            GoldenBoots.Visible = false;
            IronHelmet.Visible = false;
            IronChestplate.Visible = false;
            IronLeggings.Visible = false;
            IronBoots.Visible = false;
            DiamondHelmet.Visible = false;
            DiamondChestplate.Visible = false;
            DiamondLeggings.Visible = false;
            DiamondBoots.Visible = false;
            switch (n) {
                case ("Leather Helmet"): LeatherHelmet.Visible = true; break;
                case ("Leather Chestplate"): LeatherChestplate.Visible = true; break;
                case ("Leather Leggings"): LeatherLeggings.Visible = true; break;
                case ("Leather Boots"): LeatherBoots.Visible = true; break;
                case ("Chainmail Helmet"): ChainmailHelmet.Visible = true; break;
                case ("Chainmail Chestplate"): ChainmailChestplate.Visible = true; break;
                case ("Chainmail Leggings"): ChainmailLeggings.Visible = true; break;
                case ("Chainmail Boots"): ChainmailBoots.Visible = true; break;
                case ("Golden Helmet"): GoldenHelmet.Visible = true; break;
                case ("Golden Chestplate"): GoldenChestplate.Visible = true; break;
                case ("Golden Leggings"): GoldenLeggings.Visible = true; break;
                case ("Golden Boots"): GoldenBoots.Visible = true; break;
                case ("Iron Helmet"): IronHelmet.Visible = true; break;
                case ("Iron Chestplate"): IronChestplate.Visible = true; break;
                case ("Iron Leggings"): IronLeggings.Visible = true; break;
                case ("Iron Boots"): IronBoots.Visible = true; break;
                case ("Diamond Helmet"): DiamondHelmet.Visible = true; break;
                case ("Diamond Chestplate"): DiamondChestplate.Visible = true; break;
                case ("Diamond Leggings"): DiamondLeggings.Visible = true; break;
                case ("Diamond Boots"): DiamondBoots.Visible = true; break;
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

        private void button1_Click_1(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e){
            String option = comboBox2.SelectedItem.ToString();
            picture(option);
            textBox16.Text = "Full Protection";
            textBox15.Text = "Fire protection";
            textBox9.Text = "Blast protection";
            textBox14.Text = "Thorns";
            item = option.ToLower().Replace(" ", "_");
            if (option.Contains("Helmet")){
                textBox13.Text = "Respiration";
                textBox12.Text = "Aqua Affinity";
                textBox11.Text = "";
            } else if (option.Contains("Boots")){
                textBox13.Text = "Feather Falling";
                textBox12.Text = "depth strider";
                textBox11.Text = "Frost Walker";
            } else{
                textBox13.Text = "Projectile protecction";
                textBox12.Text = "";
                textBox11.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> options = new List<string>();
            List<string> enchi = new List<string>();
            enchi.Add(textBox16.Text);
            enchi.Add(textBox15.Text);
            enchi.Add(textBox9.Text);
            enchi.Add(textBox14.Text);
            enchi.Add(textBox13.Text);
            enchi.Add(textBox12.Text);
            enchi.Add(textBox11.Text);
            options.Add(trackBar14.Value.ToString());
            options.Add(trackBar13.Value.ToString());
            options.Add(trackBar12.Value.ToString());
            options.Add(trackBar11.Value.ToString());
            options.Add(trackBar10.Value.ToString());
            options.Add(trackBar9.Value.ToString());
            options.Add(trackBar8.Value.ToString());
            for (int i = 0; i < checkedListBox2.CheckedIndices.Count; i++)
            {
                int nui = checkedListBox2.CheckedIndices[i];
                String encantamiento = enchi[nui].ToLower().Replace(" ","_").Replace("full_protection", "0").Replace("fire_protection", "1").Replace("feather_falling", "2").Replace("blast_protection", "3").Replace("projectile_protection", "4").Replace("respiration", "5").Replace("aqua_affinity", "6").Replace("thorns", "7").Replace("depth_strider", "8").Replace("frost_walker", "9");
                ench = ench + "{id:" + encantamiento + ",lvl:" + options[nui] + "},";
            }
            ench = ench.Replace("},]}", "}]}");
            String command = "/give @p " + item + " 1 0 {ench:[" + ench + "]}";
            textBox8.Text = command;
        }

        private void button2_Click_1(object sender, EventArgs e)
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
    }
}
