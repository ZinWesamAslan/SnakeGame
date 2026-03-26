using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AslanSnakeGame
{
    public partial class frmAwards : Form
    {

        private void SetUpLabels()
        {
            lblCoins.Text = GameSettings.TotalCoins.ToString();
            lblR1.Text =    GameSettings.TotalEatenFoods.ToString()+"//"+1000;
            lblR2.Text =    GameSettings.TotalMatches.ToString() + "//" + 200;
            lblR3.Text =    GameSettings.BestScoreEver.ToString() + "//" + 150;
            lblR4.Text =    GameSettings.TotalTimeSpentOnGame.ToString() + "//" + 10000;
        }

        private void SetUpButtons()
        {
            int n = GameSettings.ClaimedAwards;
            if ((1 | n) == n) btnClaimAward1.Enabled = false;
            if ((2 | n) == n) btnClaimAward2.Enabled = false;
            if ((4 | n) == n) btnClaimAward3.Enabled = false;
            if ((8 | n) == n) btnClaimAward4.Enabled = false;

            if (GameSettings.TotalEatenFoods >= 1000)
            {
                picLockAward1.Visible = false;
                btnClaimAward1.Visible = true;
            }
            if (GameSettings.TotalMatches >= 200)
            {
                picLockAward2.Visible = false;
                btnClaimAward2.Visible = true;
            }
            if (GameSettings.BestScoreEver >= 150)
            {
                picLockAward3.Visible = false;
                btnClaimAward3.Visible = true;
            }
            if (GameSettings.TotalTimeSpentOnGame >= 10000)
            {
                picLockAward4.Visible = false;
                btnClaimAward4.Visible = true;
            }

        }

        public frmAwards()
        {
            InitializeComponent();
            SetUpLabels();
            SetUpButtons(); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SystemSettings.SoundOfButtonClick.Play();
            this.Close();
        }


        private void UpdateCoins(int btnTag)
        {
            if (btnTag == 1) GameSettings.TotalCoins += 1000;
            else if (btnTag == 2) GameSettings.TotalCoins += 500;
            else if (btnTag == 4) GameSettings.TotalCoins += 600;
            else if (btnTag == 8) GameSettings.TotalCoins += 2000;
        }

        private void Claim(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            UpdateCoins(Convert.ToInt32(b.Tag));
            GameSettings.ClaimedAwards += Convert.ToInt32(b.Tag);
            lblCoins.Text = GameSettings.TotalCoins.ToString();
            b.Enabled = false;
            SystemSettings.UpdateGameSettingFileContent();
        }
    }
}
