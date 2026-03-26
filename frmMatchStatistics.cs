using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AslanSnakeGame
{
    public partial class frmMatchStatistics : Form
    {
        public frmMatchStatistics(string BestScore)
        {
            InitializeComponent();
            SetUpLabels(BestScore);
        }

        private void SetUpLabels(string BestScore)
        {
            lblBestScore.Text = BestScore;
            lblFoods.Text += frmMainMode.NFoods.ToString();
            lblTime.Text += frmMainMode.Time.ToString();
            lblMatches.Text += frmMainMode.Matches.ToString();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Focus(object sender, EventArgs e)
        {
            SystemSettings.btn_UpdateEffects(true , (Button)sender);
        }

        private void btn_NotFocus(object sender, EventArgs e)
        {
            SystemSettings.btn_UpdateEffects(false, (Button)sender);
        }
    }
}
