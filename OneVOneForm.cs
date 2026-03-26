using SnakeGameC_;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SnakeGameCsharp
{
    public partial class OneVOneForm : Form
    {

        Foods foods = new Foods() ;
        Snake snake1 = new Snake();
        Snake snake2 = new Snake();
        Blocks blocks = new Blocks() ;

        private void clearAll()
        {
            snake1.clear();
            snake2.clear();
            foods.clear();
            blocks.clear();
        }

        private void FixbuttonsStatus()
        {
            
            if (Settings.gameIsOver)
            {
                btnStart.Enabled = true;
                btnSnap.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
                btnSnap.Enabled = false;
            }
        }

        private void setUpLables()
        {
            lblBestScore1.ForeColor = Color.White;
            lblScore1.ForeColor = Color.White;
            lblScore1.Text = "Score 1 : " + snake1.score;
            lblBestScore2.ForeColor = Color.White;
            lblScore2.ForeColor = Color.White;
            lblScore2.Text = "Score 2 : " + snake2.score;
        }

        private void btnStartClick(object sender, EventArgs e)
        {
            reStartGame();
        }

        private void setUp()
        {
            Settings.maxHeight = pbTable.Height / Settings.circleHeight;
            Settings.maxWidth = pbTable.Width   / Settings.circleWidth;
            Settings.NumberOfFoodsInTheGame = 3;
            Settings.ScoreToCreateBlocks = 20;
            Settings.gameIsOver = false;
            Snake.NumberOfCircleInSnakeInTheBiginning = 5;
            
            clearAll();

            snake1.setUpSnake();
            snake2.setUpSnake();
            setUpLables();
            
            foods.add(Settings.NumberOfFoodsInTheGame, snake1,snake2, blocks);
        }

        public OneVOneForm()
        {
            InitializeComponent();
            new Settings();
        }

        private void reStartGame()
        {
            setUp();
            FixbuttonsStatus();
            GameTimer.Start();
        }

        private Label createCaption()
        {
            Label Caption = new Label();
            Caption.Text = DateTime.Now.ToString() + Environment.NewLine +"   Score1 : " + snake1.score + "   BestScore1 : " + snake1.bestScore
                            + "   Score2 : " + snake2.score + "   BestScore2 : " + snake2.bestScore;
            Caption.Font = new Font("Ariel", 14, FontStyle.Bold);
            Caption.ForeColor = Color.Black;
            Caption.AutoSize = false;
            Caption.Width = pbTable.Width;
            Caption.Height = 60;
            Caption.TextAlign = ContentAlignment.MiddleCenter;
            return Caption;
        }

        private SaveFileDialog createSaveFileDialog()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.DefaultExt = "jpg";
            dialog.FileName = "Aslan Snake Game";
            dialog.ValidateNames = true;
            return dialog;
        }

        private void btnSnapClick(object sender, EventArgs e)
        {
            Label Caption = createCaption();

            pbTable.Controls.Add( Caption );

            SaveFileDialog dialog = createSaveFileDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pbTable.Width);
                int height = Convert.ToInt32(pbTable.Height);

                Bitmap bitmap = new Bitmap(width, height);
                pbTable.DrawToBitmap(bitmap , new Rectangle(0,0, width, height));
                bitmap.Save(dialog.FileName , ImageFormat.Jpeg);
                pbTable.Controls.Remove(Caption);
            }
            else 
            {
                pbTable.Controls.Remove(Caption);
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)this.Close();
            

            snake1.keyIsDown(Keys.Left , Keys.Right , Keys.Up , Keys.Down ,e);
            snake2.keyIsDown(Keys.NumPad4, Keys.NumPad6, Keys.NumPad8, Keys.NumPad5, e);
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            snake1.keyIsUp(Keys.Left, Keys.Right, Keys.Up, Keys.Down ,e);
            snake2.keyIsUp(Keys.NumPad4, Keys.NumPad6, Keys.NumPad8, Keys.NumPad5, e);
        }
        
        private bool Logic(Snake snake1 , Snake snake2)
        {
            snake1.UpdateDirection();
            for (int i = snake1.count() - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    snake1.UpdateHeadXAndYvalue();
                    if (snake1.SnakeIsDied(blocks, snake2))
                    {
                        gameOver();
                        return true;
                    }

                    eatFood(snake1.SnakeIsEatFood(foods), snake1);
                }
                else
                {
                    snake1.UpdateTailXAndYvalue(i);
                }
                
            }
            return false;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if(!Logic(snake1, snake2)) Logic(snake2, snake1);
            pbTable.Invalidate();
        }

        private void UpdateSnakeColor(Snake snake,Brush HeadColor, Brush Body1color, Brush Body2color, Brush Body3color, Brush Body4color,  PaintEventArgs e)
        {

            int Quarter1 = Convert.ToInt32(snake.count()*0.25);
            int Quarter2 = Convert.ToInt32(snake.count() * 0.5);
            int Quarter3 = Convert.ToInt32(snake.count() * 0.75);

            
            for (int i = 0; i < snake.count(); i++)
            {
                if (i == 0) drawCircle(snake.at(i), HeadColor, e);

                else if(i >0 && i <= Quarter1) drawCircle(snake.at(i), Body1color, e);
                
                else if (Quarter1 < i && i <= Quarter2) drawCircle(snake.at(i), Body2color, e);
 
                else if (Quarter2 < i && i <= Quarter3) drawCircle(snake.at(i), Body3color, e);
                
                else if (Quarter3 < i && i <= snake1.count()) drawCircle(snake.at(i), Body4color, e);
            }

        }

        private void UpdateSnakeColor(Snake snake, Brush HeadColor , Brush BodyColor , PaintEventArgs e)
        {

            UpdateSnakeColor(snake,HeadColor,  BodyColor,  BodyColor, BodyColor, BodyColor,  e);
            
        }

        private void drawCircle(Circle circle,Brush Color, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Color, new Rectangle(
            circle.x * Settings.circleWidth,
            circle.y * Settings.circleHeight,
            Settings.circleWidth,
            Settings.circleHeight));
        }

        private void drawSquare(Circle circle, Brush Color, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Color, new Rectangle(
            circle.x * Settings.circleWidth,
            circle.y * Settings.circleHeight,
            Settings.circleWidth,
            Settings.circleHeight));
        }

        private void UpdateFoodsColor(PaintEventArgs e)
        {
            if (foods.count() != 0)
            {
                for (int k = 0; k < foods.count(); k++)
                {
                    drawCircle(foods.at(k), Brushes.Red, e);
                }
            }
        }

        private void UpdateBlocksColor(PaintEventArgs e)
        {
            for (int i = 0; i < blocks.count(); i++)
            {
                drawSquare(blocks.at(i), Brushes.Black, e);
            }
        }

        private void UpdateSnaksColor(PaintEventArgs e)
        {
            if (Settings.gameIsOver)
            {
                if (snake1.IsDied && snake2.IsDied)
                {
                    UpdateSnakeColor(snake1, Brushes.Black, Brushes.Indigo, e);
                    UpdateSnakeColor(snake2, Brushes.Black, Brushes.Indigo, e);
                }
                else if(snake2.IsDied)
                {
                    UpdateSnakeColor(snake2, Brushes.Green, Brushes.Indigo, e);
                    UpdateSnakeColor(snake1, Brushes.DarkGreen, Brushes.Green, e);
                }
                else
                {
                    UpdateSnakeColor(snake1, Brushes.Blue, Brushes.Indigo, e);
                    UpdateSnakeColor(snake2, Brushes.DarkBlue, Brushes.Blue, e);
                }
                return;
            }
            UpdateSnakeColor(snake1, Brushes.DarkGreen, Brushes.Green, e);
            UpdateSnakeColor(snake2, Brushes.DarkBlue, Brushes.Blue, e);
        }

        private void pbTableGraphicsUpdate(object sender, PaintEventArgs e)
        {
            UpdateBlocksColor(e);
            UpdateFoodsColor(e);
            UpdateSnaksColor(e);
        }

        private void UpdateScoreLables()
        {

            lblScore1.Text = "Score1 : " + snake1.score;

            lblScore2.Text = "Score2 : " + snake2.score;

        }

        private void eatFood(int Index ,Snake snake)
        {
            if (Index != -1)
            {
                snake.score++;
                UpdateScoreLables();

                snake.addAtEnd();

                foods.removeAt(Index);

                if (snake.score % Settings.ScoreToCreateBlocks == 0)
                {
                    blocks.addOneblock(snake1,snake2 ,foods);
                }

                foods.add(1,snake1,snake2 , blocks);
            }

        }

        private void gameOver()
        {

            Settings.gameIsOver = true;
            FixbuttonsStatus();
            if (snake1.score > snake1.bestScore)
            {
                snake1.bestScore = snake1.score;
                lblBestScore1.Text = "Best 1 : " + snake1.score;
            }

            if (snake2.score > snake2.bestScore)
            {
                snake2.bestScore = snake2.score;
                lblBestScore2.Text = "Best 2 : " + snake2.score;
            }

            lblBestScore1.ForeColor = Color.Red;
            lblScore1.ForeColor = Color.Blue;
            lblBestScore2.ForeColor = Color.Red;
            lblScore2.ForeColor = Color.Blue;

            

            

            GameTimer.Stop();
        }

 
        

    }
}
