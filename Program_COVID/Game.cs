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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection fonts = new System.Drawing.Text.PrivateFontCollection();
            fonts.AddFontFile("JOURNALISM.ttf");
            fonts.AddFontFile("Montserrat-Regular.ttf");
            fonts.AddFontFile("Montserrat-SemiBold.ttf");

            label1.Font = new Font(fonts.Families[0], 48);
            label2.Font = new Font(fonts.Families[2], 12);
            label3.Font = new Font(fonts.Families[1], 12);
            label4.Font = new Font(fonts.Families[1], 11);
            label5.Font = new Font(fonts.Families[1], 11);
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Game game = new Game();
            Menu menu = new Menu();
            game.Hide();
            menu.Show();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
        }
    }
}
