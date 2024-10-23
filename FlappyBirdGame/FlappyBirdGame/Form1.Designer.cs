namespace FlappyBirdGame
{
    partial class Form1
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.theGround = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.otherGround = new System.Windows.Forms.PictureBox();
            this.theBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.theGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreText.Location = new System.Drawing.Point(12, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(118, 38);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "Score:0";
            // 
            // theGround
            // 
            this.theGround.Image = global::FlappyBirdGame.Properties.Resources.theGround;
            this.theGround.Location = new System.Drawing.Point(-269, 479);
            this.theGround.Name = "theGround";
            this.theGround.Size = new System.Drawing.Size(1125, 93);
            this.theGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.theGround.TabIndex = 4;
            this.theGround.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBirdGame.Properties.Resources.pipeTop;
            this.pipeTop.Location = new System.Drawing.Point(381, -65);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(73, 201);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 3;
            this.pipeTop.TabStop = false;
            // 
            // otherGround
            // 
            this.otherGround.Image = global::FlappyBirdGame.Properties.Resources.theGround;
            this.otherGround.Location = new System.Drawing.Point(420, 479);
            this.otherGround.Name = "otherGround";
            this.otherGround.Size = new System.Drawing.Size(436, 93);
            this.otherGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.otherGround.TabIndex = 2;
            this.otherGround.TabStop = false;
            // 
            // theBird
            // 
            this.theBird.Image = global::FlappyBirdGame.Properties.Resources.pngegg;
            this.theBird.Location = new System.Drawing.Point(54, 195);
            this.theBird.Name = "theBird";
            this.theBird.Size = new System.Drawing.Size(62, 56);
            this.theBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.theBird.TabIndex = 1;
            this.theBird.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::FlappyBirdGame.Properties.Resources.pipeBottom;
            this.pipeBottom.Location = new System.Drawing.Point(618, 317);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(73, 222);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 0;
            this.pipeBottom.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(847, 541);
            this.Controls.Add(this.otherGround);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.theBird);
            this.Controls.Add(this.theGround);
            this.Controls.Add(this.pipeBottom);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.theGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox theBird;
        private System.Windows.Forms.PictureBox otherGround;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox theGround;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
    }
}

