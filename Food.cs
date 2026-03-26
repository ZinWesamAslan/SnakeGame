using AslanSnakeGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AslanSnakeGame
{
    public class Food : Circle
    {  
        public enum enFoodsName {RedFood = 0 , GreenFood = 1 , BlueFood = 2 , YellowFood = 3 }
        public enFoodsName FoodName  { get; set; }
        public Brush FoodColor { get; set; }

        public Brush GetFoodColor()
        {
            if (FoodName.Equals(enFoodsName.RedFood)) return GameSettings.FoodColor;
            if (FoodName.Equals(enFoodsName.GreenFood)) return Brushes.Green;
            if (FoodName.Equals(enFoodsName.BlueFood)) return Brushes.Blue;
            if (FoodName.Equals(enFoodsName.YellowFood)) return Brushes.Yellow;
            else return Brushes.Red;
        }

        public Food() : this(enFoodsName.RedFood){}

        public Food(enFoodsName FoodName)
        {
            this.FoodName = FoodName;
            this.FoodColor = GetFoodColor();
        }

    }
}
