using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheGame
{
    public partial class EndPractice : Form
    {
        public EndPractice()
        {
            InitializeComponent();
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void backToMenu_MouseEnter(object sender, EventArgs e)
        {
            backToMenu.ForeColor = Color.White;
        }

        private void backToMenu_MouseLeave(object sender, EventArgs e)
        {
            backToMenu.ForeColor = Color.Black;
        }

    }
}
