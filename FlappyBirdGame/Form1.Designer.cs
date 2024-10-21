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
            this.pBoxBird = new System.Windows.Forms.PictureBox();
            this.pBoxDown = new System.Windows.Forms.PictureBox();
            this.pBoxGround = new System.Windows.Forms.PictureBox();
            this.pBoxTop = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.timerControl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxBird
            // 
            this.pBoxBird.Image = global::FlappyBirdGame.Properties.Resources.bird;
            this.pBoxBird.Location = new System.Drawing.Point(70, 135);
            this.pBoxBird.Name = "pBoxBird";
            this.pBoxBird.Size = new System.Drawing.Size(61, 47);
            this.pBoxBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxBird.TabIndex = 0;
            this.pBoxBird.TabStop = false;
            // 
            // pBoxDown
            // 
            this.pBoxDown.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pBoxDown.Location = new System.Drawing.Point(200, 257);
            this.pBoxDown.Name = "pBoxDown";
            this.pBoxDown.Size = new System.Drawing.Size(129, 169);
            this.pBoxDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDown.TabIndex = 1;
            this.pBoxDown.TabStop = false;
            // 
            // pBoxGround
            // 
            this.pBoxGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBoxGround.Image = global::FlappyBirdGame.Properties.Resources.ground;
            this.pBoxGround.Location = new System.Drawing.Point(0, 421);
            this.pBoxGround.Name = "pBoxGround";
            this.pBoxGround.Size = new System.Drawing.Size(713, 102);
            this.pBoxGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxGround.TabIndex = 2;
            this.pBoxGround.TabStop = false;
            // 
            // pBoxTop
            // 
            this.pBoxTop.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pBoxTop.Location = new System.Drawing.Point(493, -2);
            this.pBoxTop.Name = "pBoxTop";
            this.pBoxTop.Size = new System.Drawing.Size(129, 155);
            this.pBoxTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxTop.TabIndex = 3;
            this.pBoxTop.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(72, 18);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "SCORE:";
            // 
            // timerControl
            // 
            this.timerControl.Enabled = true;
            this.timerControl.Interval = 20;
            this.timerControl.Tick += new System.EventHandler(this.GameTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 523);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pBoxTop);
            this.Controls.Add(this.pBoxGround);
            this.Controls.Add(this.pBoxDown);
            this.Controls.Add(this.pBoxBird);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxBird;
        private System.Windows.Forms.PictureBox pBoxDown;
        private System.Windows.Forms.PictureBox pBoxGround;
        private System.Windows.Forms.PictureBox pBoxTop;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timerControl;
    }
}

