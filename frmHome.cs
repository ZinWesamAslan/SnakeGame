using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Media;

namespace AslanSnakeGame
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            InitializeBtnsPicBoxesArray();
            Clock.Start();
            SetUpLabels();
            snake.SetUpSnake();
            snake.Direction = Snake.enDirection.Down;
            SnakeTimer.Start();
            new GameSettings();
        }
        private void SetUpLabels()
        {
            lblBestScoreEver.Text = Convert.ToString(GameSettings.BestScoreEver);
            lblFoodNumber.Text = Convert.ToString(GameSettings.TotalEatenFoods);
            lblGameNumber.Text = Convert.ToString(GameSettings.TotalMatches);
            lblSpentTime.Text = Convert.ToString(GameSettings.TotalTimeSpentOnGame);
            lblCoins.Text = Convert.ToString(GameSettings.TotalCoins);
        }

        private void InitializeBtnsPicBoxesArray()
        {
            SystemSettings.HomeBtnsPicBoxes[0] = picPlayButton;
            SystemSettings.HomeBtnsPicBoxes[1] = pic1v1Button;
            SystemSettings.HomeBtnsPicBoxes[2] = picSettingsButton;
            SystemSettings.HomeBtnsPicBoxes[3] = picScoreButton;
            SystemSettings.HomeBtnsPicBoxes[4] = picAwardsButton;
            SystemSettings.HomeBtnsPicBoxes[5] = picCloseButton;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Focus(object sender, EventArgs e)
        {
            SystemSettings.btn_UpdateEffects(SystemSettings.HomeBtnsPicBoxes,true,(Button)sender);
        }

        private void btn_NotFocus(object sender, EventArgs e)
        {
            SystemSettings.btn_UpdateEffects(SystemSettings.HomeBtnsPicBoxes,false, (Button)sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SystemSettings.SoundOfButtonClick.Play();
            new frmSettings().ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SnakeTimer.Stop();
            SystemSettings.SoundOfButtonClick.Play();
            new frmMainMode().ShowDialog();
            SetUpLabels();
            SnakeTimer.Start();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            SystemSettings.SoundOfButtonClick.Play();
            new frmTop().ShowDialog();
        }

        private void btn1v1_Click(object sender, EventArgs e)
        {
            
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH,mm,ss");
        }


        public static Snake snake = new Snake();
        private void picSnakeBox_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < snake.Count(); i++)
            {
                if (i == 0) e.Graphics.FillEllipse(GameSettings.SnakeHeadColor, new Rectangle(snake.At(i).x * 35,snake.At(i).y * 35,35,35));
                else e.Graphics.FillEllipse(GameSettings.SnakeBodyColor, new Rectangle(snake.At(i).x * 35, snake.At(i).y * 35, 35, 35));
            }
        }
        private void Logic()
        {
            //snake.UpdateDirection();
            for (int i = snake.Count() - 1; i >= 0; i--)
            {
                if (i == 0)snake.UpdateHeadXAndY();
                else snake.UpdateTailXAndY(i);
            }
        }
        private void SnakeTimer_Tick(object sender, EventArgs e)
        {
            Logic();
            picSnakeBox.Invalidate();
        }

        private void btnAwards_Click(object sender, EventArgs e)
        {
            SystemSettings.SoundOfButtonClick.Play();
            new frmAwards().ShowDialog();
        }

        private void picShoppingStore_Click(object sender, EventArgs e)
        {
            SystemSettings.SoundOfButtonClick.Play();
            new FrmShoppingStore().ShowDialog();
        }
    }
}
