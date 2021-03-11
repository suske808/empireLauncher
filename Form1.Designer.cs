
namespace EmpireLauncher
{
    partial class EmpireLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpireLauncher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.joinButton = new System.Windows.Forms.Button();
            this.DiscordButton = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EmpireLauncher.Properties.Resources.empirePic;
            this.pictureBox1.Location = new System.Drawing.Point(122, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 252);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // joinButton
            // 
            this.joinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinButton.Location = new System.Drawing.Point(186, 304);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(123, 64);
            this.joinButton.TabIndex = 2;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // DiscordButton
            // 
            this.DiscordButton.BackColor = System.Drawing.Color.Transparent;
            this.DiscordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DiscordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscordButton.Image = global::EmpireLauncher.Properties.Resources.discordhd;
            this.DiscordButton.Location = new System.Drawing.Point(-3, 550);
            this.DiscordButton.Name = "DiscordButton";
            this.DiscordButton.Size = new System.Drawing.Size(73, 73);
            this.DiscordButton.TabIndex = 4;
            this.DiscordButton.Text = "-";
            this.DiscordButton.UseVisualStyleBackColor = false;
            this.DiscordButton.Click += new System.EventHandler(this.DiscordButton_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Image = global::EmpireLauncher.Properties.Resources.github;
            this.Button1.Location = new System.Drawing.Point(76, 550);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(73, 73);
            this.Button1.TabIndex = 5;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EmpireLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::EmpireLauncher.Properties.Resources._7mM9R50;
            this.ClientSize = new System.Drawing.Size(497, 622);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.DiscordButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(513, 661);
            this.MinimumSize = new System.Drawing.Size(513, 661);
            this.Name = "EmpireLauncher";
            this.Text = "Empire";
            this.Load += new System.EventHandler(this.EmpireLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button DiscordButton;
        private System.Windows.Forms.Button Button1;
    }
}

