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
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using AslanSnakeGame.Properties;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace AslanSnakeGame
{
    public class SystemSettings
    {
        // delete initialize and add it to constructor .
        public static String PlayerScoreFilePath = @"C:\Users\USER\Documents\ToDelete\AslanSnakeGame\GameScore.txt";
        public static String GameSettingFilePath = @"C:\Users\USER\Documents\ToDelete\AslanSnakeGame\GameSettingFile.txt";
        public static int NumberOfImagesInPngsFile ;
        public static String PlayersImagesFilePath = @"C:\Users\USER\Documents\ToDelete\AslanSnakeGame\Pngs";
        public static String[] GroundImagesPath = new String[4]
            {   @"C:\Users\USER\Documents\ToDelete\AslanSnakeGame\GroundImages\1.Png",
                @"C:\Users\USER\Documents\ToDelete\AslanSnakeGame\GroundImages\2.Png",
                @"C:\Users\USER\Documents\ToDelete\AslanSnakeGame\GroundImages\3.Png",
                @"C:\Users\USER\Documents\ToDelete\AslanSnakeGame\GroundImages\4.Png"
            };
            
        public static string PlayerImagePath {get; set;} = @"C:\Users\USER\Documents\ToDelete\AslanSnakeGame\PlayerImage\x.png";
        public static DateTime GameDate {get; set;}
        public static PictureBox[] HomeBtnsPicBoxes = new PictureBox[6];
        public static PictureBox[] frmAreYouSureBtnsPicBoxes = new PictureBox[3];
        public static SoundPlayer SoundOfButtonFocus;
        public static SoundPlayer SoundOfButtonClick;
        private static Color FocusedButtonsForeColor { get; set; }
        private static Color ButtonsForeColor { get; set;}


        public static Boolean IsLogin {get; set;}

        public static int NumberTen { get; set; } = 10;

        public static int NumberTwenty { get; set; } = 20;

        static SystemSettings()
        {
            FocusedButtonsForeColor = Color.DarkBlue;
            ButtonsForeColor = Color.Black;
            IsLogin = false;
            NumberOfImagesInPngsFile = GameSettingRecordContainer.NumberOfImagesInPngsFile;
            SoundOfButtonFocus = new SoundPlayer("sound1.wav");
            SoundOfButtonClick = new SoundPlayer("sound2.wav");
            
        }

        private static Color GetButtonsForeColor(bool isFocus)
        {
            return (isFocus) ? FocusedButtonsForeColor : ButtonsForeColor;
        }
        private static Font GetHomeButtonsFont(bool isFocus, Button B)
        {
            short AddNumberToSize = (isFocus) ? (short)2 : (short)-2; ;
            return new Font("Snap ITC", B.Font.Size + AddNumberToSize, FontStyle.Bold);
        }

        private static void btn_UpdatePicButtons(PictureBox[] PicBoxes,bool isVisible, Button B)
        {
            short tag = Convert.ToByte(B.Tag);
            for(int i = 1; i<=PicBoxes.Count();i++)
            {
                if(tag == i) PicBoxes[i-1].Visible = isVisible;
            }
        }
        public static void btn_UpdateEffects(PictureBox[] PicBoxes,bool isFocus, Button B)
        {
            if (isFocus)
            {
                SoundOfButtonFocus.Play();
                B.Focus();
            }
            B.ForeColor = GetButtonsForeColor(isFocus);
            B.Font = GetHomeButtonsFont(isFocus, B);
            btn_UpdatePicButtons(PicBoxes,isFocus, B);
        }

        public static void btn_UpdateEffects( bool isFocus, Button B)
        {
            if (isFocus)
            {
                SoundOfButtonFocus.Play();
                B.Focus();
            }
            B.ForeColor = GetButtonsForeColor(isFocus);
            B.Font = GetHomeButtonsFont(isFocus, B);
        }

        public static void btn_CheckEffect(params Button[] B)
        {
            foreach (Button b in B)
            {
                if (b.Focused)
                {
                    b.ForeColor = Color.Purple;
                    b.FlatAppearance.BorderColor = Color.Purple;
                    SoundOfButtonClick.Play();
                }
                else
                {
                    b.ForeColor = Color.Black;
                    b.FlatAppearance.BorderColor = Color.Black;
                }
            }
        }

        public static void DrawCircle(Circle circle, Brush Color, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Color, new Rectangle(
            circle.x * GameSettings.CircleWidth,
            circle.y * GameSettings.CircleHeight,
            GameSettings.CircleWidth,
            GameSettings.CircleHeight));
        }

        public static void DrawSquare(Circle circle, Brush Color, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Color, new Rectangle(
            circle.x * GameSettings.CircleWidth,
            circle.y * GameSettings.CircleHeight,
            GameSettings.CircleWidth,
            GameSettings.CircleHeight));
        }

        public static void UpdateSnakeColor(Snake snake, PaintEventArgs e)
        {
            for (int i = 0; i < snake.Count(); i++)
            {
                if (i == 0) DrawCircle(snake.At(i), GameSettings.SnakeHeadColor, e);
                else DrawCircle(snake.At(i), GameSettings.SnakeBodyColor, e);

            }
        }

        public static void UpdateSnakeColor(Snake snake, Brush B1, Brush B2, PaintEventArgs e)
        {
            for (int i = 0; i < snake.Count(); i++)
            {
                if (i == 0) DrawCircle(snake.At(i), B1, e);
                else DrawCircle(snake.At(i), B2, e);

            }
            if(snake.IsDied)
            {
                DrawCircle(snake.At(1), B1, e);
            }
        }


        public static void UpdateFoodsColor(Foods foods, PaintEventArgs e)
        {
            if (foods.Count() != 0)
                for (int i = 0; i < foods.Count(); i++)
                    DrawCircle(foods.At(i), foods.At(i).FoodColor, e);
        }

        public static void UpdateBlocksColor(Blocks blocks, PaintEventArgs e)
        {
            for (int i = 0; i < blocks.Count(); i++)
                DrawSquare(blocks.At(i), GameSettings.BlocksColor, e);
        }

        public static void EditSnakeColor(Snake snake, PaintEventArgs e)
        {
            if (GameSettings.GameIsOver && snake.IsDied)
            {
                UpdateSnakeColor(snake, Brushes.Black, Brushes.Indigo, e);
                return;
            }
            else
            {
                UpdateSnakeColor(snake, e);
            }
        }


        public static String[] GetScoreRecords()
        {
            return File.ReadAllLines(PlayerScoreFilePath);
        }

        public static String CreateScoreRecord(ScoreRecordContainer record)
        {
            return record.Name + "," +
                   record.Score + "," +
                   Convert.ToString(record.Speed) + "," +
                   Convert.ToString(record.Mode) + "," +
                   Convert.ToString(record.Size) + "," +
                   Convert.ToString(record.Time) + "," +
                   record.Date + "," + 
                   record.ImagePath + Environment.NewLine;
        }

        public static List<ScoreRecordContainer> GetScoreRecordContainer()
        {
            List<ScoreRecordContainer> RContainers = new List<ScoreRecordContainer>();

            String[] Lines = GetScoreRecords();
            for (int i = 0; i < Lines.Count(); i++)
            {
                RContainers.Add(new ScoreRecordContainer());
                String[] words = Lines[i].Split(',');
                RContainers[i].Name = words[0];
                RContainers[i].Score = Convert.ToInt32(words[1]);
                RContainers[i].Speed = words[2];
                RContainers[i].Mode = words[3];
                RContainers[i].Size = words[4];
                RContainers[i].Time = words[5];
                RContainers[i].Date = words[6];
                RContainers[i].ImagePath = words[7];
            }
            return RContainers;
        }
        public static String CreateGameScoreRecord(String PlayerImagePath, Label lblPlayerName, int Score)
        {
            //TimeSpan difference = DateTime.Now - GameDate;
            return lblPlayerName.Text + "," +
                   Score + "," +
                   Convert.ToString(GameSettings.GameSpeed) + "," +
                   Convert.ToString(GameSettings.GameMode) + "," +
                   Convert.ToString(GameSettings.GroundArea) + "," +
                   Convert.ToString(GameSettings.MatchTime) + "," +
                   GameDate + "," + 
                   PlayerImagePath + "," +
                   Environment.NewLine;
        }
        public static void WriteTheRecordOnTheFile(String PlayerImagePath ,Label lblPlayerName, int Score)
        {
            File.AppendAllText(PlayerScoreFilePath, CreateGameScoreRecord(PlayerImagePath ,lblPlayerName, Score));
            List<ScoreRecordContainer> records = new List<ScoreRecordContainer>();
            records = GetScoreRecordContainer();
            records.Sort();
            String s = "";
            foreach (ScoreRecordContainer record in records)
            {
                s += CreateScoreRecord(record);
            }
            File.WriteAllText(PlayerScoreFilePath, s);
        }

        public static String getHexadecimal(Brush B)
        {
            SolidBrush SB = (B as SolidBrush) ?? new SolidBrush(Color.White);
            return SB.Color.R.ToString("X2") + SB.Color.G.ToString("X2") + SB.Color.B.ToString("X2");
        }

        public static String CreateGameSettingRecord()
        {
            return GameSettings.PlayerName + "," +
                   GameSettings.GameSpeed + "," + GameSettings.GameMode + "," +
                   GameSettings.GroundArea + ",#" + getHexadecimal(GameSettings.SnakeHeadColor) + ",#" +
                   getHexadecimal(GameSettings.SnakeBodyColor) + ",#" + getHexadecimal(GameSettings.FoodColor) + ",#" +
                   getHexadecimal(GameSettings.BlocksColor) + "," + GameSettings.NumberToCreateBlock
                   + "," + NumberOfImagesInPngsFile + "," + GameSettings.NumberOfFoods +","+
                   Snake.initialSnakeLength+"," + GameSettings.TotalEatenFoods + "," +
                   GameSettings.TotalTimeSpentOnGame + "," + GameSettings.BestScoreEver + "," +
                   GameSettings.TotalMatches+","+GameSettings.TotalCoins+ "," +
                   GameSettings.ClaimedAwards + "," + GameSettings.MyItems + ",#" +
                   getHexadecimal(new SolidBrush(GameSettings.GroundColor))+ "," +
                   GameSettings.GroundImageIndex;
        }

        public static void UpdateGameSettingFileContent()
        {
            string s = CreateGameSettingRecord();
            File.WriteAllText(GameSettingFilePath,s);
        }

        public static void MakeButtonPurple(Button B)
        {
            B.ForeColor = Color.Purple;
            B.FlatAppearance.BorderColor = Color.Purple;
        }

        public static void UpdatePngsFile()
        {
            string to = PlayersImagesFilePath + "\\" + NumberOfImagesInPngsFile + ".png";
            GameSettings.PlayerImagePath = to;
            File.Copy(PlayerImagePath, to, overwrite: true);
        }
        public static int IncreaseSpeedBy()
        {
            int speed = 0;
            if(GameSettings.GameSpeed.Equals(GameSettings.enGameSpeed.Slow))
            {
                speed = 50;
            }
            else if(GameSettings.GameSpeed.Equals(GameSettings.enGameSpeed.Mid))
            {
                speed = 30;
            }
            else if(GameSettings.GameSpeed.Equals(GameSettings.enGameSpeed.Quick))
            {
                speed = 20;
                if(GameSettings.GroundArea.Equals(GameSettings.enGroundArea.Big))
                {
                    speed = 5;
                }
            }
            return  speed;
        }

    }
}
