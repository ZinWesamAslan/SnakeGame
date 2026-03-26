using AslanSnakeGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AslanSnakeGame
{
    public partial class frmMainMode : Form
    {
        public static Snake snake = new Snake();
        public static Foods foods = new Foods();
        public static Blocks blocks = new Blocks();

        //public Snake snake = new Snake();
        //public Foods foods = new Foods();
        //public Blocks blocks = new Blocks();

        public static int Matches { get; set; } = 0;
        public static int Time {  get; set; } = 0;
        public static int NFoods { get; set; } = 0;

        public frmMainMode()
        {
            InitializeComponent();
            new GameSettings();
        }

        private void clearAll()
        {
            snake.Clear();
            foods.Clear();
            blocks.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            reStartGame();
            
        }

        private void btn_Focus(object sender, EventArgs e)
        {
            SystemSettings.btn_UpdateEffects(SystemSettings.HomeBtnsPicBoxes, true, (Button)sender);
        }

        private void btn_NotFocus(object sender, EventArgs e)
        {
            SystemSettings.btn_UpdateEffects(SystemSettings.HomeBtnsPicBoxes, false, (Button)sender);
        }

        private void SetUpLabels()
        {
            lblScore.ForeColor = Color.White;
            lblBestScore.ForeColor = Color.White;
            lblScore.Text = "Score : " + snake.Score;
        }

        private void SetUpProfile()
        {

            picMainPlayerProfile.Image = GameSettings.image;
            lblMainPlayerName.Text = GameSettings.PlayerName;
            

        }

        private void setUp()
        {
             
            SystemSettings.GameDate = DateTime.Now; 
            GameSettings.GameIsOver = false;
            SystemSettings.UpdatePngsFile();
            GameSettings.SetCircleHeightAndWidth();
            GameSettings.SetGroundMaxMinHeightLength();
            GameSettings.MatchTime = 0;
            picMainModeTable.Image = Image.FromFile(SystemSettings.GroundImagesPath[GameSettings.GroundImageIndex]);
            picMainModeTable.BackColor = GameSettings.GroundColor;
            SetUpProfile();
            GameTimer.Interval = Convert.ToInt16(GameSettings.GameSpeed);
            clearAll();
            snake.SetUpSnake();
            SetUpLabels();
            foods.AddFoods(snake,blocks);
        }

        public void FixBtnStartStatus()
        {
            if (GameSettings.GameIsOver)
            {
                btnStartMainMode.Visible = true;
                btnStartMainMode.Enabled = true;
            }
            else
            {
                btnStartMainMode.Visible = false;
                btnStartMainMode.Enabled = false;
            }
        }

        private void reStartGame()
        {
            setUp();
            FixBtnStartStatus();
            GameTimer.Start();
            TimeTimer.Start();
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GameTimer.Stop();
                CountDownTimer_BlueFood.Stop();
                CountDownTimer_GreenFood.Stop();
                TimeTimer.Stop();
                new frmAreYouSureToExit().ShowDialog();
                if (frmAreYouSureToExit.result == 3)
                {
                    GameOver();
                    new frmMatchStatistics(lblBestScore.Text).ShowDialog();
                    this.Close();
                }
                else if(frmAreYouSureToExit.result == 1 )
                {
                    if(snake.isEatBlueFood)
                    {
                        CountDownTimer_BlueFood.Start();
                    }
                    if(snake.IsEatGreenFood)
                    {
                        CountDownTimer_GreenFood.Start();
                    }
                    GameTimer.Start();
                    TimeTimer.Start();
                }

            }
            snake.keyIsDown(e);
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            snake.keyIsUp(e);
        }

        private void UpdateScoreLabel()
        {

            lblScore.Text = "Score : " + snake.Score;

        }
        // comp...
        private void DoEatFoodEffect(int Index)
        {
            if (foods.At(Index).FoodName.Equals(Food.enFoodsName.RedFood))
            {
                snake.Score++;
                snake.AddAtEnd();
            }
            else if(foods.At(Index).FoodName.Equals(Food.enFoodsName.YellowFood))
            {
                snake.Score += 5;
                snake.AddAtEnd(5);
            }
            else if (foods.At(Index).FoodName.Equals(Food.enFoodsName.BlueFood))
            {
                snake.Score++;
                snake.AddAtEnd();
                CountDownTimer_BlueFood.Start();
            }
            else if (foods.At(Index).FoodName.Equals(Food.enFoodsName.GreenFood))
            {
                snake.Score++;
                snake.AddAtEnd();
                CountDownTimer_GreenFood.Start();
            }
        }
        
        private void EatFood(int Index, Snake snake)
        {
            if (Index != -1)
            {
                DoEatFoodEffect(Index);
                UpdateScoreLabel();

                foods.RemoveAt(Index);
                
                if (snake.Score % Convert.ToInt16(GameSettings.NumberToCreateBlock) == 0)
                    blocks.AddOneBlock(snake, foods);
                foods.AddOneFood(snake, blocks);
            }

        }


        private bool Logic()
        {
            snake.UpdateDirection();
            for (int i = snake.Count() - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    snake.UpdateHeadXAndY();
                    if (snake.SnakeIsDied(blocks))
                    {
                        GameOver();
                        return true;
                    }
                    EatFood(snake.GetEatenFoodInex(foods), snake);
                }
                else
                {
                    snake.UpdateTailXAndY(i);
                }

            }
            return false;
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Logic();
            picMainModeTable.Invalidate();
        }

        private void picTableGraphicsUpdate(object sender, PaintEventArgs e)
        {
            SystemSettings.UpdateBlocksColor(blocks,e);
            SystemSettings.UpdateFoodsColor(foods ,e);
            SystemSettings.EditSnakeColor(snake ,e);
        }

        private void GameOver()
        {

            GameSettings.GameIsOver = true;
            
            if (snake.Score != 0)
            {
                if (snake.Score > GameSettings.BestScoreEver) GameSettings.BestScoreEver = snake.Score;
                GameSettings.TotalEatenFoods += snake.Score;
                GameSettings.TotalTimeSpentOnGame += GameSettings.MatchTime;
                GameSettings.TotalMatches++;
                GameSettings.TotalCoins += snake.Score;
                Matches++;
                NFoods += snake.Score;
                Time += GameSettings.MatchTime;
                SystemSettings.WriteTheRecordOnTheFile(GameSettings.PlayerImagePath, lblMainPlayerName, snake.Score);
                SystemSettings.UpdateGameSettingFileContent();
            }
            FixBtnStartStatus();
            if (snake.Score > snake.BestScore)
            {
                snake.BestScore = snake.Score;
                lblBestScore.Text = "BestScore : " + snake.Score;
            }
            lblBestScore.ForeColor = Color.Red;
            lblScore.ForeColor = Color.Blue;

            SystemSettings.NumberTen = 10;
            SystemSettings.NumberTwenty = 20;
            lblGreenFoodEffectTimer.Visible = false;
            lblBlueFoodEffectTimer.Visible = false;
            GameTimer.Stop();
            CountDownTimer_BlueFood.Stop();
            CountDownTimer_GreenFood.Stop();
            
        }

        private void CountDownTimerEvent_BlueFood(object sender, EventArgs e)
        {
            if (SystemSettings.NumberTen == 10)
            {
                GameTimer.Interval -= SystemSettings.IncreaseSpeedBy();
                lblBlueFoodEffectTimer.Visible = true;
                snake.isEatBlueFood = true;
            }
            if(--SystemSettings.NumberTen == 0)
            {
                GameTimer.Interval += SystemSettings.IncreaseSpeedBy(); ;
                snake.isEatBlueFood = false;
                CountDownTimer_BlueFood.Stop();
                SystemSettings.NumberTen = 10;
                lblBlueFoodEffectTimer.Visible = false;
            }
            lblBlueFoodEffectTimer.Text = Convert.ToString(SystemSettings.NumberTen);
        }

        private void CountDownTimerEvent_GreenFood(object sender, EventArgs e)
        {
            if (SystemSettings.NumberTwenty == 20)
            {
                snake.IsEatGreenFood = true;
                lblGreenFoodEffectTimer.Visible = true;
            }
            if (--SystemSettings.NumberTwenty == 0)
            {
                snake.IsEatGreenFood = false;
                CountDownTimer_GreenFood.Stop();
                SystemSettings.NumberTwenty = 20;
                lblGreenFoodEffectTimer.Visible = false;
            }
            lblGreenFoodEffectTimer.Text = Convert.ToString(SystemSettings.NumberTwenty);
        }
        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            GameSettings.MatchTime++;
        }


    }
}
