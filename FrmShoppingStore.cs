using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AslanSnakeGame
{
    public partial class FrmShoppingStore : Form
    {
        public FrmShoppingStore()
        {
            InitializeComponent();
            lblCoins.Text = GameSettings.TotalCoins.ToString();
            SetUpButtons();
        }

        private void UnlockItem(Button B , PictureBox P ,Label L)
        {
            B.Text = "Select";
            P.Visible = false;
            L.Visible = false;
        }

        private void SetUpButtons()
        {
            int n = GameSettings.MyItems;
            if ((1   | n) == n) UnlockItem(btnUnlock1, picC1, lblC1);
            if ((2   | n) == n) UnlockItem(btnUnlock2, picC2, lblC2);
            if ((4   | n) == n) UnlockItem(btnUnlock3, picC3, lblC3);
            if ((8   | n) == n) UnlockItem(btnUnlock4, picC4, lblC4);
            if ((16  | n) == n) UnlockItem(btnUnlock5, picC5, lblC5);
            if ((32  | n) == n) UnlockItem(btnUnlock6, picC6, lblC6);
            if ((64  | n) == n) UnlockItem(btnUnlock7, picC7, lblC7);
            if ((128 | n) == n) UnlockItem(btnUnlock8, picC8, lblC8);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SystemSettings.SoundOfButtonClick.Play();
            SystemSettings.UpdateGameSettingFileContent();
            this.Close();
        }

        private int GetItemPrice(int Tag)
        {
            
            if (Tag == 1) return Convert.ToInt32(lblC1.Text);
            else if (Tag == 2) return Convert.ToInt32(lblC2.Text);
            else if (Tag == 4) return Convert.ToInt32(lblC3.Text);
            else if (Tag == 8) return Convert.ToInt32(lblC4.Text);
            else if (Tag == 16) return Convert.ToInt32(lblC5.Text);
            else if (Tag == 32) return Convert.ToInt32(lblC6.Text);
            else if (Tag == 64) return Convert.ToInt32(lblC7.Text);
            else if (Tag == 128) return Convert.ToInt32(lblC8.Text);
            return 0;
        }

        private Color GetColor(int Tag)
        {
            if (Tag == 1) return picItem1.BackColor;
            else if (Tag == 2) return picItem2.BackColor;
            else if (Tag == 4) return picItem3.BackColor;
            else if (Tag == 8) return picItem4.BackColor;
            return Color.Gray;
        }

        private Image GetImage(int Tag)
        {
            if (Tag == 16) return picItem5.Image;
            else if (Tag == 32) return picItem6.Image;
            else if (Tag ==64) return picItem7.Image;
            else if (Tag == 128) return picItem8.Image;
            return null;
        }

        private PictureBox getPic(int Tag)
        {
            if (Tag == 1) return picC1;
            else if (Tag == 2) return picC2;
            else if (Tag == 4) return picC3;
            else if (Tag == 8) return picC4;
            else if (Tag == 16) return picC5;
            else if (Tag == 32) return picC6;
            else if (Tag == 64) return picC7;
            else if (Tag == 128) return picC8;
            return picC1;
        }

        private Label getLabel(int Tag)
        {
            if (Tag == 1) return lblC1;
            else if (Tag == 2) return lblC2;
            else if (Tag == 4) return lblC3;
            else if (Tag == 8) return lblC4;
            else if (Tag == 16) return lblC5;
            else if (Tag == 32) return lblC6;
            else if (Tag == 64) return lblC7;
            else if (Tag == 128) return lblC8;
            return lblC1;
        }

        private int getGroundImageIndex(int Tag)
        {
            if (Tag == 16) return 0;
            else if (Tag == 32) return 1;
            else if (Tag == 64) return 2;
            else if (Tag == 128) return 3;
            return 0;
        }

        private void btns_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int Tag = Convert.ToInt32(b.Tag);
            int price = GetItemPrice(Tag);

            if (b.Text.Equals("Unlock"))
            {
                if (GameSettings.TotalCoins >= price)
                {
                    GameSettings.TotalCoins -= price;
                    b.Text = "Select";
                    GameSettings.MyItems += Convert.ToInt32(Tag);
                    lblCoins.Text = GameSettings.TotalCoins.ToString();
                    UnlockItem(b,getPic(Tag),getLabel(Tag));
                }
                else
                {
                    MessageBox.Show("You Don't have enough Coins ...", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (b.Text.Equals("Select"))
            {
                if (Tag > 8)
                {
                    GameSettings.GroundImage = GetImage(Tag);
                    GameSettings.GroundImageIndex = getGroundImageIndex(Tag);
                }
                else
                {
                    GameSettings.GroundColor = GetColor(Tag);
                }
            }
         
        }
    }
}
