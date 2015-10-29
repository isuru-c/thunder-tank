namespace Client
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
            this.UpButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.JoinButton = new System.Windows.Forms.Button();
            this.ShootButton = new System.Windows.Forms.Button();
            this.mp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mp)).BeginInit();
            this.SuspendLayout();
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(601, 384);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(72, 34);
            this.UpButton.TabIndex = 0;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(673, 424);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(72, 34);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(527, 424);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(72, 34);
            this.LeftButton.TabIndex = 2;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(601, 464);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(72, 34);
            this.DownButton.TabIndex = 3;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // JoinButton
            // 
            this.JoinButton.Location = new System.Drawing.Point(601, 330);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(72, 34);
            this.JoinButton.TabIndex = 4;
            this.JoinButton.Text = "Join";
            this.JoinButton.UseVisualStyleBackColor = true;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // ShootButton
            // 
            this.ShootButton.Location = new System.Drawing.Point(601, 424);
            this.ShootButton.Name = "ShootButton";
            this.ShootButton.Size = new System.Drawing.Size(72, 34);
            this.ShootButton.TabIndex = 5;
            this.ShootButton.Text = "Shoot";
            this.ShootButton.UseVisualStyleBackColor = true;
            this.ShootButton.Click += new System.EventHandler(this.ShootButton_Click);
            // 
            // mp
            // 
            this.mp.Location = new System.Drawing.Point(12, 12);
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(500, 500);
            this.mp.TabIndex = 6;
            this.mp.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 516);
            this.Controls.Add(this.mp);
            this.Controls.Add(this.ShootButton);
            this.Controls.Add(this.JoinButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.UpButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.mp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button JoinButton;
        private System.Windows.Forms.Button ShootButton;
        private System.Windows.Forms.PictureBox mp;
    }
}

