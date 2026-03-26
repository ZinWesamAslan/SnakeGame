using System;
using System.Collections.Generic;
using System.Drawing;

using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

    public class GameSettingRecordContainer
    {
        static public string PlayerName;
        static public GameSettings.enGameSpeed GameSpeed;
        static public GameSettings.enGameMode GameMode;
        static public GameSettings.enGroundArea GroundArea;
        static public Brush SnakeHeadColor, SnakeBodyColor, FoodColor, BlockColor;
        static public GameSettings.enNumberToCreateBlock numberToCreateBlock;
        static public int NumberOfImagesInPngsFile;
        static public GameSettings.enNumberOfFoods NumberOfFoods;
        static public int initialSnakeLength;
        static public int TotalEatenFoods;
        static public int TotalTimeSpentOnGame;
        static public int BestScoreEver;
        static public int TotalMatches;
        static public int TotalCoins;
        public static int ClaimedAwards;
        public static int MyItems;
        public static int GroundImageIndex;
        public static Color GroundColor { get; set; }

        static public String GetGameSettingsRecord()
        {
            String s = File.ReadAllText(SystemSettings.GameSettingFilePath);
            return s;
        }

        static GameSettingRecordContainer()
        {
            String Lines = GetGameSettingsRecord();
            String[] words = Lines.Split(',');
            PlayerName = words[0];
            GameSpeed = (GameSettings.enGameSpeed)Enum.Parse(typeof(GameSettings.enGameSpeed), words[1]);
            GameMode = (GameSettings.enGameMode)Enum.Parse(typeof(GameSettings.enGameMode), words[2]);
            GroundArea = (GameSettings.enGroundArea)Enum.Parse(typeof(GameSettings.enGroundArea), words[3]);
            SnakeHeadColor = Brushes.Black;
            SnakeBodyColor = Brushes.Green;
            FoodColor = Brushes.Red;
            BlockColor = Brushes.Black;
            SnakeHeadColor = new SolidBrush(ColorTranslator.FromHtml(words[4]));
            SnakeBodyColor = new SolidBrush(ColorTranslator.FromHtml(words[5]));
            FoodColor = new SolidBrush(ColorTranslator.FromHtml(words[6]));
            BlockColor = new SolidBrush(ColorTranslator.FromHtml(words[7]));
            numberToCreateBlock = (GameSettings.enNumberToCreateBlock)Enum.Parse(typeof(GameSettings.enNumberToCreateBlock), words[8]);
            NumberOfImagesInPngsFile = Convert.ToInt16(words[9]);
            NumberOfFoods = (GameSettings.enNumberOfFoods)Enum.Parse(typeof(GameSettings.enNumberOfFoods), words[10]);
            initialSnakeLength = Convert.ToInt32(words[11]);
            TotalEatenFoods = Convert.ToInt32(words[12]);
            TotalTimeSpentOnGame = Convert.ToInt32(words[13]);
            BestScoreEver = Convert.ToInt32(words[14]);
            TotalMatches = Convert.ToInt32(words[15]);
            TotalCoins = Convert.ToInt32(words[16]);
            ClaimedAwards = Convert.ToInt32(words[17]);
            MyItems= Convert.ToInt32(words[18]);
            GroundColor = ColorTranslator.FromHtml(words[19]);
            GroundImageIndex = Convert.ToInt32(words[20]);
        }

    }
}
