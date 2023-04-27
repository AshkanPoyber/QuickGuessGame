using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace QuickGuess
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer MyMusic = new WMPLib.WindowsMediaPlayer();

        Random Random = new Random();
        int sec = 10;
        public Form1()
        {
            InitializeComponent();

            MyMusic.URL = "Best Relax Music 01.mp3";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MyMusic.controls.play();

            label4.Text = sec.ToString();
            sec -= 1;
            if(sec < 3)
            {
                Console.Beep(500,50);
            }


            if (sec == -1)
            {
                timer1.Enabled = false;

                if (numericUpDown1.Value == int.Parse(label1.Text) + int.Parse(label3.Text))
                {
                    MessageBox.Show("Perfect 👌");
                }
                else
                {
                    MessageBox.Show("What??!! 😢👀");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sec = 10;
            timer1.Enabled = true;
            label1.Text = Random.Next(0,51).ToString();
            label3.Text = Random.Next(0,51).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == int.Parse(label1.Text)+int.Parse(label3.Text))
            {
                MessageBox.Show("Perfect");
            }
            else
            {
                MessageBox.Show("What??!! :|");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MyMusic.controls.play();
            }
            else
            {
                MyMusic.controls.stop();
            }
        }
    }
}
