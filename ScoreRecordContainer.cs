using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AslanSnakeGame
{
    public class ScoreRecordContainer : IComparable<ScoreRecordContainer>
    {
        public string Name, Speed, Mode, Size, Time, Date , ImagePath  ;
        public int Score ;

        public int CompareTo(ScoreRecordContainer R)
        {
            return R.Score.CompareTo(Score);
        }

    }
}
