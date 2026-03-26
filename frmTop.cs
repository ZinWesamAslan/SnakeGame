using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AslanSnakeGame
{
    public partial class frmTop : Form
    {
        public List<LabelContainer> LblContainers = new List<LabelContainer>();
        public List<ScoreRecordContainer> RContainers = new List<ScoreRecordContainer>();
        public frmTop()
        {
            InitializeComponent();
            InitializeLblContainers();
            RContainers = SystemSettings.GetScoreRecordContainer();
            UpdateLabels();
        }


        private void InitializeLblContainers()
        {
            for (int i = 0; i < 9; i++)
            {
                LblContainers.Add(new LabelContainer());
            }
            LblContainers[0].lblName = lblName1;
            LblContainers[0].lblScore = lblScore1;
            LblContainers[0].lblSpeed = lblSpeed1;
            LblContainers[0].lblMode = lblMode1;
            LblContainers[0].lblSize = lblSize1;
            LblContainers[0].lblTime = lblTime1;
            LblContainers[0].lblDate = lblDate1;
            LblContainers[0].picImage = pic1;

            LblContainers[1].lblName = lblName2; ;
            LblContainers[1].lblScore = lblScore2;
            LblContainers[1].lblSpeed = lblSpeed2;
            LblContainers[1].lblMode = lblMode2;
            LblContainers[1].lblSize = lblSize2;
            LblContainers[1].lblTime = lblTime2;
            LblContainers[1].lblDate = lblDate2;
            LblContainers[1].picImage = pic2;

            LblContainers[2].lblName = lblName3; ;
            LblContainers[2].lblScore = lblScore3;
            LblContainers[2].lblSpeed = lblSpeed3;
            LblContainers[2].lblMode = lblMode3;
            LblContainers[2].lblSize = lblSize3;
            LblContainers[2].lblTime = lblTime3;
            LblContainers[2].lblDate = lblDate3;
            LblContainers[2].picImage = pic3;

            LblContainers[3].lblName = lblName4; ;
            LblContainers[3].lblScore = lblScore4;
            LblContainers[3].lblSpeed = lblSpeed4;
            LblContainers[3].lblMode = lblMode4;
            LblContainers[3].lblSize = lblSize4;
            LblContainers[3].lblTime = lblTime4;
            LblContainers[3].lblDate = lblDate4;
            LblContainers[3].picImage = pic4;

            LblContainers[4].lblName = lblName5; ;
            LblContainers[4].lblScore = lblScore5;
            LblContainers[4].lblSpeed = lblSpeed5;
            LblContainers[4].lblMode = lblMode5;
            LblContainers[4].lblSize = lblSize5;
            LblContainers[4].lblTime = lblTime5;
            LblContainers[4].lblDate = lblDate5;
            LblContainers[4].picImage = pic5;

            LblContainers[5].lblName = lblName6;
            LblContainers[5].lblScore = lblScore6;
            LblContainers[5].lblSpeed = lblSpeed6;
            LblContainers[5].lblMode = lblMode6;
            LblContainers[5].lblSize = lblSize6;
            LblContainers[5].lblTime = lblTime6;
            LblContainers[5].lblDate = lblDate6;
            LblContainers[5].picImage = pic6;

            LblContainers[6].lblName = lblName7 ;
            LblContainers[6].lblScore = lblScore7;
            LblContainers[6].lblSpeed = lblSpeed7;
            LblContainers[6].lblMode = lblMode7;
            LblContainers[6].lblSize = lblSize7;
            LblContainers[6].lblTime = lblTime7;
            LblContainers[6].lblDate = lblDate7;
            LblContainers[6].picImage = pic7;

            LblContainers[7].lblName = lblName8;
            LblContainers[7].lblScore = lblScore8;
            LblContainers[7].lblSpeed = lblSpeed8;
            LblContainers[7].lblMode = lblMode8;
            LblContainers[7].lblSize = lblSize8;
            LblContainers[7].lblTime = lblTime8;
            LblContainers[7].lblDate = lblDate8;
            LblContainers[7].picImage = pic8;

            LblContainers[8].lblName = lblName9;
            LblContainers[8].lblScore = lblScore9;
            LblContainers[8].lblSpeed = lblSpeed9;
            LblContainers[8].lblMode = lblMode9;
            LblContainers[8].lblSize = lblSize9;
            LblContainers[8].lblTime = lblTime9;
            LblContainers[8].lblDate = lblDate9;
            LblContainers[8].picImage = pic9;
            
        }

        private void UpdateLabels()
        {
            int j;
            if (RContainers.Count > 9)j = 9;
            else j = RContainers.Count();
            for(int i = 0; i < j; i++)
            {
                
                LblContainers[i].lblName.Text = RContainers[i].Name;
                LblContainers[i].lblScore.Text = Convert.ToString(RContainers[i].Score);
                LblContainers[i].lblSpeed.Text = RContainers[i].Speed;
                LblContainers[i].lblMode.Text = RContainers[i].Mode;
                LblContainers[i].lblSize.Text = RContainers[i].Size;
                LblContainers[i].lblTime.Text = RContainers[i].Time;
                LblContainers[i].lblDate.Text = RContainers[i].Date;
                LblContainers[i].picImage.Image = GameSettings.LoadImageSafely(RContainers[i].ImagePath);
            }
        }
        
        private void frmTop_Load(object sender, EventArgs e)
        {

        }

        private void frmTop_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
}
