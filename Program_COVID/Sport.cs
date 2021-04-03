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
    public partial class Sport : Form
    {
        public Sport()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection fonts = new System.Drawing.Text.PrivateFontCollection();
            fonts.AddFontFile("JOURNALISM.ttf");
            fonts.AddFontFile("Montserrat-Regular.ttf");

            label1.Font = new Font(fonts.Families[0], 48);
            listBox1.Font = new Font(fonts.Families[1], 10);
        }

        private void Sport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sport sport = new Sport();
            Menu menu = new Menu();
            sport.Hide();
            menu.Show();
        }

        private void Sport_KeyDown(object sender, KeyEventArgs e)
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
