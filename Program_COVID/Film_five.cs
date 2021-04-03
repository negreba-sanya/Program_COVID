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
    public partial class Film_five : Form
    {
        public Film_five()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection fonts = new System.Drawing.Text.PrivateFontCollection();
            fonts.AddFontFile("JOURNALISM.ttf");
            fonts.AddFontFile("Montserrat-Regular.ttf");
            fonts.AddFontFile("Montserrat-SemiBold.ttf");

            label1.Font = new Font(fonts.Families[2], 20);
            label2.Font = new Font(fonts.Families[2], 12);
            label3.Font = new Font(fonts.Families[2], 12);
            label4.Font = new Font(fonts.Families[2], 22);
            label5.Font = new Font(fonts.Families[2], 10);
        }

        private void Film_five_FormClosed(object sender, FormClosedEventArgs e)
        {
            Film_five film = new Film_five();
            film.Hide();
            Film film_menu = new Film();
            film_menu.Show();
        }

        private void Film_five_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                Film film = new Film();
                this.Hide();
                film.Show();
            }
        }
    }
}
