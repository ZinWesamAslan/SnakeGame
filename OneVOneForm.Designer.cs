namespace SnakeGameCsharp
{
    partial class OneVOneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneVOneForm));
            this.btnSnap = new System.Windows.Forms.Button();
            this.pbTable = new System.Windows.Forms.PictureBox();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblBestScore1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblBestScore2 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSnap
            // 
            this.btnSnap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSnap.FlatAppearance.BorderSize = 2;
            this.btnSnap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSnap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnSnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnap.ForeColor = System.Drawing.Color.Black;
            this.btnSnap.Location = new System.Drawing.Point(643, 12);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(71, 37);
            this.btnSnap.TabIndex = 2;
            this.btnSnap.Text = "Snap";
            this.btnSnap.UseVisualStyleBackColor = true;
            this.btnSnap.Click += new System.EventHandler(this.btnSnapClick);
            // 
            // pbTable
            // 
            this.pbTable.BackColor = System.Drawing.Color.Gray;
            this.pbTable.Image = ((System.Drawing.Image)(resources.GetObject("pbTable.Image")));
            this.pbTable.Location = new System.Drawing.Point(11, 16);
            this.pbTable.Name = "pbTable";
            this.pbTable.Size = new System.Drawing.Size(1335, 660);
            this.pbTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTable.TabIndex = 3;
            this.pbTable.TabStop = false;
            this.pbTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pbTableGraphicsUpdate);
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.Color.Black;
            this.lblScore1.Location = new System.Drawing.Point(759, 12);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(72, 18);
            this.lblScore1.TabIndex = 4;
            this.lblScore1.Text = "Score 1 : ";
            // 
            // lblBestScore1
            // 
            this.lblBestScore1.AutoSize = true;
            this.lblBestScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore1.ForeColor = System.Drawing.Color.Black;
            this.lblBestScore1.Location = new System.Drawing.Point(729, 31);
            this.lblBestScore1.Name = "lblBestScore1";
            this.lblBestScore1.Size = new System.Drawing.Size(62, 18);
            this.lblBestScore1.TabIndex = 5;
            this.lblBestScore1.Text = "Best 1 : ";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(496, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(71, 37);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStartClick);
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // lblBestScore2
            // 
            this.lblBestScore2.AutoSize = true;
            this.lblBestScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore2.ForeColor = System.Drawing.Color.Black;
            this.lblBestScore2.Location = new System.Drawing.Point(904, 12);
            this.lblBestScore2.Name = "lblBestScore2";
            this.lblBestScore2.Size = new System.Drawing.Size(62, 18);
            this.lblBestScore2.TabIndex = 7;
            this.lblBestScore2.Text = "Best 2 : ";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.Color.Black;
            this.lblScore2.Location = new System.Drawing.Point(831, 31);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(72, 18);
            this.lblScore2.TabIndex = 6;
            this.lblScore2.Text = "Score 2 : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pbTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 694);
            this.panel1.TabIndex = 8;
            // 
            // OneVOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1312, 749);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblBestScore2);
            this.Controls.Add(this.lblBestScore1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.btnSnap);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "OneVOneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGameC#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnap;
        private System.Windows.Forms.PictureBox pbTable;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblBestScore1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblBestScore2;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Panel panel1;
    }
}

