using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_COVID
{
    public partial class Music : Form
    {
        public Music()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection fonts = new System.Drawing.Text.PrivateFontCollection();
            fonts.AddFontFile("JOURNALISM.ttf");
            fonts.AddFontFile("Montserrat-Regular.ttf");
            fonts.AddFontFile("Montserrat-SemiBold.ttf");

            label1.Font = new Font(fonts.Families[0], 48);

            label2.Font = new Font(fonts.Families[2], 12);
            label3.Font = new Font(fonts.Families[1], 12);

            label5.Font = new Font(fonts.Families[2], 12);
            label4.Font = new Font(fonts.Families[1], 12);

            label7.Font = new Font(fonts.Families[2], 12);
            label6.Font = new Font(fonts.Families[1], 12);

            label9.Font = new Font(fonts.Families[2], 12);
            label8.Font = new Font(fonts.Families[1], 12);

            label11.Font = new Font(fonts.Families[2], 12);
            label10.Font = new Font(fonts.Families[1], 12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer("Coldplay.wav");
            Audio.Load(); Audio.PlayLooping();
            button1.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button6.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }
                
        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer("Linkin_Park.wav");
            Audio.Load(); Audio.PlayLooping();
            button2.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button7.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer("Obsession.wav");
            Audio.Load(); Audio.PlayLooping();
            button3.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button8.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer("SuicideBoys.wav");
            Audio.Load(); Audio.PlayLooping();
            button4.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button10.Visible = false;
            button9.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer("Surf_Mesa.wav");
            Audio.Load(); Audio.PlayLooping();
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void Music_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer("Coldplay.wav");
            Audio.Stop();
            Music music = new Music();
            Menu menu = new Menu();
            music.Hide();
            menu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer("Coldplay.wav");
            Audio.Stop();
            button6.Visible = false;
            button1.Visible = true;
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer("Linkin_Park.wav");
            Audio.Stop();
            button7.Visible = false;
            button2.Visible = true;
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer("Obsession.wav");
            Audio.Stop();
            button8.Visible = false;
            button3.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer("SuicideBoys.wav");
            Audio.Stop();
            button9.Visible = false;
            button4.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer("Surf_Mesa.wav");
            Audio.Stop();
            button10.Visible = false;
            button5.Visible = true;
        }

        private void Music_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                System.Media.SoundPlayer Audio;
                Audio = new System.Media.SoundPlayer("Coldplay.wav");
                Audio.Stop();
                Menu menu = new Menu(); 
                this.Hide();
                menu.Show();
            }
        }
    }
}
