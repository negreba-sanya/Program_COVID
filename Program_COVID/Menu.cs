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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection fonts = new System.Drawing.Text.PrivateFontCollection();
            fonts.AddFontFile("JOURNALISM.ttf");
            fonts.AddFontFile("Montserrat-Regular.ttf");
            
            label1.Font = new Font(fonts.Families[0], 48);
            label2.Font = new Font(fonts.Families[1], 9);
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.DeepPink;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.DeepPink;
            button1.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.DeepPink;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button4.BackColor = Color.DeepPink;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.DeepPink;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Film film = new Film();
            film.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sport sport = new Sport();
            sport.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Music music = new Music();
            music.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            game.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books books = new Books();
            books.Show();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.A)
            {
                this.Hide();
                Film film = new Film();
                film.Show();
            }

            if (e.KeyValue == (char)Keys.C)
            {
                this.Hide();
                Sport sport = new Sport();
                sport.Show();
            }

            if (e.KeyValue == (char)Keys.V)
            {
                this.Hide();
                Music music = new Music();
                music.Show();
            }

            if (e.KeyValue == (char)Keys.B)
            {
                this.Hide();
                Game game = new Game();
                game.Show();
            }

            if (e.KeyValue == (char)Keys.R)
            {
                this.Hide();
                Books books = new Books();
                books.Show();
            }

            if (e.KeyValue == (char)Keys.Escape)
            {
                DialogResult dialog = MessageBox.Show("Ты точно уверен?","Проверка", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialog == DialogResult.No)
                {

                }
            }
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.PrivateFontCollection fonts = new System.Drawing.Text.PrivateFontCollection();
            System.Drawing.Text.PrivateFontCollection fonts_1 = new System.Drawing.Text.PrivateFontCollection();
            fonts.AddFontFile("JOURNALISM.ttf");
            fonts.AddFontFile("Montserrat-Regular.ttf");
            fonts_1.AddFontFile("Montserrat-SemiBold.ttf");

            label1.Font = new Font(fonts.Families[0], 48);
            label2.Font = new Font(fonts.Families[1], 9);

            button1.Font = new Font(fonts_1.Families[0], 8);
            button2.Font = new Font(fonts_1.Families[0], 8);
            button3.Font = new Font(fonts_1.Families[0], 8);
            button4.Font = new Font(fonts_1.Families[0], 8);
            button5.Font = new Font(fonts_1.Families[0], 8);
        }
    }
}
