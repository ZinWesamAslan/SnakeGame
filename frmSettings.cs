using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AslanSnakeGame
{
    public partial class frmSettings : Form
    {

        public frmSettings()
        {
            InitializeComponent();
            InitializeToolTip();
            SetUpControls();
            snake.SetUpSnake();
            snake.Direction = Snake.enDirection.Right;
            snake.At(0).x = 0;
            snake.At(0).y = 5;
            block.y = 1; block.x = 1;
            food.y = 8; food.x = 10;
            SnakeTimer.Start();
        }

        private void SetUpControls()
        {
            txtPlayerNameSettingFrm.Text = GameSettings.PlayerName;
            picProfileSettingFrm.Image = GameSettings.image;
            picSnakeHeadColor.BackColor = ((SolidBrush)GameSettings.SnakeHeadColor).Color;
            picSnakeBodyColor.BackColor = ((SolidBrush)GameSettings.SnakeBodyColor).Color;
            picFoodsColor.BackColor = ((SolidBrush)GameSettings.FoodColor).Color;
            picBlocksColor.BackColor = ((SolidBrush)GameSettings.BlocksColor).Color;
            SetUpGameModeBtns();
            SetUpGameSpeedBtns();
            SetUpGroundAreaBtns();
            SetUpHMFTCBlockBtns();
            SetFoodsInGroundBtns();
            SetSnakeLengthBtns();
            if(GameSettings.GameIsOver == false)
            {
                txtPlayerNameSettingFrm.Enabled = false;
                picProfileSettingFrm.Enabled=false;
                picEditProfilePhoto.Enabled=false;
                btnNormalGameModeChoise.Enabled=false;
                btnCrazyGameModeChoise.Enabled = false;
                btnQuickGameSpeedChoise.Enabled=false;
                btnSlowGameSpeedChoise.Enabled = false;
                btnMidGameSpeedChoise.Enabled = false;
                btnSmallGroundAreaChoise.Enabled=false;
                btnBigGroundAreaChoise.Enabled = false;
                btnNormalGroundAreaChoise.Enabled = false;
                btn10HMFTCBchoise.Enabled=false;
                btn20HMFTCBchoise.Enabled=false;
                btnNoBlocksHMFTCBchoise.Enabled = false;
                btnOneFoodsInGroundChoise.Enabled =false;
                btnThreeFoodsInGroundChoise.Enabled = false;
                btnTwoSnakeLengthChoise.Enabled = false;
                btnFourSnakeLengthChoise.Enabled = false;
                btnFiveFoodsInGroundChoise.Enabled = false;
                btnSixSnakeLengthChoise.Enabled = false;
            }
        }

        private void SetUpGameModeBtns()
        {
            if (GameSettings.GameMode.Equals(GameSettings.enGameMode.Normal))
            {
                SystemSettings.MakeButtonPurple(btnNormalGameModeChoise);
            }
            else if (GameSettings.GameMode.Equals(GameSettings.enGameMode.Crazy))
            {
                SystemSettings.MakeButtonPurple(btnCrazyGameModeChoise);
            }
        }

        private void SetFoodsInGroundBtns()
        {
            if (GameSettings.NumberOfFoods.Equals(GameSettings.enNumberOfFoods.One))
            {
                SystemSettings.MakeButtonPurple(btnOneFoodsInGroundChoise);
            }
            else if (GameSettings.NumberOfFoods.Equals(GameSettings.enNumberOfFoods.Three))
            {
                SystemSettings.MakeButtonPurple(btnThreeFoodsInGroundChoise);
            }
            else if (GameSettings.NumberOfFoods.Equals(GameSettings.enNumberOfFoods.Five))
            {
                SystemSettings.MakeButtonPurple(btnFiveFoodsInGroundChoise);
            }
        }

        private void SetSnakeLengthBtns()
        {
            if (Snake.initialSnakeLength ==2)
            {
                SystemSettings.MakeButtonPurple(btnTwoSnakeLengthChoise);
            }
            else if (Snake.initialSnakeLength == 4)
            {
                SystemSettings.MakeButtonPurple(btnFourSnakeLengthChoise);
            }
            else if (Snake.initialSnakeLength == 6)
            {
                SystemSettings.MakeButtonPurple(btnSixSnakeLengthChoise);
            }
        }

        private void SetUpHMFTCBlockBtns()
        {
            if (GameSettings.NumberToCreateBlock.Equals(GameSettings.enNumberToCreateBlock.Ten))
            {
                SystemSettings.MakeButtonPurple(btn10HMFTCBchoise);
            }
            else if (GameSettings.NumberToCreateBlock.Equals(GameSettings.enNumberToCreateBlock.Twenty))
            {
                SystemSettings.MakeButtonPurple(btn20HMFTCBchoise);
            }
            else if (GameSettings.NumberToCreateBlock.Equals(GameSettings.enNumberToCreateBlock.NoBlocks))
            {
                SystemSettings.MakeButtonPurple(btnNoBlocksHMFTCBchoise);
            }
        }

        private void SetUpGameSpeedBtns()
        {
            if (GameSettings.GameSpeed.Equals(GameSettings.enGameSpeed.Slow))
            {
                SystemSettings.MakeButtonPurple(btnSlowGameSpeedChoise);
            }
            else if (GameSettings.GameSpeed.Equals(GameSettings.enGameSpeed.Mid))
            {
                SystemSettings.MakeButtonPurple(btnMidGameSpeedChoise);
            }
            else if(GameSettings.GameSpeed.Equals(GameSettings.enGameSpeed.Quick))
            {
                SystemSettings.MakeButtonPurple(btnQuickGameSpeedChoise);
            }
        }

        private void SetUpGroundAreaBtns()
        {
            if (GameSettings.GroundArea.Equals(GameSettings.enGroundArea.Small))
            {
                SystemSettings.MakeButtonPurple(btnSmallGroundAreaChoise);
            }
            else if (GameSettings.GroundArea.Equals(GameSettings.enGroundArea.Normal))
            {
                SystemSettings.MakeButtonPurple(btnNormalGroundAreaChoise);
            }
            else if (GameSettings.GroundArea.Equals(GameSettings.enGroundArea.Big))
            {
                SystemSettings.MakeButtonPurple(btnBigGroundAreaChoise);
            }
        }

        private void InitializeToolTip()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            toolTip.SetToolTip(lblGameMode, "Crazy means that you can not cross the wall\n" +
                                            "Normal means that you can cross it.");
            toolTip.SetToolTip(lblGameSpeed, "Snake speed on the ground.");
            toolTip.SetToolTip(lblGroundArea, "Small is 16*16\nNormal is 32*32\nBig is 48*48");
            toolTip.SetToolTip(LblConnected, "Google connect to save your information.");
            toolTip.SetToolTip(lblHMFTCB, "Ex: Every ten Scores , the computer will add another block to the screen. ");
               
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SystemSettings.SoundOfButtonClick.Play();
            SystemSettings.UpdateGameSettingFileContent();
            SnakeTimer.Stop();
            this.Close();
        }

        private void btn_Focus(object sender, EventArgs e)
        {
            SystemSettings.btn_UpdateEffects(SystemSettings.HomeBtnsPicBoxes, true , (Button)sender);
        }

        private void btn_NotFocus(object sender, EventArgs e)
        {
            SystemSettings.btn_UpdateEffects(SystemSettings.HomeBtnsPicBoxes, false, (Button)sender);
        }

        private void picEditProfilePhoto_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.InitialDirectory = @"C:\Users\USER\Pictures\png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Title = "Select an Image";
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picProfileSettingFrm.Image = new Bitmap(openFileDialog.FileName);
                    GameSettings.image = picProfileSettingFrm.Image;
                    SystemSettings.NumberOfImagesInPngsFile++;
                    File.Copy(openFileDialog.FileName, SystemSettings.PlayerImagePath, overwrite:true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image : " + ex.Message);
                }
            }

        }

        private void UpdateGameSpeed(Button B)
        {
            byte n = Convert.ToByte(B.Tag);
            if (n == 1) GameSettings.GameSpeed = GameSettings.enGameSpeed.Slow;
            if (n == 2) GameSettings.GameSpeed = GameSettings.enGameSpeed.Mid;
            if (n == 3) GameSettings.GameSpeed = GameSettings.enGameSpeed.Quick;
        }

        private void UpdateGameMode(Button B)
        {
            byte n = Convert.ToByte(B.Tag);
            if (n == 1) GameSettings.GameMode = GameSettings.enGameMode.Normal;
            if (n == 2) GameSettings.GameMode = GameSettings.enGameMode.Crazy;
        }
        private void UpdateHMFTCB(Button B)
        {
            byte n = Convert.ToByte(B.Tag);
            if (n == 1) GameSettings.NumberToCreateBlock = GameSettings.enNumberToCreateBlock.Ten;
            if (n == 2) GameSettings.NumberToCreateBlock = GameSettings.enNumberToCreateBlock.Twenty;
            if (n == 3) GameSettings.NumberToCreateBlock = GameSettings.enNumberToCreateBlock.NoBlocks;
        }
        private void UpdateSnakeSkin()
        {
            GameSettings.SnakeBodyColor =  new System.Drawing.SolidBrush(picSnakeBodyColor.BackColor);
            GameSettings.SnakeHeadColor = new System.Drawing.SolidBrush(picSnakeHeadColor.BackColor);
            GameSettings.FoodColor = new System.Drawing.SolidBrush(picFoodsColor.BackColor);
            GameSettings.BlocksColor = new System.Drawing.SolidBrush(picBlocksColor.BackColor);
        }


        private void UpdateGroundArea(Button B)
        {
            byte n = Convert.ToByte(B.Tag);
            if (n == 1) GameSettings.GroundArea = GameSettings.enGroundArea.Small;
            if (n == 2) GameSettings.GroundArea = GameSettings.enGroundArea.Normal;
            if (n == 3) GameSettings.GroundArea = GameSettings.enGroundArea.Big;
        }

        private void UpdateFoodsInGround(Button B)
        {
            byte n = Convert.ToByte(B.Tag);
            if (n == 1) GameSettings.NumberOfFoods = GameSettings.enNumberOfFoods.One;
            if (n == 2) GameSettings.NumberOfFoods = GameSettings.enNumberOfFoods.Three;
            if (n == 3) GameSettings.NumberOfFoods = GameSettings.enNumberOfFoods.Five;
        }

        private void UpdateSnakeLength(Button B)
        {
            byte n = Convert.ToByte(B.Tag);
            if (n == 1) Snake.initialSnakeLength = 2;
            if (n == 2) Snake.initialSnakeLength = 4;
            if (n == 3) Snake.initialSnakeLength = 6;
        }


        private void btn_ClickGameSpeed(object sender, EventArgs e)
        {
            UpdateGameSpeed((Button)sender);
            SystemSettings.btn_CheckEffect(btnSlowGameSpeedChoise, 
                                           btnMidGameSpeedChoise ,
                                           btnQuickGameSpeedChoise);
        }

        private void btn_ClickGameMode(object sender, EventArgs e)
        {
            UpdateGameMode((Button)sender);
            SystemSettings.btn_CheckEffect(btnNormalGameModeChoise, 
                                           btnCrazyGameModeChoise);
        }

        private void btn_ClickGroundArea(object sender, EventArgs e)
        {
            UpdateGroundArea((Button)sender);
            SystemSettings.btn_CheckEffect(btnSmallGroundAreaChoise,
                                           btnNormalGroundAreaChoise,
                                           btnBigGroundAreaChoise);
        }

        private void btn_ClickFoodsInGround(object sender, EventArgs e)
        {
            UpdateFoodsInGround((Button)sender);
            SystemSettings.btn_CheckEffect(btnOneFoodsInGroundChoise,
                                           btnThreeFoodsInGroundChoise,
                                           btnFiveFoodsInGroundChoise);
        }

        private void btn_ClickSnakeLength(object sender, EventArgs e)
        {
            UpdateSnakeLength((Button)sender);
            SystemSettings.btn_CheckEffect(btnTwoSnakeLengthChoise,
                                           btnFourSnakeLengthChoise,
                                           btnSixSnakeLengthChoise);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnLogin.Tag) == 0)
            {
                btnLogin.ForeColor = Color.GreenYellow;
                btnLogin.FlatAppearance.BorderColor = Color.GreenYellow;
                btnLogin.Text = "Logout";
                btnLogin.Tag = 1;
            }
            else
            {
                btnLogin.ForeColor = Color.Red;
                btnLogin.FlatAppearance.BorderColor = Color.Red;
                btnLogin.Text = "Login";
                btnLogin.Tag = 0;
            }

        }

        private void picProfileSettingFrm_Click(object sender, EventArgs e)
        {
            picEditProfilePhoto_Click(sender, e);
        }


        private void UpdatePicsColors(Color NewColor , PictureBox p)
        {
            int n = Convert.ToByte(p.Tag);
            if (n == 0) picSnakeBodyColor.BackColor = NewColor;
            else if (n == 1) picSnakeHeadColor.BackColor = NewColor;
            else if (n == 2) picFoodsColor.BackColor = NewColor;
            else if (n == 3) picBlocksColor.BackColor = NewColor;


        }

        private bool IsAvailableColor(Color color)
        {
            String s = SystemSettings.getHexadecimal(new SolidBrush(color));
            if (s.Equals(SystemSettings.getHexadecimal(GameSettings.SnakeHeadColor)))
            {
                MessageBox.Show("This is the current Snake Head Color","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (s.Equals(SystemSettings.getHexadecimal(GameSettings.FoodColor)))
            {
                MessageBox.Show("This is the current Snake Food Color","Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (s.Equals(SystemSettings.getHexadecimal(GameSettings.BlocksColor)))
            {
                MessageBox.Show("This is the current Block Color", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (s.Equals(SystemSettings.getHexadecimal(GameSettings.SnakeBodyColor)))
            {
                MessageBox.Show("This is the current Snake Body Color", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (color.Equals(Food.enFoodsName.BlueFood) || color.Equals(Food.enFoodsName.GreenFood) || color.Equals(Food.enFoodsName.YellowFood))
            {
                MessageBox.Show("This color is not available !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void EditColor(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (IsAvailableColor(colorDialog.Color))
                {
                    UpdatePicsColors(colorDialog.Color, (PictureBox)sender);
                    UpdateSnakeSkin();
                }
            }
        }

        private void btn_ClickHMFTCB(object sender, EventArgs e)
        {
            UpdateHMFTCB((Button)sender);
            SystemSettings.btn_CheckEffect(btn10HMFTCBchoise,
                                           btn20HMFTCBchoise,
                                           btnNoBlocksHMFTCBchoise);
        }

        private void txtPlayerNameSettingFrm_Validating(object sender, CancelEventArgs e)
        {

            
            if (String.IsNullOrWhiteSpace(txtPlayerNameSettingFrm.Text)) 
            {   
                e.Cancel = true;
                txtPlayerNameSettingFrm.Focus();
                error.SetError(txtPlayerNameSettingFrm, "You can not enter empty name ... ");
            }
            else
            {
                e.Cancel = false;
                error.Clear();

            }
        }

        private void txtPlayerNameSettingFrm_TextChanged(object sender, EventArgs e)
        {
            GameSettings.PlayerName = txtPlayerNameSettingFrm.Text;
        }

        public static Snake snake = new Snake();
        public static Food food = new Food();
        public static Block block = new Block();
        private void picSnakeBox_Paint(object sender, PaintEventArgs e)
        {
            int n = 36;
            for (int i = 0; i < snake.Count(); i++)
            {
                if (i == 0) e.Graphics.FillEllipse(GameSettings.SnakeHeadColor, new Rectangle(snake.At(i).x * n, snake.At(i).y * n, n, n));
                else e.Graphics.FillEllipse(GameSettings.SnakeBodyColor, new Rectangle(snake.At(i).x * n, snake.At(i).y * n, n, n));
            }
            e.Graphics.FillEllipse(GameSettings.FoodColor, new Rectangle(food.x * n, food.y * n, n, n));
            e.Graphics.FillRectangle(GameSettings.BlocksColor, new Rectangle(block.x * n, block.y * n, n, n));
        }
        private void Logic()
        {
            for (int i = snake.Count() - 1; i >= 0; i--)
            {
                if (i == 0) snake.UpdateHeadXAndY();
                else snake.UpdateTailXAndY(i);
            }
        }
        private void SnakeTimer_Tick(object sender, EventArgs e)
        {
            Logic();
            picSnakeBox.Invalidate();
        }

    }
}
