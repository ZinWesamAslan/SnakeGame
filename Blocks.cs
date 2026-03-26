using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AslanSnakeGame;
using AslanSnakeGame.Properties;

namespace AslanSnakeGame
{
    public class Blocks
    {
        private List<Block> BlocksList;

        Random random = new Random();

        public Blocks()
        {
            BlocksList = new List<Block>();
        }

        public Circle At(int Index)
        {
            return BlocksList[Index];
        }

        public int Count()
        {
            return BlocksList.Count;
        }

        public void Clear()
        {
            BlocksList.Clear();
        }

        public void Add(Block block)
        {
            BlocksList.Add(block);
        }

        public void RemoveAt(int Index)
        {
            BlocksList.RemoveAt(Index);
        }


        private bool BlockIsNotCreatedOnSnake(Snake snake , Block B)
        {
            for (int i = 0; i < snake.Count(); i++)
                if (B.x == snake.At(i).x && B.y == snake.At(i).y)
                    return false;

            return true;
        }

        private bool BlockIsNotCreatedOnFoods(Foods foods, Block B)
        {
            for (int i = 0; i < foods.Count(); i++)
                if (B.x == foods.At(i).x && B.y == foods.At(i).y)
                    return false;

            return true;
        }

        private bool CheckTheAbilityOfCreateBlock(Snake snake, Foods foods, Block B)
        {
            return BlockIsNotCreatedOnFoods(foods, B) && BlockIsNotCreatedOnSnake(snake, B); 
        }

        private bool CheckTheAbilityOfCreateBlock(Snake snake1,Snake snake2 ,Foods foods, Block B)
        {
            return BlockIsNotCreatedOnFoods(foods, B) && BlockIsNotCreatedOnSnake(snake1, B)
                && BlockIsNotCreatedOnSnake(snake2,B); 
        }

        public void AddOneBlock(Snake snake, Foods foods)
        {
            Block b;
            do
            {
                b = new Block() { x = random.Next(0, GameSettings.GroundMaxWidth), y = random.Next(0, GameSettings.GroundMaxHeight) };
            } while (!CheckTheAbilityOfCreateBlock(snake, foods, b));
            BlocksList.Add(b);
        }

        public void AddOneBlock(Snake snake1,Snake snake2, Foods foods)
        {
            Block b;
            do
            {
                b = new Block() { x = random.Next(0, GameSettings.GroundMaxWidth), y = random.Next(0, GameSettings.GroundMaxHeight) };
            } while (CheckTheAbilityOfCreateBlock(snake1, snake2, foods, b));
            BlocksList.Add(b);
        }
    }
}
