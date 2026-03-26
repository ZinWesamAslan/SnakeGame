namespace AslanSnakeGame
{
    partial class frm1V1Mode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1V1Mode));
            this.pic1V1Table = new System.Windows.Forms.PictureBox();
            this.pnlMainMode = new System.Windows.Forms.Panel();
            this.btnStart1v1Mode = new System.Windows.Forms.Button();
            this.picPlayerOneProfile = new System.Windows.Forms.PictureBox();
            this.picPlayerTwoProfile = new System.Windows.Forms.PictureBox();
            this.lblPlayerOneName = new System.Windows.Forms.Label();
            this.lblPlayerTwoName = new System.Windows.Forms.Label();
            this.lblP1SnakeLength = new System.Windows.Forms.Label();
            this.lblP2SnakeLength = new System.Windows.Forms.Label();
            this.lblP1BestLength = new System.Windows.Forms.Label();
            this.lblP2BestLength = new System.Windows.Forms.Label();
            this.pnlBetweenThePlayersNames = new System.Windows.Forms.Panel();
            this.lblP2BestLengthResult = new System.Windows.Forms.Label();
            this.lblP2SnakeLengthResult = new System.Windows.Forms.Label();
            this.lblP1BestLengthResult = new System.Windows.Forms.Label();
            this.lblP1SnakeLengthResult = new System.Windows.Forms.Label();
            this.lblP1ScoreResult = new System.Windows.Forms.Label();
            this.lblP2ScoreResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1V1Table)).BeginInit();
            this.pnlMainMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerOneProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerTwoProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1V1Table
            // 
            this.pic1V1Table.BackColor = System.Drawing.Color.Gray;
            this.pic1V1Table.Location = new System.Drawing.Point(5, 4);
            this.pic1V1Table.Name = "pic1V1Table";
            this.pic1V1Table.Size = new System.Drawing.Size(1300, 700);
            this.pic1V1Table.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic1V1Table.TabIndex = 4;
            this.pic1V1Table.TabStop = false;
            this.pic1V1Table.Click += new System.EventHandler(this.pbTable_Click);
            // 
            // pnlMainMode
            // 
            this.pnlMainMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMainMode.Controls.Add(this.btnStart1v1Mode);
            this.pnlMainMode.Controls.Add(this.pic1V1Table);
            this.pnlMainMode.Location = new System.Drawing.Point(29, 57);
            this.pnlMainMode.Name = "pnlMainMode";
            this.pnlMainMode.Size = new System.Drawing.Size(1310, 708);
            this.pnlMainMode.TabIndex = 5;
            // 
            // btnStart1v1Mode
            // 
            this.btnStart1v1Mode.BackColor = System.Drawing.Color.Teal;
            this.btnStart1v1Mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart1v1Mode.FlatAppearance.BorderSize = 2;
            this.btnStart1v1Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart1v1Mode.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart1v1Mode.Location = new System.Drawing.Point(295, 218);
            this.btnStart1v1Mode.Name = "btnStart1v1Mode";
            this.btnStart1v1Mode.Size = new System.Drawing.Size(739, 234);
            this.btnStart1v1Mode.TabIndex = 5;
            this.btnStart1v1Mode.Text = "Press Here To Start";
            this.btnStart1v1Mode.UseVisualStyleBackColor = false;
            this.btnStart1v1Mode.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picPlayerOneProfile
            // 
            this.picPlayerOneProfile.BackColor = System.Drawing.Color.Silver;
            this.picPlayerOneProfile.Image = ((System.Drawing.Image)(resources.GetObject("picPlayerOneProfile.Image")));
            this.picPlayerOneProfile.Location = new System.Drawing.Point(0, 0);
            this.picPlayerOneProfile.Name = "picPlayerOneProfile";
            this.picPlayerOneProfile.Size = new System.Drawing.Size(69, 57);
            this.picPlayerOneProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerOneProfile.TabIndex = 6;
            this.picPlayerOneProfile.TabStop = false;
            // 
            // picPlayerTwoProfile
            // 
            this.picPlayerTwoProfile.BackColor = System.Drawing.Color.Silver;
            this.picPlayerTwoProfile.Image = ((System.Drawing.Image)(resources.GetObject("picPlayerTwoProfile.Image")));
            this.picPlayerTwoProfile.Location = new System.Drawing.Point(1297, 0);
            this.picPlayerTwoProfile.Name = "picPlayerTwoProfile";
            this.picPlayerTwoProfile.Size = new System.Drawing.Size(69, 57);
            this.picPlayerTwoProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerTwoProfile.TabIndex = 7;
            this.picPlayerTwoProfile.TabStop = false;
            // 
            // lblPlayerOneName
            // 
            this.lblPlayerOneName.AutoSize = true;
            this.lblPlayerOneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneName.Location = new System.Drawing.Point(268, 9);
            this.lblPlayerOneName.Name = "lblPlayerOneName";
            this.lblPlayerOneName.Size = new System.Drawing.Size(294, 42);
            this.lblPlayerOneName.TabIndex = 6;
            this.lblPlayerOneName.Text = "zin wesam aslan";
            this.lblPlayerOneName.Click += new System.EventHandler(this.lblPlayerOneName_Click);
            // 
            // lblPlayerTwoName
            // 
            this.lblPlayerTwoName.AutoSize = true;
            this.lblPlayerTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoName.Location = new System.Drawing.Point(774, 9);
            this.lblPlayerTwoName.Name = "lblPlayerTwoName";
            this.lblPlayerTwoName.Size = new System.Drawing.Size(314, 42);
            this.lblPlayerTwoName.TabIndex = 8;
            this.lblPlayerTwoName.Text = "Ali Mohamed zino";
            // 
            // lblP1SnakeLength
            // 
            this.lblP1SnakeLength.AutoSize = true;
            this.lblP1SnakeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1SnakeLength.Location = new System.Drawing.Point(75, 3);
            this.lblP1SnakeLength.Name = "lblP1SnakeLength";
            this.lblP1SnakeLength.Size = new System.Drawing.Size(136, 24);
            this.lblP1SnakeLength.TabIndex = 9;
            this.lblP1SnakeLength.Text = "Snake Length :";
            // 
            // lblP2SnakeLength
            // 
            this.lblP2SnakeLength.AutoSize = true;
            this.lblP2SnakeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2SnakeLength.Location = new System.Drawing.Point(1117, 2);
            this.lblP2SnakeLength.Name = "lblP2SnakeLength";
            this.lblP2SnakeLength.Size = new System.Drawing.Size(136, 24);
            this.lblP2SnakeLength.TabIndex = 10;
            this.lblP2SnakeLength.Text = "Snake Length :";
            // 
            // lblP1BestLength
            // 
            this.lblP1BestLength.AutoSize = true;
            this.lblP1BestLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1BestLength.Location = new System.Drawing.Point(75, 30);
            this.lblP1BestLength.Name = "lblP1BestLength";
            this.lblP1BestLength.Size = new System.Drawing.Size(119, 24);
            this.lblP1BestLength.TabIndex = 11;
            this.lblP1BestLength.Text = "Best Length :";
            // 
            // lblP2BestLength
            // 
            this.lblP2BestLength.AutoSize = true;
            this.lblP2BestLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2BestLength.Location = new System.Drawing.Point(1117, 29);
            this.lblP2BestLength.Name = "lblP2BestLength";
            this.lblP2BestLength.Size = new System.Drawing.Size(119, 24);
            this.lblP2BestLength.TabIndex = 12;
            this.lblP2BestLength.Text = "Best Length :";
            // 
            // pnlBetweenThePlayersNames
            // 
            this.pnlBetweenThePlayersNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBetweenThePlayersNames.Location = new System.Drawing.Point(680, -1);
            this.pnlBetweenThePlayersNames.Name = "pnlBetweenThePlayersNames";
            this.pnlBetweenThePlayersNames.Size = new System.Drawing.Size(3, 60);
            this.pnlBetweenThePlayersNames.TabIndex = 13;
            // 
            // lblP2BestLengthResult
            // 
            this.lblP2BestLengthResult.AutoSize = true;
            this.lblP2BestLengthResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2BestLengthResult.Location = new System.Drawing.Point(1230, 29);
            this.lblP2BestLengthResult.Name = "lblP2BestLengthResult";
            this.lblP2BestLengthResult.Size = new System.Drawing.Size(40, 24);
            this.lblP2BestLengthResult.TabIndex = 14;
            this.lblP2BestLengthResult.Text = "552";
            this.lblP2BestLengthResult.Click += new System.EventHandler(this.lblP2SnakeLengthResult_Click);
            // 
            // lblP2SnakeLengthResult
            // 
            this.lblP2SnakeLengthResult.AutoSize = true;
            this.lblP2SnakeLengthResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2SnakeLengthResult.Location = new System.Drawing.Point(1250, 5);
            this.lblP2SnakeLengthResult.Name = "lblP2SnakeLengthResult";
            this.lblP2SnakeLengthResult.Size = new System.Drawing.Size(30, 24);
            this.lblP2SnakeLengthResult.TabIndex = 15;
            this.lblP2SnakeLengthResult.Text = "55";
            // 
            // lblP1BestLengthResult
            // 
            this.lblP1BestLengthResult.AutoSize = true;
            this.lblP1BestLengthResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1BestLengthResult.Location = new System.Drawing.Point(194, 28);
            this.lblP1BestLengthResult.Name = "lblP1BestLengthResult";
            this.lblP1BestLengthResult.Size = new System.Drawing.Size(30, 24);
            this.lblP1BestLengthResult.TabIndex = 16;
            this.lblP1BestLengthResult.Text = "44";
            // 
            // lblP1SnakeLengthResult
            // 
            this.lblP1SnakeLengthResult.AutoSize = true;
            this.lblP1SnakeLengthResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1SnakeLengthResult.Location = new System.Drawing.Point(210, 4);
            this.lblP1SnakeLengthResult.Name = "lblP1SnakeLengthResult";
            this.lblP1SnakeLengthResult.Size = new System.Drawing.Size(30, 24);
            this.lblP1SnakeLengthResult.TabIndex = 17;
            this.lblP1SnakeLengthResult.Text = "22";
            // 
            // lblP1ScoreResult
            // 
            this.lblP1ScoreResult.AutoSize = true;
            this.lblP1ScoreResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1ScoreResult.Location = new System.Drawing.Point(618, 8);
            this.lblP1ScoreResult.Name = "lblP1ScoreResult";
            this.lblP1ScoreResult.Size = new System.Drawing.Size(60, 42);
            this.lblP1ScoreResult.TabIndex = 18;
            this.lblP1ScoreResult.Text = "44";
            // 
            // lblP2ScoreResult
            // 
            this.lblP2ScoreResult.AutoSize = true;
            this.lblP2ScoreResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2ScoreResult.Location = new System.Drawing.Point(686, 8);
            this.lblP2ScoreResult.Name = "lblP2ScoreResult";
            this.lblP2ScoreResult.Size = new System.Drawing.Size(60, 42);
            this.lblP2ScoreResult.TabIndex = 19;
            this.lblP2ScoreResult.Text = "44";
            // 
            // frm1V1Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.lblP2ScoreResult);
            this.Controls.Add(this.lblP1ScoreResult);
            this.Controls.Add(this.lblP1BestLengthResult);
            this.Controls.Add(this.lblP2BestLengthResult);
            this.Controls.Add(this.lblP1SnakeLength);
            this.Controls.Add(this.lblP2SnakeLength);
            this.Controls.Add(this.lblP1SnakeLengthResult);
            this.Controls.Add(this.lblP2SnakeLengthResult);
            this.Controls.Add(this.lblP1BestLength);
            this.Controls.Add(this.pnlBetweenThePlayersNames);
            this.Controls.Add(this.lblP2BestLength);
            this.Controls.Add(this.lblPlayerTwoName);
            this.Controls.Add(this.lblPlayerOneName);
            this.Controls.Add(this.picPlayerTwoProfile);
            this.Controls.Add(this.picPlayerOneProfile);
            this.Controls.Add(this.pnlMainMode);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm1V1Mode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNormalMode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pic1V1Table)).EndInit();
            this.pnlMainMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerOneProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerTwoProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1V1Table;
        private System.Windows.Forms.Panel pnlMainMode;
        private System.Windows.Forms.Button btnStart1v1Mode;
        private System.Windows.Forms.PictureBox picPlayerOneProfile;
        private System.Windows.Forms.PictureBox picPlayerTwoProfile;
        private System.Windows.Forms.Label lblPlayerOneName;
        private System.Windows.Forms.Label lblPlayerTwoName;
        private System.Windows.Forms.Label lblP1SnakeLength;
        private System.Windows.Forms.Label lblP2SnakeLength;
        private System.Windows.Forms.Label lblP1BestLength;
        private System.Windows.Forms.Label lblP2BestLength;
        private System.Windows.Forms.Panel pnlBetweenThePlayersNames;
        private System.Windows.Forms.Label lblP2BestLengthResult;
        private System.Windows.Forms.Label lblP2SnakeLengthResult;
        private System.Windows.Forms.Label lblP1BestLengthResult;
        private System.Windows.Forms.Label lblP1SnakeLengthResult;
        private System.Windows.Forms.Label lblP1ScoreResult;
        private System.Windows.Forms.Label lblP2ScoreResult;
    }
}