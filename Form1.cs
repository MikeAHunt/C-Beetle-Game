using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beetle_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num; //int is randomized for the random function
                Random rollDie = new Random();
                num = rollDie.Next(6); //die value range for 6 faces
                pictureBox1.Visible = true;
                pictureBox1.Image = imageList1.Images[num];

                if (num < 1 && picBoxEyeL.Visible)// SECOND eye
                {
                    picBoxEyeR.Visible = true;
                    label1.Text = "You got an antenna";
                }
                if (num < 2 && num >= 1 && picBoxAntL.Visible)//SECOND ant
                {
                    picBoxAntR.Visible = true;
                    label1.Text = "You got an antenna";
                }
                if (num < 3 && num >= 2 && picBoxLegR.Visible)//FOURTH leg
                {
                    picBoxLegR2.Visible = true;
                    label1.Text = "You got a leg";
                }
                if (num < 3 && num >= 2 && picBoxLegL2.Visible)//THIRD leg
                {
                    picBoxLegR.Visible = true;
                    label1.Text = "You got a leg";
                }
                if (num < 3 && num >= 2 && picBoxLegL.Visible)//SECOND leg
                {
                    picBoxLegL2.Visible = true;
                    label1.Text = "You got a leg";
                }            
                if (num < 4 && num >= 3 && picBoxArmL.Visible)//SECOND arm
                {
                    picBoxArmR.Visible = true;
                    label1.Text = "You got a leg";
                }
                if (num < 1 && picBoxHead.Visible)//FIRST eye
                {
                    picBoxEyeL.Visible = true;
                    label1.Text = "You got an eye";
                }
                if (num < 2 && num >=1 && picBoxHead.Visible)//FIRST antenna
                {
                    picBoxAntL.Visible = true;
                    label1.Text = "You got an antenna";
                }
                if (num < 3 && num >= 2 && picBoxBody.Visible)//FIRST leg
                {
                    picBoxLegL.Visible = true;
                    label1.Text = "You got a leg";
                }
                if (num < 4 && num >= 3 && picBoxHead.Visible)//FIRST uppermost legs
                {
                    picBoxArmL.Visible = true;
                    label1.Text = "You got a leg";
                }
                if (num < 5 && num >= 4 && picBoxBody.Visible)//For head
                {
                    picBoxHead.Visible = true;
                    label1.Text = "You got the head";
                }
                if (num >= 5)//for body
                {
                    picBoxBody.Visible = true;
                    label1.Text = "You got the body";
                }
                
                else
                {
                    label1.Text = "Keep rollin'...";
                }
                if (picBoxAntL.Visible && picBoxAntR.Visible && picBoxArmL.Visible && picBoxArmR.Visible && picBoxBody.Visible && picBoxEyeL.Visible && picBoxEyeR.Visible && picBoxHead.Visible && picBoxLegL.Visible && picBoxLegL2.Visible && picBoxLegR.Visible && picBoxLegR2.Visible)
                {
                    MessageBox.Show("You Win!");
                    picBoxBeetle.Visible = true;
                    pictureBox1.Visible = false; //clears image for new game
                    picBoxLegR2.Visible = false;
                    picBoxLegR.Visible = false;
                    picBoxLegL2.Visible = false;
                    picBoxLegL.Visible = false;
                    picBoxHead.Visible = false;
                    picBoxEyeR.Visible = false;
                    picBoxEyeL.Visible = false;
                    picBoxBody.Visible = false;
                    picBoxArmR.Visible = false;
                    picBoxArmL.Visible = false;
                    picBoxAntR.Visible = false;
                    picBoxAntL.Visible = false;
                    label1.Text = "";
                }
                                                                       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false; //clears image for new game
            picBoxLegR2.Visible = false;
            picBoxLegR.Visible = false;
            picBoxLegL2.Visible = false;
            picBoxLegL.Visible = false;
            picBoxHead.Visible = false;
            picBoxEyeR.Visible = false;
            picBoxEyeL.Visible = false;
            picBoxBody.Visible = false;
            picBoxArmR.Visible = false;
            picBoxArmL.Visible = false;
            picBoxAntR.Visible = false;
            picBoxAntL.Visible = false;
            picBoxBeetle.Visible = false;
            label1.Text = "";
            

        }

        private void picBoxBody_Click(object sender, EventArgs e)
        {

        }
    }
}
