using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Project_Design
{
    public partial class Form3 : Form
    {
        public static string weapon1 = "";
        public static string armour1 = "";
        public static string item1 = "";
        public static double weaponPhyDmg = 1;
        public static double weaponMagDmg = 1;
        public static double armourPhyDef = 1;
        public static double armourMagDef = 1;
        public static double itemHealing = 0;
        public static double itemTurns = 1;
        public static double itemPhyDmg = 1;
        public static double itemMagDmg = 1;
        public static double itemPhyDef = 1;
        public static double itemMagDef = 1;

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonMove1_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < 1000)
                Application.DoEvents();
            this.Visible = false;
            Form4 form4 = new Form4();
            form4.Visible = true;
            /*int pin1 = 1;
            string CS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
            string Query = "INSERT INTO UserEquipment(Pin, Weapon, Armour, Item) VALUES(@pin1,@weapon1,@armour1,@item1)";
            SqlConnection conDataBase = new SqlConnection(CS);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            cmdDataBase.Parameters.AddWithValue("@weapon1", weapon1);
            cmdDataBase.Parameters.AddWithValue("@armour1", armour1);
            cmdDataBase.Parameters.AddWithValue("@item1", item1);
            cmdDataBase.Parameters.AddWithValue("@pin1", pin1);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            weapon1 = "Diamond Spear";
            weaponPhyDmg = 1.3;
            weaponMagDmg = 1.1;
            button14.Text = weapon1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            weapon1 = "Master Sword";
            weaponPhyDmg = 2;
            weaponMagDmg = 0;
            button14.Text = weapon1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            weapon1 = "Platnium Axe";
            weaponPhyDmg = 1.4;
            weaponMagDmg = 0.8;
            button14.Text = weapon1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            weapon1 = "Ruby Staff";
            weaponPhyDmg = 0.5;
            weaponMagDmg = 1.7;
            button14.Text = weapon1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            weapon1 = "Wood Wand";
            weaponPhyDmg = 0.1;
            weaponMagDmg = 10;
            button14.Text = weapon1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            item1 = "Healing Potion";
            itemHealing = 50;
            button9.Text = item1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            item1 = "Regeneration Potion";
            itemHealing = 25;
            itemTurns = 3;
            button9.Text = item1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            item1 = "Physical DMG Potion";
            itemPhyDmg = 2;
            button9.Text = item1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            item1 = "Magic DMG Potion";
            itemMagDmg = 2;
            button9.Text = item1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            item1 = "Resistance Potion";
            itemPhyDef = 2;
            itemMagDef = 2;
            button9.Text = item1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            armour1 = "Silver Breastplate";
            armourPhyDef = 0.7;
            armourMagDef = 0.9;
            button8.Text = armour1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            armour1 = "Brass Helmet";
            armourPhyDef = 0.9;
            armourMagDef = 0.9;
            button8.Text = armour1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            armour1 = "Magic Gauntlets";
            armourPhyDef = 1;
            armourMagDef = 0.5;
            button8.Text = armour1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            armour1 = "Special Glasses";
            armourPhyDef = 1.5;
            armourMagDef = 0.1;
            button8.Text = armour1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            armour1 = "Full Plate";
            armourPhyDef = 0;
            armourMagDef = 1.6;
            button8.Text = armour1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
