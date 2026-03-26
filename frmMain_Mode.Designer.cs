namespace AslanSnakeGame
{
    partial class frmMainMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMode));
            this.lblBestScore = new System.Windows.Forms.Label();
            this.lblMainPlayerName = new System.Windows.Forms.Label();
            this.picMainPlayerProfile = new System.Windows.Forms.PictureBox();
            this.pnlMainMode = new System.Windows.Forms.Panel();
            this.btnStartMainMode = new System.Windows.Forms.Button();
            this.picMainModeTable = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.CountDownTimer_BlueFood = new System.Windows.Forms.Timer(this.components);
            this.lblBlueFoodEffectTimer = new System.Windows.Forms.Label();
            this.CountDownTimer_GreenFood = new System.Windows.Forms.Timer(this.components);
            this.lblGreenFoodEffectTimer = new System.Windows.Forms.Label();
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMainPlayerProfile)).BeginInit();
            this.pnlMainMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainModeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.Location = new System.Drawing.Point(755, 13);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(197, 33);
            this.lblBestScore.TabIndex = 25;
            this.lblBestScore.Text = "Best Score : 0";
            // 
            // lblMainPlayerName
            // 
            this.lblMainPlayerName.AutoSize = true;
            this.lblMainPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPlayerName.Location = new System.Drawing.Point(72, 11);
            this.lblMainPlayerName.Name = "lblMainPlayerName";
            this.lblMainPlayerName.Size = new System.Drawing.Size(152, 42);
            this.lblMainPlayerName.TabIndex = 21;
            this.lblMainPlayerName.Text = "Welcom";
            // 
            // picMainPlayerProfile
            // 
            this.picMainPlayerProfile.BackColor = System.Drawing.Color.Silver;
            this.picMainPlayerProfile.Image = ((System.Drawing.Image)(resources.GetObject("picMainPlayerProfile.Image")));
            this.picMainPlayerProfile.Location = new System.Drawing.Point(0, 0);
            this.picMainPlayerProfile.Name = "picMainPlayerProfile";
            this.picMainPlayerProfile.Size = new System.Drawing.Size(69, 57);
            this.picMainPlayerProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainPlayerProfile.TabIndex = 22;
            this.picMainPlayerProfile.TabStop = false;
            // 
            // pnlMainMode
            // 
            this.pnlMainMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMainMode.Controls.Add(this.btnStartMainMode);
            this.pnlMainMode.Controls.Add(this.picMainModeTable);
            this.pnlMainMode.Location = new System.Drawing.Point(29, 57);
            this.pnlMainMode.Name = "pnlMainMode";
            this.pnlMainMode.Size = new System.Drawing.Size(1310, 708);
            this.pnlMainMode.TabIndex = 20;
            // 
            // btnStartMainMode
            // 
            this.btnStartMainMode.BackColor = System.Drawing.Color.Teal;
            this.btnStartMainMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartMainMode.FlatAppearance.BorderSize = 2;
            this.btnStartMainMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartMainMode.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMainMode.Location = new System.Drawing.Point(348, 22);
            this.btnStartMainMode.Name = "btnStartMainMode";
            this.btnStartMainMode.Size = new System.Drawing.Size(578, 94);
            this.btnStartMainMode.TabIndex = 5;
            this.btnStartMainMode.Text = "Press Here To Start";
            this.btnStartMainMode.UseVisualStyleBackColor = false;
            this.btnStartMainMode.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStartMainMode.Enter += new System.EventHandler(this.btn_Focus);
            this.btnStartMainMode.Leave += new System.EventHandler(this.btn_NotFocus);
            this.btnStartMainMode.MouseEnter += new System.EventHandler(this.btn_Focus);
            this.btnStartMainMode.MouseLeave += new System.EventHandler(this.btn_NotFocus);
            // 
            // picMainModeTable
            // 
            this.picMainModeTable.BackColor = System.Drawing.Color.Gray;
            this.picMainModeTable.Location = new System.Drawing.Point(5, 4);
            this.picMainModeTable.Name = "picMainModeTable";
            this.picMainModeTable.Size = new System.Drawing.Size(1300, 700);
            this.picMainModeTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMainModeTable.TabIndex = 4;
            this.picMainModeTable.TabStop = false;
            this.picMainModeTable.Paint += new System.Windows.Forms.PaintEventHandler(this.picTableGraphicsUpdate);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(535, 15);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 31);
            this.lblScore.TabIndex = 31;
            this.lblScore.Text = "Score :";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // CountDownTimer_BlueFood
            // 
            this.CountDownTimer_BlueFood.Interval = 1000;
            this.CountDownTimer_BlueFood.Tick += new System.EventHandler(this.CountDownTimerEvent_BlueFood);
            // 
            // lblBlueFoodEffectTimer
            // 
            this.lblBlueFoodEffectTimer.AutoSize = true;
            this.lblBlueFoodEffectTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueFoodEffectTimer.ForeColor = System.Drawing.Color.Cyan;
            this.lblBlueFoodEffectTimer.Location = new System.Drawing.Point(1252, 9);
            this.lblBlueFoodEffectTimer.Name = "lblBlueFoodEffectTimer";
            this.lblBlueFoodEffectTimer.Size = new System.Drawing.Size(60, 42);
            this.lblBlueFoodEffectTimer.TabIndex = 32;
            this.lblBlueFoodEffectTimer.Text = "10";
            this.lblBlueFoodEffectTimer.Visible = false;
            // 
            // CountDownTimer_GreenFood
            // 
            this.CountDownTimer_GreenFood.Interval = 1000;
            this.CountDownTimer_GreenFood.Tick += new System.EventHandler(this.CountDownTimerEvent_GreenFood);
            // 
            // lblGreenFoodEffectTimer
            // 
            this.lblGreenFoodEffectTimer.AutoSize = true;
            this.lblGreenFoodEffectTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenFoodEffectTimer.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblGreenFoodEffectTimer.Location = new System.Drawing.Point(1177, 9);
            this.lblGreenFoodEffectTimer.Name = "lblGreenFoodEffectTimer";
            this.lblGreenFoodEffectTimer.Size = new System.Drawing.Size(60, 42);
            this.lblGreenFoodEffectTimer.TabIndex = 33;
            this.lblGreenFoodEffectTimer.Text = "20";
            this.lblGreenFoodEffectTimer.Visible = false;
            // 
            // TimeTimer
            // 
            this.TimeTimer.Interval = 1000;
            this.TimeTimer.Tick += new System.EventHandler(this.TimeTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(719, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // frmMainMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGreenFoodEffectTimer);
            this.Controls.Add(this.lblBlueFoodEffectTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.lblMainPlayerName);
            this.Controls.Add(this.picMainPlayerProfile);
            this.Controls.Add(this.pnlMainMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNormalMode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picMainPlayerProfile)).EndInit();
            this.pnlMainMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMainModeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Label lblMainPlayerName;
        private System.Windows.Forms.PictureBox picMainPlayerProfile;
        private System.Windows.Forms.Panel pnlMainMode;
        private System.Windows.Forms.Button btnStartMainMode;
        private System.Windows.Forms.PictureBox picMainModeTable;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer CountDownTimer_BlueFood;
        private System.Windows.Forms.Label lblBlueFoodEffectTimer;
        private System.Windows.Forms.Timer CountDownTimer_GreenFood;
        private System.Windows.Forms.Label lblGreenFoodEffectTimer;


        private System.Windows.Forms.Timer TimeTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}