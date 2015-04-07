﻿namespace DeleteLater
{
    partial class TamagotchiMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TamagotchiMainForm));
            this.CreateAnimal = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.loadGameButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.petPictureBox = new System.Windows.Forms.PictureBox();
            this.energyStatusBar = new System.Windows.Forms.ProgressBar();
            this.feedButton = new System.Windows.Forms.Button();
            this.hygieneStatusBar = new System.Windows.Forms.ProgressBar();
            this.cleanButton = new System.Windows.Forms.Button();
            this.happynessStatusBar = new System.Windows.Forms.ProgressBar();
            this.playButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.newPetMenu = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaleButton = new System.Windows.Forms.RadioButton();
            this.FemaleButton = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.chooseFoodDropComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
            this.newPetMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateAnimal
            // 
            this.CreateAnimal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateAnimal.Enabled = false;
            this.CreateAnimal.Location = new System.Drawing.Point(286, 398);
            this.CreateAnimal.Name = "CreateAnimal";
            this.CreateAnimal.Size = new System.Drawing.Size(75, 23);
            this.CreateAnimal.TabIndex = 0;
            this.CreateAnimal.Text = "Create";
            this.CreateAnimal.UseVisualStyleBackColor = true;
            this.CreateAnimal.Visible = false;
            this.CreateAnimal.Click += new System.EventHandler(this.CreateAnimal_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newGameButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.newGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGameButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameButton.ForeColor = System.Drawing.Color.Navy;
            this.newGameButton.Location = new System.Drawing.Point(145, 61);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(341, 47);
            this.newGameButton.TabIndex = 4;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.NewGameMenu);
            this.newGameButton.MouseEnter += new System.EventHandler(this.NewGameButton_MouseEnter);
            this.newGameButton.MouseLeave += new System.EventHandler(this.NewGameButton_MouseLeave);
            // 
            // loadGameButton
            // 
            this.loadGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadGameButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.loadGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadGameButton.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.loadGameButton.ForeColor = System.Drawing.Color.Navy;
            this.loadGameButton.Location = new System.Drawing.Point(145, 172);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(341, 47);
            this.loadGameButton.TabIndex = 5;
            this.loadGameButton.Text = "Load Game";
            this.loadGameButton.UseVisualStyleBackColor = false;
            this.loadGameButton.Click += new System.EventHandler(this.LoadGame);
            this.loadGameButton.MouseEnter += new System.EventHandler(this.LoadGameButton_MouseEnter);
            this.loadGameButton.MouseLeave += new System.EventHandler(this.LoadGameButton_MouseLeave);
            // 
            // exitGameButton
            // 
            this.exitGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitGameButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exitGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitGameButton.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.exitGameButton.ForeColor = System.Drawing.Color.Navy;
            this.exitGameButton.Location = new System.Drawing.Point(145, 280);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(341, 47);
            this.exitGameButton.TabIndex = 6;
            this.exitGameButton.Text = "Exit";
            this.exitGameButton.UseVisualStyleBackColor = false;
            this.exitGameButton.Click += new System.EventHandler(this.ExitGame);
            this.exitGameButton.MouseEnter += new System.EventHandler(this.ExitGameButton_MouseEnter);
            this.exitGameButton.MouseLeave += new System.EventHandler(this.ExitGameButton_MouseLeave);
            // 
            // petPictureBox
            // 
            this.petPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("petPictureBox.BackgroundImage")));
            this.petPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.petPictureBox.Location = new System.Drawing.Point(261, 61);
            this.petPictureBox.Name = "petPictureBox";
            this.petPictureBox.Size = new System.Drawing.Size(113, 128);
            this.petPictureBox.TabIndex = 7;
            this.petPictureBox.TabStop = false;
            this.petPictureBox.Visible = false;
            // 
            // energyStatusBar
            // 
            this.energyStatusBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.energyStatusBar.ForeColor = System.Drawing.Color.Green;
            this.energyStatusBar.Location = new System.Drawing.Point(39, 388);
            this.energyStatusBar.Name = "energyStatusBar";
            this.energyStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.energyStatusBar.Size = new System.Drawing.Size(100, 33);
            this.energyStatusBar.Step = 5;
            this.energyStatusBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.energyStatusBar.TabIndex = 1;
            this.energyStatusBar.Value = 100;
            this.energyStatusBar.Visible = false;
            // 
            // feedButton
            // 
            this.feedButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.feedButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.feedButton.Enabled = false;
            this.feedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.feedButton.Location = new System.Drawing.Point(45, 333);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(75, 23);
            this.feedButton.TabIndex = 0;
            this.feedButton.Text = "FEED";
            this.feedButton.UseVisualStyleBackColor = false;
            this.feedButton.Visible = false;
            this.feedButton.Click += new System.EventHandler(this.FeedClick);
            // 
            // hygieneStatusBar
            // 
            this.hygieneStatusBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hygieneStatusBar.ForeColor = System.Drawing.Color.Green;
            this.hygieneStatusBar.Location = new System.Drawing.Point(274, 388);
            this.hygieneStatusBar.Name = "hygieneStatusBar";
            this.hygieneStatusBar.Size = new System.Drawing.Size(100, 33);
            this.hygieneStatusBar.Step = 5;
            this.hygieneStatusBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.hygieneStatusBar.TabIndex = 2;
            this.hygieneStatusBar.Value = 100;
            this.hygieneStatusBar.Visible = false;
            // 
            // cleanButton
            // 
            this.cleanButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cleanButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cleanButton.Enabled = false;
            this.cleanButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cleanButton.Location = new System.Drawing.Point(286, 342);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 1;
            this.cleanButton.Text = "CLEAN";
            this.cleanButton.UseVisualStyleBackColor = false;
            this.cleanButton.Visible = false;
            this.cleanButton.Click += new System.EventHandler(this.CleanClick);
            // 
            // happynessStatusBar
            // 
            this.happynessStatusBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.happynessStatusBar.ForeColor = System.Drawing.Color.Green;
            this.happynessStatusBar.Location = new System.Drawing.Point(491, 388);
            this.happynessStatusBar.Name = "happynessStatusBar";
            this.happynessStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.happynessStatusBar.Size = new System.Drawing.Size(100, 33);
            this.happynessStatusBar.Step = 5;
            this.happynessStatusBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.happynessStatusBar.TabIndex = 3;
            this.happynessStatusBar.Value = 100;
            this.happynessStatusBar.Visible = false;
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.playButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.playButton.Enabled = false;
            this.playButton.Location = new System.Drawing.Point(502, 342);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Visible = false;
            this.playButton.Click += new System.EventHandler(this.PlayClick);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerTickEvents);
            // 
            // newPetMenu
            // 
            this.newPetMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newPetMenu.Controls.Add(this.groupBox1);
            this.newPetMenu.Controls.Add(this.comboBox1);
            this.newPetMenu.Controls.Add(this.petNameTextBox);
            this.newPetMenu.Enabled = false;
            this.newPetMenu.Location = new System.Drawing.Point(222, 71);
            this.newPetMenu.Name = "newPetMenu";
            this.newPetMenu.Size = new System.Drawing.Size(210, 256);
            this.newPetMenu.TabIndex = 10;
            this.newPetMenu.TabStop = false;
            this.newPetMenu.Text = "Pet Characteristics";
            this.newPetMenu.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaleButton);
            this.groupBox1.Controls.Add(this.FemaleButton);
            this.groupBox1.Location = new System.Drawing.Point(52, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 90);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Checked = true;
            this.MaleButton.Enabled = false;
            this.MaleButton.Location = new System.Drawing.Point(28, 23);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(48, 17);
            this.MaleButton.TabIndex = 1;
            this.MaleButton.TabStop = true;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            this.MaleButton.Visible = false;
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Enabled = false;
            this.FemaleButton.Location = new System.Drawing.Point(28, 48);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleButton.TabIndex = 2;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            this.FemaleButton.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Tiger",
            "Elephant",
            "Eagle",
            "Fish"});
            this.comboBox1.Location = new System.Drawing.Point(52, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Pet Type";
            this.comboBox1.Visible = false;
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Enabled = false;
            this.petNameTextBox.Location = new System.Drawing.Point(39, 19);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.petNameTextBox.TabIndex = 0;
            this.petNameTextBox.Text = "Pet Name";
            this.petNameTextBox.Visible = false;
            // 
            // chooseFoodDropComboBox
            // 
            this.chooseFoodDropComboBox.Enabled = false;
            this.chooseFoodDropComboBox.FormattingEnabled = true;
            this.chooseFoodDropComboBox.Location = new System.Drawing.Point(10, 20);
            this.chooseFoodDropComboBox.Name = "chooseFoodDropComboBox";
            this.chooseFoodDropComboBox.Size = new System.Drawing.Size(121, 21);
            this.chooseFoodDropComboBox.TabIndex = 11;
            this.chooseFoodDropComboBox.Text = "FOOD LIST";
            this.chooseFoodDropComboBox.Visible = false;
            // 
            // TamagotchiMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(637, 472);
            this.Controls.Add(this.chooseFoodDropComboBox);
            this.Controls.Add(this.newPetMenu);
            this.Controls.Add(this.petPictureBox);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.loadGameButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.CreateAnimal);
            this.Controls.Add(this.feedButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.energyStatusBar);
            this.Controls.Add(this.hygieneStatusBar);
            this.Controls.Add(this.happynessStatusBar);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "TamagotchiMainForm";
            this.Text = "Tamagochi v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).EndInit();
            this.newPetMenu.ResumeLayout(false);
            this.newPetMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateAnimal;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button loadGameButton;
        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.PictureBox petPictureBox;
        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.ProgressBar energyStatusBar;
        private System.Windows.Forms.ProgressBar hygieneStatusBar;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ProgressBar happynessStatusBar;
        private System.Windows.Forms.GroupBox newPetMenu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton FemaleButton;
        private System.Windows.Forms.RadioButton MaleButton;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox chooseFoodDropComboBox;
    }
}