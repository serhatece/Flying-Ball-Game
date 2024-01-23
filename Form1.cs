using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flying_Ball_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yerX = 5, yerY = 5, can = 3;

        private void CarpmaOlayı()
        { 
            // label2 carpma
            if(ball.Top <= label2.Bottom)
            {
                yerY = yerY * -1;
            }

            // kontrole carpma olayı
            if(ball.Bottom >= control.Top && ball.Left >= control.Left && ball.Right <= control.Right)
            {
                yerY = yerY * -1;
            }

            //sag kenara carpma olayı
            else if(ball.Right >= label4.Left)
            {
                yerX = yerX * -1;
            }
            //sol kenara carpma olayı
            else if(ball.Left <= label1.Right)
            {
                yerX = yerX * -1;
            }
        }

        private void YanmaOLayı(object sender, EventArgs e)
        {
            if(ball.Top >= label4.Bottom)
            {
                if(can > 0)
                {
                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yandınız kalan can : " + can.ToString());
                    Form1_Load(sender, e);
                }

                if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Game Over ","",MessageBoxButtons.OK);
                }
            }
            label3.Text = can.ToString();
        }

        private void Topbasa()
        {
            ball.Location = new Point(198, 92);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            control.Left = e.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Topbasa();
            timer1.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void control_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            CarpmaOlayı();
            YanmaOLayı(sender,e);
            ball.Location = new Point(ball.Location.X + yerX, ball.Location.Y + yerY);
        }
    }
}
