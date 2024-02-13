namespace DinoGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pointLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.FlowerPictureBox = new System.Windows.Forms.PictureBox();
            this.DinoPictureBox = new System.Windows.Forms.PictureBox();
            this.sandPcitureBox = new System.Windows.Forms.PictureBox();
            this.gamOverPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FlowerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DinoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandPcitureBox)).BeginInit();
            this.gamOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pointLabel
            // 
            resources.ApplyResources(this.pointLabel, "pointLabel");
            this.pointLabel.Name = "pointLabel";
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // FlowerPictureBox
            // 
            this.FlowerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.FlowerPictureBox.Image = global::DinoGame.Properties.Resources.iris;
            resources.ApplyResources(this.FlowerPictureBox, "FlowerPictureBox");
            this.FlowerPictureBox.Name = "FlowerPictureBox";
            this.FlowerPictureBox.TabStop = false;
            // 
            // DinoPictureBox
            // 
            this.DinoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.DinoPictureBox.Image = global::DinoGame.Properties.Resources.DinoStart;
            resources.ApplyResources(this.DinoPictureBox, "DinoPictureBox");
            this.DinoPictureBox.Name = "DinoPictureBox";
            this.DinoPictureBox.TabStop = false;
            // 
            // sandPcitureBox
            // 
            resources.ApplyResources(this.sandPcitureBox, "sandPcitureBox");
            this.sandPcitureBox.Name = "sandPcitureBox";
            this.sandPcitureBox.TabStop = false;
            // 
            // gamOverPanel
            // 
            this.gamOverPanel.Controls.Add(this.scoreLabel);
            this.gamOverPanel.Controls.Add(this.restartBtn);
            this.gamOverPanel.Controls.Add(this.label1);
            resources.ApplyResources(this.gamOverPanel, "gamOverPanel");
            this.gamOverPanel.Name = "gamOverPanel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // restartBtn
            // 
            resources.ApplyResources(this.restartBtn, "restartBtn");
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // scoreLabel
            // 
            resources.ApplyResources(this.scoreLabel, "scoreLabel");
            this.scoreLabel.Name = "scoreLabel";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gamOverPanel);
            this.Controls.Add(this.FlowerPictureBox);
            this.Controls.Add(this.DinoPictureBox);
            this.Controls.Add(this.sandPcitureBox);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.FlowerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DinoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandPcitureBox)).EndInit();
            this.gamOverPanel.ResumeLayout(false);
            this.gamOverPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox sandPcitureBox;
        private System.Windows.Forms.PictureBox DinoPictureBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox FlowerPictureBox;
        private System.Windows.Forms.Panel gamOverPanel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label label1;
    }
}

