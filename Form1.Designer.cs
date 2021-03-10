
namespace KronosLauncher
{
    partial class KronosLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KronosLauncher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.joinButton = new System.Windows.Forms.Button();
            this.instagramButton = new System.Windows.Forms.Button();
            this.discordButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KronosLauncher.Properties.Resources.kronosPic;
            this.pictureBox1.Location = new System.Drawing.Point(200, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // joinButton
            // 
            this.joinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinButton.Location = new System.Drawing.Point(200, 304);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(98, 49);
            this.joinButton.TabIndex = 2;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // instagramButton
            // 
            this.instagramButton.BackColor = System.Drawing.Color.Transparent;
            this.instagramButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.instagramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instagramButton.Image = global::KronosLauncher.Properties.Resources.instagram;
            this.instagramButton.Location = new System.Drawing.Point(-1, 551);
            this.instagramButton.Name = "instagramButton";
            this.instagramButton.Size = new System.Drawing.Size(73, 73);
            this.instagramButton.TabIndex = 3;
            this.instagramButton.UseVisualStyleBackColor = false;
            this.instagramButton.Click += new System.EventHandler(this.instagramButton_Click);
            // 
            // discordButton
            // 
            this.discordButton.BackColor = System.Drawing.Color.Transparent;
            this.discordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.discordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discordButton.Image = global::KronosLauncher.Properties.Resources.discordhd;
            this.discordButton.Location = new System.Drawing.Point(78, 551);
            this.discordButton.Name = "discordButton";
            this.discordButton.Size = new System.Drawing.Size(73, 73);
            this.discordButton.TabIndex = 4;
            this.discordButton.UseVisualStyleBackColor = false;
            this.discordButton.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::KronosLauncher.Properties.Resources.github;
            this.button1.Location = new System.Drawing.Point(424, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 73);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KronosLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::KronosLauncher.Properties.Resources._7mM9R50;
            this.ClientSize = new System.Drawing.Size(497, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.discordButton);
            this.Controls.Add(this.instagramButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(513, 661);
            this.MinimumSize = new System.Drawing.Size(513, 661);
            this.Name = "KronosLauncher";
            this.Text = "Kronos Launcher";
            this.Load += new System.EventHandler(this.KronosLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button instagramButton;
        private System.Windows.Forms.Button discordButton;
        private System.Windows.Forms.Button button1;
    }
}

