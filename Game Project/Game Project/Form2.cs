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
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        public static double playerHealth = 100;


        public Form2()
        {
            InitializeComponent();
            textBoxMain.AppendText("You Have entered into battle with " + Form4.bossName + Environment.NewLine + "Please select a move" + Environment.NewLine);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void bossMove()
        {
            int move = rnd.Next(1, 4);
            switch (move)
            {
                case 1:
                    int DMG = Convert.ToInt32(rnd.Next(5, 20) * Form4.bossPhyDmg * Form3.armourPhyDef);
                    bossDMG(DMG);
                    break;
                case 2:
                    DMG = Convert.ToInt32(rnd.Next(5, 20) * Form4.bossPhyDmg * Form3.armourPhyDef);
                    bossDMG(DMG);
                    break;
                case 3:
                    DMG = Convert.ToInt32(rnd.Next(5, 20) * Form4.bossMagDmg * Form3.armourMagDef);
                    bossDMG(DMG);
                    break;
                case 4:
                    DMG = Convert.ToInt32(rnd.Next(5, 20) * Form4.bossMagDmg * Form3.armourMagDef);
                    bossDMG(DMG);
                    break;
            }
        }

        private void bossDMG(int DMG)
        {
            playerHealth = playerHealth - DMG;
            textBoxMain.AppendText("Player has taken " + DMG + " Damage" + Environment.NewLine);
            healthCheck();

        }


        private void healthCheck()
        {
            if (Form4.bossHealth <= 0)
            {
                textBoxMain.AppendText(Form4.bossName + " has died Player Wins");
                End();
            }
            else if (playerHealth <= 0)
            {
                textBoxMain.AppendText(playerHealth + " has died " + Form4.bossName + " Wins");
                End();
            }
            
        }

        private void End()
        {
            buttonMove1.Visible = false;
            buttonMove2.Visible = false;
            buttonMove3.Visible = false;
            buttonMove4.Visible = false;
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < 1000)
                Application.DoEvents();
            this.Visible = false;
            Form4 form4 = new Form4();
            form4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DMG = Convert.ToInt32(rnd.Next(10,20) * Form4.bossPhyDef * Form3.weaponPhyDmg);
            Form4.bossHealth = Form4.bossHealth - DMG;
            textBoxMain.AppendText(Form4.bossName + " has taken " + DMG + " Damage" + Environment.NewLine);
            label2.Text = Form4.bossHealth.ToString();
            healthCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int DMG = Convert.ToInt32(rnd.Next(1, 30) * Form4.bossPhyDef * Form3.weaponPhyDmg);
            Form4.bossHealth = Form4.bossHealth - DMG;
            textBoxMain.AppendText(Form4.bossName + " has taken " + DMG + " Damage" + Environment.NewLine);
            label2.Text = Form4.bossHealth.ToString();
            healthCheck();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int DMG = Convert.ToInt32(rnd.Next(0, 100) * Form4.bossMagDef * Form3.weaponMagDmg * rnd.Next(0, 1));
            Form4.bossHealth = Form4.bossHealth - DMG;
            textBoxMain.AppendText(Form4.bossName + " has taken " + DMG + " Damage" + Environment.NewLine);
            label2.Text = Form4.bossHealth.ToString();
            healthCheck();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int DMG = Convert.ToInt32(rnd.Next(13, 18) * Form4.bossMagDef * Form3.weaponMagDmg);
            Form4.bossHealth = Form4.bossHealth - DMG;
            textBoxMain.AppendText(Form4.bossName + " has taken " + DMG + " Damage" + Environment.NewLine);
            label2.Text = Form4.bossHealth.ToString();
            healthCheck();
        }


        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }


    }
}
