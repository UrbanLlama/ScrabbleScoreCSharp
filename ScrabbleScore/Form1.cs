using System;
using System.Windows.Forms;

namespace ScrabbleScore
{
    public partial class fMain : Form
    {

        public fMain()
        {
            InitializeComponent();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.D2
                || e.KeyChar == (char)Keys.D3);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            Scorer scorer = new Scorer();
            lblScore.Text = "Score: " + scorer.GetScore(txtInput.Text).ToString();
        }
    }
}
