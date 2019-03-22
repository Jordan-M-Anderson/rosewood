using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerProposalForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QuickPlay_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();           //Hide the main form before showing the secondary
            frm3.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            this.Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();           //Hide the main form before showing the secondary
            frm2.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
