using AslanSnakeGame;
using AslanSnakeGame.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AslanSnakeGame
{
    public class Foods
    {
        private List<Food> FoodsList;
        
        Random random = new Random();

        public Foods()
        {
            FoodsList = new List<Food>();
        }

        public Food At(int Index)
        {
            return FoodsList[Index];
        }

        public int Count()
        {
            return FoodsList.Count;
        }

        public void Clear()
        {
            FoodsList.Clear();
        }

        public void Add(Food food)
        {
            FoodsList.Add(food);
        }

        public void RemoveAt(int Index)
        {
            FoodsList.RemoveAt(Index);
        }


        private bool FoodIsNotCreatedOnSnake(Snake snake, Food F)
        {
            for (int i = 0; i < snake.Count(); i++)
                if (F.x == snake.At(i).x && F.y == snake.At(i).y)
                    return false;

            return true;
        }

        private bool FoodIsNotCreatedOnBlocks(Blocks blocks, Food F)
        {
            for (int i = 0; i < blocks.Count(); i++)
                if (F.x == blocks.At(i).x && F.y == blocks.At(i).y)
                    return false;

            return true;
        }

        private bool CheckTheAbilityOfCreateFood(Snake snake, Blocks blocks ,Food F)
        {
            return FoodIsNotCreatedOnBlocks(blocks, F) && FoodIsNotCreatedOnSnake(snake,F);
        }

        private bool CheckTheAbilityOfCreateFood(Snake snake1,Snake snake2 , Blocks blocks, Food F)
        {
            return FoodIsNotCreatedOnBlocks(blocks, F) && FoodIsNotCreatedOnSnake(snake1, F) 
                && FoodIsNotCreatedOnSnake(snake2, F);
        }

        private Food CreateFoodToAdd(int Score)
        {
            if(Score == 0)            return new Food() { x = random.Next(0, GameSettings.GroundMaxWidth), y = random.Next(0, GameSettings.GroundMaxHeight) };
            else if (Score % 20 == 0) return new Food(Food.enFoodsName.BlueFood) { x = random.Next(0, GameSettings.GroundMaxWidth), y = random.Next(0, GameSettings.GroundMaxHeight) };
            else if (Score % 10 == 0) return new Food(Food.enFoodsName.YellowFood) { x = random.Next(0, GameSettings.GroundMaxWidth), y = random.Next(0, GameSettings.GroundMaxHeight) };
            else if (Score % 15 == 0) return new Food(Food.enFoodsName.GreenFood) { x = random.Next(0, GameSettings.GroundMaxWidth), y = random.Next(0, GameSettings.GroundMaxHeight) };
            else                      return new Food() { x = random.Next(0, GameSettings.GroundMaxWidth), y = random.Next(0, GameSettings.GroundMaxHeight) };
            
            
        }

        public void AddOneFood(Snake snake, Blocks blocks)
        {

            Food f;
            do
            {
                f = CreateFoodToAdd(snake.Score);

            } while (!CheckTheAbilityOfCreateFood(snake,blocks,f));
            FoodsList.Add(f);
        }

        public void AddOneFood(Snake snake1,Snake snake2, Blocks blocks)
        {

            Food f;
            do
            {
                f = new Food() { x = random.Next(0, GameSettings.GroundMaxWidth), y = random.Next(0, GameSettings.GroundMaxHeight) };
            } while (CheckTheAbilityOfCreateFood(snake1, snake2, blocks, f));
            FoodsList.Add(f);
        }

        public void AddFoods(Snake snake, Blocks blocks)
        {
            for (int i = 1; i <= Convert.ToByte(GameSettings.NumberOfFoods); i++)
            {
                AddOneFood(snake , blocks);
            }
        }

        public void AddFoods(Snake snake1 , Snake snake2 , Blocks blocks)
        {
            for (int i = 1; i <= Convert.ToByte(GameSettings.NumberOfFoods); i++)
            {
                AddOneFood(snake1 , snake2, blocks);
            }
        }
    }
}
