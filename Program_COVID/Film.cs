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
    public partial class Film : Form
    {
        public Film()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection fonts = new System.Drawing.Text.PrivateFontCollection();
            fonts.AddFontFile("JOURNALISM.ttf");
            fonts.AddFontFile("Montserrat-Regular.ttf");

            label1.Font = new Font(fonts.Families[0], 48);
        }

        private void Film_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Hide();
            Film_one film_p = new Film_one();
            film_p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Hide();
            Film_two film_p = new Film_two();
            film_p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Hide();
            Film_three film_p = new Film_three();
            film_p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Hide();
            Film_four film_p = new Film_four();
            film_p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Hide();
            Film_five film_p = new Film_five();
            film_p.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Hide();
            Film_six film_p = new Film_six();
            film_p.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Hide();
            Film_seven film_p = new Film_seven();
            film_p.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Hide();
            Film_eight film_p = new Film_eight();
            film_p.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Hide();
            Film_nine film_p = new Film_nine();
            film_p.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Hide();
            Film_ten film_p = new Film_ten();
            film_p.Show();
        }

        private void Film_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.D1)
            {
                this.Hide();
                Film_one film = new Film_one();
                film.Show();
            }

            if (e.KeyValue == (char)Keys.D2)
            {
                this.Hide();
                Film_two film = new Film_two();
                film.Show();
            }

            if (e.KeyValue == (char)Keys.D3)
            {
                this.Hide();
                Film_three film = new Film_three();
                film.Show();
            }

            if (e.KeyValue == (char)Keys.D4)
            {
                this.Hide();
                Film_four film = new Film_four();
                film.Show();
            }

            if (e.KeyValue == (char)Keys.D5)
            {
                this.Hide();
                Film_five film = new Film_five();
                film.Show();
            }

            if (e.KeyValue == (char)Keys.D6)
            {
                this.Hide();
                Film_six film = new Film_six();
                film.Show();
            }

            if (e.KeyValue == (char)Keys.D7)
            {
                this.Hide();
                Film_seven film = new Film_seven();
                film.Show();
            }

            if (e.KeyValue == (char)Keys.D8)
            {
                this.Hide();
                Film_eight film = new Film_eight();
                film.Show();
            }

            if (e.KeyValue == (char)Keys.D9)
            {
                this.Hide();
                Film_nine film = new Film_nine();
                film.Show();
            }

            if (e.KeyValue == (char)Keys.D0)
            {
                this.Hide();
                Film_ten film = new Film_ten();
                film.Show();
            }

            if (e.KeyValue == (char)Keys.Escape)
            {
                Film film = new Film();
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
        }
    }
}
