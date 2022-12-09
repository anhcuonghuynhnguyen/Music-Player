using System.Windows.Forms;

namespace AppMusic
{
    partial class fPlay
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
            this.lbSongPre = new System.Windows.Forms.Label();
            this.lbSongNext = new System.Windows.Forms.Label();
            this.lbSongNow = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lbVolume = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSongPre
            // 
            this.lbSongPre.BackColor = System.Drawing.Color.Transparent;
            this.lbSongPre.Font = new System.Drawing.Font("MV Boli", 22F);
            this.lbSongPre.ForeColor = System.Drawing.Color.White;
            this.lbSongPre.Location = new System.Drawing.Point(0, 31);
            this.lbSongPre.Name = "lbSongPre";
            this.lbSongPre.Size = new System.Drawing.Size(235, 180);
            this.lbSongPre.TabIndex = 16;
            this.lbSongPre.Text = "SongPrev";
            this.lbSongPre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSongNext
            // 
            this.lbSongNext.Font = new System.Drawing.Font("MV Boli", 22F);
            this.lbSongNext.ForeColor = System.Drawing.Color.White;
            this.lbSongNext.Location = new System.Drawing.Point(0, 31);
            this.lbSongNext.Name = "lbSongNext";
            this.lbSongNext.Size = new System.Drawing.Size(235, 180);
            this.lbSongNext.TabIndex = 15;
            this.lbSongNext.Text = "SongNext";
            this.lbSongNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSongNow
            // 
            this.lbSongNow.BackColor = System.Drawing.Color.Transparent;
            this.lbSongNow.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongNow.ForeColor = System.Drawing.Color.White;
            this.lbSongNow.Location = new System.Drawing.Point(0, 20);
            this.lbSongNow.Name = "lbSongNow";
            this.lbSongNow.Size = new System.Drawing.Size(285, 235);
            this.lbSongNow.TabIndex = 14;
            this.lbSongNow.Text = "Currently";
            this.lbSongNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbSearch.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(168, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(680, 29);
            this.tbSearch.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::AppMusic.Resource.btnBack;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.Transparent;
            this.btnRandom.BackgroundImage = global::AppMusic.Resource.btnRandom;
            this.btnRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Location = new System.Drawing.Point(244, 455);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(80, 80);
            this.btnRandom.TabIndex = 24;
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.White;
            this.cbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSearch.DropDownHeight = 100;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.DropDownWidth = 70;
            this.cbSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.IntegralHeight = false;
            this.cbSearch.ItemHeight = 20;
            this.cbSearch.Items.AddRange(new object[] {
            "Id",
            "Name"});
            this.cbSearch.Location = new System.Drawing.Point(80, 22);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(78, 28);
            this.cbSearch.TabIndex = 25;
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = global::AppMusic.Resource.btnUp;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(10, 10);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 40);
            this.btnUp.TabIndex = 26;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = global::AppMusic.Resource.btnDown;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Location = new System.Drawing.Point(10, 90);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 40);
            this.btnDown.TabIndex = 27;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lbVolume
            // 
            this.lbVolume.BackColor = System.Drawing.Color.Transparent;
            this.lbVolume.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolume.ForeColor = System.Drawing.Color.White;
            this.lbVolume.Location = new System.Drawing.Point(0, 47);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(60, 44);
            this.lbVolume.TabIndex = 28;
            this.lbVolume.Text = "50";
            this.lbVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::AppMusic.Resource.bgBtn;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnPre);
            this.panel1.Location = new System.Drawing.Point(345, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 110);
            this.panel1.TabIndex = 29;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::AppMusic.Resource.btnNextSong;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(192, 25);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 60);
            this.btnNext.TabIndex = 21;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::AppMusic.Resource.btnPlaySong;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(95, 15);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 80);
            this.btnPlay.TabIndex = 20;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.Transparent;
            this.btnPre.BackgroundImage = global::AppMusic.Resource.btnPrevSong;
            this.btnPre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPre.FlatAppearance.BorderSize = 0;
            this.btnPre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Location = new System.Drawing.Point(16, 25);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(60, 60);
            this.btnPre.TabIndex = 22;
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::AppMusic.Resource.PicSongNow;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbSongNow);
            this.panel2.Location = new System.Drawing.Point(337, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 285);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::AppMusic.Resource.PicSongPrev;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lbSongNext);
            this.panel3.Location = new System.Drawing.Point(643, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 235);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::AppMusic.Resource.PicSongNext;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lbSongPre);
            this.panel4.Location = new System.Drawing.Point(80, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 235);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::AppMusic.Resource.bdVol;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.btnDown);
            this.panel5.Controls.Add(this.btnUp);
            this.panel5.Controls.Add(this.lbVolume);
            this.panel5.Location = new System.Drawing.Point(660, 411);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 140);
            this.panel5.TabIndex = 33;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::AppMusic.Resource.bgSearch;
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Controls.Add(this.btnBack);
            this.panel6.Controls.Add(this.tbSearch);
            this.panel6.Controls.Add(this.cbSearch);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(944, 70);
            this.panel6.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::AppMusic.Resource.btnSearch;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.Location = new System.Drawing.Point(861, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // fPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppMusic.Resource.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 581);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnPre;
        private Button btnNext;
        private Button btnPlay;
        private Label lbSongPre;
        private Label lbSongNext;
        private Label lbSongNow;
        private TextBox tbSearch;
        private Button btnBack;
        private Button btnRandom;
        private ComboBox cbSearch;
        private Button btnUp;
        private Button btnDown;
        private Label lbVolume;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button btnSearch;
    }
}

