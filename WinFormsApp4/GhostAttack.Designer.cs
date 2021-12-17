namespace WinFormsApp4
{
    partial class GhostAttack
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.startBox = new System.Windows.Forms.PictureBox();
            this.finishBox = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRestart = new System.Windows.Forms.Label();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = global::WinFormsApp4.Properties.Resources.ball1;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ball.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ball.Location = new System.Drawing.Point(50, 50);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(50, 50);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(600, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "grass";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(450, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "grass";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox4.Location = new System.Drawing.Point(500, 300);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "grass";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox6.BackgroundImage = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(0, 500);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(800, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "grass";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox16.BackgroundImage = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox16.ErrorImage = null;
            this.pictureBox16.Location = new System.Drawing.Point(0, 0);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(800, 50);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 2;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "grass";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox17.BackgroundImage = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox17.ErrorImage = null;
            this.pictureBox17.Location = new System.Drawing.Point(0, 50);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(50, 450);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 2;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "grass";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox18.BackgroundImage = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox18.ErrorImage = null;
            this.pictureBox18.Location = new System.Drawing.Point(750, 50);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(50, 450);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 2;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "grass";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WinFormsApp4.Properties.Resources.cloud;
            this.pictureBox3.Location = new System.Drawing.Point(79, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "sky";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImage = global::WinFormsApp4.Properties.Resources.cloud;
            this.pictureBox19.Location = new System.Drawing.Point(322, 444);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(150, 50);
            this.pictureBox19.TabIndex = 5;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "sky";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackgroundImage = global::WinFormsApp4.Properties.Resources.cloud;
            this.pictureBox20.Location = new System.Drawing.Point(644, 323);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(100, 50);
            this.pictureBox20.TabIndex = 5;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "sky";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackgroundImage = global::WinFormsApp4.Properties.Resources.cloud;
            this.pictureBox21.Location = new System.Drawing.Point(276, 208);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(100, 50);
            this.pictureBox21.TabIndex = 5;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "sky";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox5.Location = new System.Drawing.Point(150, 250);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "grass";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.BackgroundImage = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox22.ErrorImage = null;
            this.pictureBox22.Image = global::WinFormsApp4.Properties.Resources.grass;
            this.pictureBox22.Location = new System.Drawing.Point(250, 400);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(50, 50);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 2;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "grass";
            // 
            // startBox
            // 
            this.startBox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.startBox.Location = new System.Drawing.Point(50, 50);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(100, 100);
            this.startBox.TabIndex = 6;
            this.startBox.TabStop = false;
            // 
            // finishBox
            // 
            this.finishBox.BackColor = System.Drawing.Color.Firebrick;
            this.finishBox.Location = new System.Drawing.Point(650, 400);
            this.finishBox.Name = "finishBox";
            this.finishBox.Size = new System.Drawing.Size(100, 100);
            this.finishBox.TabIndex = 6;
            this.finishBox.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox24.BackgroundImage = global::WinFormsApp4.Properties.Resources.coin1;
            this.pictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox24.Location = new System.Drawing.Point(1309, 614);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(25, 25);
            this.pictureBox24.TabIndex = 3;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Tag = "coin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(79, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "START";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(682, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "FINISH";
            // 
            // labelRestart
            // 
            this.labelRestart.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRestart.Location = new System.Drawing.Point(49, 292);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(700, 36);
            this.labelRestart.TabIndex = 8;
            this.labelRestart.Text = "Press \"R\" to restart game!";
            this.labelRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRestart.Visible = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Silver;
            this.pictureBox25.Location = new System.Drawing.Point(651, 401);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(100, 100);
            this.pictureBox25.TabIndex = 6;
            this.pictureBox25.TabStop = false;
            // 
            // timerAnimation
            // 
            this.timerAnimation.Enabled = true;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Silver;
            this.pictureBox23.Location = new System.Drawing.Point(49, 49);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(100, 100);
            this.pictureBox23.TabIndex = 6;
            this.pictureBox23.TabStop = false;
            // 
            // GhostAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.finishBox);
            this.Controls.Add(this.labelRestart);
            this.Name = "GhostAttack";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox startBox;
        private System.Windows.Forms.PictureBox finishBox;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRestart;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.PictureBox pictureBox23;
    }
}

