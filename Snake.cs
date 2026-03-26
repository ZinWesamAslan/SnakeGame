using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AslanSnakeGame;
using AslanSnakeGame.Properties;
using static AslanSnakeGame.Snake;

namespace AslanSnakeGame
{
    public class Snake
    {
        private List<Circle> SnakeList;

        public static int ID {  get; set; } = 0;
        public enum enDirection { Left = 1, Right, Up, Down, Stop };
        public enDirection Direction { get; set; }
        public bool GoLeft { get; set; }
        public bool GoRight { get; set; }
        public bool GoUp { get; set; }
        public bool GoDown { get; set; }
        public static int initialSnakeLength { get; set; } = 6;
        public int Score { get; set; }
        public int BestScore { get; set; }
        public bool IsDied { get ; set; }
        public Keys UpKey { get; set; }
        public Keys DownKey { get; set; }
        public Keys LeftKey { get; set; }
        public Keys RightKey { get; set; }
        public bool IsEatGreenFood { get; set; }
        public bool isEatBlueFood { get; set; }

        public void SetSnakeDirectionsKeys()
        {

                UpKey = Keys.Up;
                DownKey = Keys.Down;
                LeftKey = Keys.Left;
                RightKey = Keys.Right;

            /*else if (ID == 1)
            {
                UpKey = Keys.NumPad8;
                DownKey = Keys.NumPad5;
                LeftKey = Keys.NumPad4;
                RightKey = Keys.NumPad6;
            }*/

        }

        public Snake()
        {
            SetUpSnake();
            SetSnakeDirectionsKeys();
            ID++;
        }

        public void UpdateDirection()
        {

                if (GoDown) Direction = enDirection.Down;
                else if (GoUp) Direction = enDirection.Up;
                else if (GoLeft) Direction = enDirection.Left;
                else if (GoRight) Direction = enDirection.Right;

        }

        public void SetUpSnake() 
        {
            SnakeList = new List<Circle>();
            Direction = enDirection.Stop;
            Score = 0;
            IsDied = false;
            IsEatGreenFood = false;
            isEatBlueFood = false;
            GoLeft = GoRight = GoUp = GoDown = false;
            Add(initialSnakeLength);
        }

        public Circle At(int Index)
        {
            return SnakeList[Index];
        }

        public int Count()
        {
            return SnakeList.Count;
        }

        public void Clear()
        {
            SnakeList.Clear();
        }

        public void Add(Circle circle)
        {
            SnakeList.Add(circle);
        }

        public void AddAtEnd()
        {
            SnakeList.Add(new Circle() { x = SnakeList[SnakeList.Count - 1].x, y = SnakeList[SnakeList.Count - 1].y });
        }

        public void AddAtEnd(int Index)
        {
            for (int i = 0; i < Index; i++)
            {
                SnakeList.Add(new Circle() { x = SnakeList[SnakeList.Count - 1].x, y = SnakeList[SnakeList.Count - 1].y });
            }
        }

        public void Add(int numberOfCircle)
        {
            for (int i = 1; i <= numberOfCircle; i++)
            {
                SnakeList.Add(new Circle());
            }
        }

        public void keyIsDown(KeyEventArgs e)
        {
            if (!IsEatGreenFood)
            {
                if (e.KeyCode == LeftKey) GoLeft = (!(Direction == enDirection.Right));
                if (e.KeyCode == RightKey) GoRight = (!(Direction == enDirection.Left));
                if (e.KeyCode == UpKey) GoUp = (!(Direction == enDirection.Down));
                if (e.KeyCode == DownKey) GoDown = (!(Direction == enDirection.Up));
            }
            else
            {
                if (e.KeyCode == LeftKey) GoRight = (!(Direction == enDirection.Left));
                if (e.KeyCode == RightKey) GoLeft = (!(Direction == enDirection.Right));
                if (e.KeyCode == UpKey) GoDown = (!(Direction == enDirection.Up));
                if (e.KeyCode == DownKey) GoUp = (!(Direction == enDirection.Down));
            }
        }

        
        public void keyIsUp(KeyEventArgs e)
        {
            if (!IsEatGreenFood)
            {
                if (e.KeyCode == LeftKey) GoLeft = false;
                if (e.KeyCode == RightKey) GoRight = false;
                if (e.KeyCode == UpKey) GoUp = false;
                if (e.KeyCode == DownKey) GoDown = false;
            }
            else
            {
                GoRight = false;
                GoLeft = false;
                GoDown = false;
                GoUp  = false;
            }
        }


        public void UpdateHeadXAndY()
        {
            switch (Direction)
            {
                case enDirection.Down:
                    At(0).y++;
                    break;
                case enDirection.Up:
                    At(0).y--;
                    break;
                case enDirection.Right:
                    At(0).x++;
                    break;
                case enDirection.Left:
                    At(0).x--;
                    break;
            }

            if (GameSettings.GameMode == GameSettings.enGameMode.Crazy)
            {
                if (At(0).x >= GameSettings.GroundMaxWidth) At(0).x = 0;
                if (At(0).x < 0) At(0).x = GameSettings.GroundMaxWidth - 1;
                if (At(0).y >= GameSettings.GroundMaxHeight) At(0).y = 0;
                if (At(0).y < 0) At(0).y = GameSettings.GroundMaxHeight - 1;
            }
        }

        private bool SnakeHitThaWall()
        {
            if (At(0).x >= GameSettings.GroundMaxWidth || At(0).x < 0 ||
            At(0).y >= GameSettings.GroundMaxHeight || At(0).y < 0)
            {
                IsDied = true;
                return true;
            }
            return false;
        }

        private bool SnakeHitHerBody()
        {
            for (int j = 1; j < Count(); j++)
                if (At(0).y == At(j).y && At(0).x == At(j).x)
                {
                    IsDied = true;
                    return true;
                }
            return false;
        }

        private bool SnakeHitABlock(Blocks blocks)
        {
            if (Score >= Convert.ToInt16(GameSettings.NumberToCreateBlock))
            {
                for (int l = 0; l < blocks.Count(); l++)
                {
                    if (At(0).y == blocks.At(l).y && At(0).x == blocks.At(l).x)
                    {
                        IsDied = true;
                        return true;
                    }
                }
            }
            return false;
        }

        private bool SnakeHitAnotherSnake( Snake AnotherSnake)
        {
            for (int i = 0; i < AnotherSnake.Count(); i++)
            {
                if (At(0).y == AnotherSnake.At(i).y && At(0).x == AnotherSnake.At(i).x)
                {
                    if (i == 0)
                    {
                        AnotherSnake.IsDied = true;
                    }
                    IsDied = true;
                    return true;
                }
            }
            return false;
        }

        public bool SnakeIsDied(Blocks blocks )
        {
            if (GameSettings.GameMode == GameSettings.enGameMode.Normal)if(SnakeHitThaWall())return true;
            if (!Direction.Equals(enDirection.Stop)) if (SnakeHitHerBody()) return true;
            //if (Score != initialSnakeLength)if (SnakeHitHerBody())return true;
            if (!GameSettings.NumberToCreateBlock.Equals(GameSettings.enNumberToCreateBlock.NoBlocks)) if (SnakeHitABlock(blocks)) return true;
            return false;
        }

        public bool SnakeIsDied(Blocks blocks , Snake AnotherSnake)
        {
            //if (GameSettings.GameMode == GameSettings.enGameMode.Normal) if (SnakeHitThaWall()) return true;
            //if (Score != 0) if (SnakeHitHerBody()) return true;
            //if (!Direction.Equals(enDirection.Stop)) if (SnakeHitHerBody()) return true;
            //if (!GameSettings.NumberToCreateBlock.Equals(GameSettings.enNumberToCreateBlock.NoBlocks)) if (SnakeHitABlock(blocks)) return true;
            if (SnakeIsDied(blocks)) return true;
            if (Direction != enDirection.Stop && AnotherSnake.Direction != enDirection.Stop)if (SnakeHitAnotherSnake(AnotherSnake)) return true;

            return false;
        }

        public int GetEatenFoodInex(Foods foods)
        {
            
            for (int i = 0; i < foods.Count(); i++)
            {
                if (At(0).y == foods.At(i).y && At(0).x == foods.At(i).x)
                {
                    return i;
                }
            }
            return -1;
        }

        public void UpdateTailXAndY(int index)
        {
            At(index).x = At(index - 1).x;
            At(index).y = At(index - 1).y;
        }

    }
}
