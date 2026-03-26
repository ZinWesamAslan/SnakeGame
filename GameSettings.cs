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

namespace AslanSnakeGame
{
    public class GameSettings
    {
        public enum enGameMode            { Normal     , Crazy                   }
        public enum enGroundArea          { Small      , Normal       , Big      }
        public enum enGameSpeed           { Quick = 50 , Mid = 100 , Slow = 200}
        public enum enNumberOfFoods       { One =1    , Three = 3    , Five = 5 }
        public enum enNumberToCreateBlock { Ten = 10,Twenty = 20, NoBlocks = 1000}

        public static enNumberToCreateBlock NumberToCreateBlock { get; set; }
        public static enGameMode GameMode           {get; set;}
        public static enGroundArea GroundArea       {get; set;}
        public static int CircleWidth               {get; set;}
        public static int CircleHeight              {get; set;}
        public static enGameSpeed GameSpeed         {get; set;}
        public static enNumberOfFoods NumberOfFoods {get; set;}
        public static Brush SnakeBodyColor          {get; set;}
        public static Brush SnakeHeadColor          {get; set;}
        public static Brush FoodColor               {get; set;}
        public static Brush BlocksColor             {get; set;}
        public static bool GameIsOver { get; set; }
        public static Image image { get; set; } 
        public static string PlayerName { get; set; }
        public static int GroundMaxWidth { get; set; } 
        public static int GroundMaxHeight { get; set; }
        public static string PlayerImagePath {  get; set; }
        public static int MatchTime { get; set; }
        public static int TotalEatenFoods {get; set;}
        public static int TotalTimeSpentOnGame {get; set;}
        public static int BestScoreEver {get; set;}
        public static int TotalMatches {get; set;}
        public static int TotalCoins { get; set;}
        public static int ClaimedAwards {get; set;}
        public static int MyItems {get; set;}
        public static Color GroundColor {get; set;}
        public static Image GroundImage {get; set;}
        public static int GroundImageIndex {get; set;}
        static GameSettings()
        {
            TotalEatenFoods = GameSettingRecordContainer.TotalEatenFoods;
            TotalTimeSpentOnGame = GameSettingRecordContainer.TotalTimeSpentOnGame;
            BestScoreEver = GameSettingRecordContainer.BestScoreEver;
            TotalMatches = GameSettingRecordContainer.TotalMatches;
            TotalCoins = GameSettingRecordContainer.TotalCoins;
            GroundImageIndex = GameSettingRecordContainer.GroundImageIndex;
            GameMode = GameSettingRecordContainer.GameMode;
            GroundColor = GameSettingRecordContainer.GroundColor;
            ClaimedAwards = GameSettingRecordContainer.ClaimedAwards;
            MyItems = GameSettingRecordContainer.MyItems;
            GroundArea = GameSettingRecordContainer.GroundArea;
            GameSpeed = GameSettingRecordContainer.GameSpeed;
            SetCircleHeightAndWidth();
            SnakeBodyColor = GameSettingRecordContainer.SnakeBodyColor;
            SnakeHeadColor = GameSettingRecordContainer.SnakeHeadColor;
            FoodColor = GameSettingRecordContainer.FoodColor;
            BlocksColor = GameSettingRecordContainer.BlockColor;
            NumberOfFoods = GameSettingRecordContainer.NumberOfFoods;
            NumberToCreateBlock = GameSettingRecordContainer.numberToCreateBlock;
            GameIsOver = true;
            SetGroundMaxMinHeightLength();

            Snake.initialSnakeLength = GameSettingRecordContainer.initialSnakeLength;
            image = LoadImageSafely(SystemSettings.PlayerImagePath);


            PlayerName = GameSettingRecordContainer.PlayerName;
             
        }

        public static Image LoadImageSafely(string Path)
        {
            try
            {
                using (Image image = Image.FromFile(Path))
                {
                    Bitmap copy = new Bitmap(image);
                    return copy;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static void SetGroundMaxMinHeightLength()
        {
            GroundMaxHeight = 700 / CircleHeight;
            GroundMaxWidth = 1300 / CircleWidth;
        }
        public static void SetCircleHeightAndWidth()
        {
            if (GroundArea.Equals(enGroundArea.Small))
            {
                CircleHeight = 50;
                CircleWidth = 50;
            }
            if (GroundArea.Equals(enGroundArea.Normal))
            {
                CircleHeight = 25;
                CircleWidth = 25;
            }
            if (GroundArea.Equals(enGroundArea.Big))
            {
                CircleHeight = 10;
                CircleWidth = 10;
            }
        }
    }
}