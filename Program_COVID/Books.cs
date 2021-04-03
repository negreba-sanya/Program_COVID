using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_COVID
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection fonts = new System.Drawing.Text.PrivateFontCollection();
            fonts.AddFontFile("JOURNALISM.ttf");
            fonts.AddFontFile("Montserrat-Regular.ttf");

            label1.Font = new Font(fonts.Families[0], 48);
            label3.Font = new Font(fonts.Families[1], 12);
            richTextBox1.Font = new Font(fonts.Families[1], 11);

        }

        private void Books_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("t_pof-2.txt", Encoding.Default);
        }

        private void Books_KeyDown(object sender, KeyEventArgs e)
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
