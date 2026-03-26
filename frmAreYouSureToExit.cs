using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AslanSnakeGame
{
    public partial class frmAreYouSureToExit : Form
    {
        static public int result;
        public frmAreYouSureToExit()
        {
            InitializeComponent();
            InitializeBtnsPicBoxesArray();
        }

        private void InitializeBtnsPicBoxesArray()
        {
            SystemSettings.frmAreYouSureBtnsPicBoxes[0] = picResumeButton;
            SystemSettings.frmAreYouSureBtnsPicBoxes[1] = picSettingsButton;
            SystemSettings.frmAreYouSureBtnsPicBoxes[2] = picHomeButton;
        }



        private void btn_Focus(object sender, EventArgs e)
        {
            SystemSettings.btn_UpdateEffects(SystemSettings.frmAreYouSureBtnsPicBoxes, true, (Button)sender);
        }

        private void btn_NotFocus(object sender, EventArgs e)
        {
            SystemSettings.btn_UpdateEffects(SystemSettings.frmAreYouSureBtnsPicBoxes, false, (Button)sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            result = 3;
            this.Close();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            result = 1;
            this.Close();
            
        }

        private void btnSettings2_Click(object sender, EventArgs e)
        {
            result = 2;
            new frmSettings().ShowDialog();
        }

       
    }
}
