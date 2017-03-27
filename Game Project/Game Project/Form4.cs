using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Design
{
    public partial class Form4 : Form
    {
        Random rnd = new Random();
        public static string bossName = "Boss#1";
        public static double bossHealth = 100;
        public static double bossPhyDef = 0.8;
        public static double bossMagDef = 1.1;
        public static double bossPhyDmg = 1.3;
        public static double bossMagDmg = 1.1;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadNewForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bossName = "Boss#2";
            bossHealth = 200;
            bossPhyDef = 0.8;
            bossMagDef = 1;
            bossPhyDmg = 1.2;
            bossMagDmg = 1.3;
            loadNewForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bossName = "Boss#2";
            bossHealth = 300;
            bossPhyDef = 0.8;
            bossMagDef = 0.8;
            bossPhyDmg = 1.6;
            bossMagDmg = 1.4;
            loadNewForm();
        }
        private void loadNewForm()
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < 1000)
                Application.DoEvents();
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Visible = true;
        }
    }
}
