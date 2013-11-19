namespace TubeQueue
{
    partial class YoutubeWebsiteControls
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
            this.grab_url_of_video = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grab_url_of_video
            // 
            this.grab_url_of_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grab_url_of_video.ForeColor = System.Drawing.Color.Red;
            this.grab_url_of_video.Location = new System.Drawing.Point(12, 12);
            this.grab_url_of_video.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grab_url_of_video.Name = "grab_url_of_video";
            this.grab_url_of_video.Size = new System.Drawing.Size(140, 23);
            this.grab_url_of_video.TabIndex = 32;
            this.grab_url_of_video.Text = "Add Video to Queue";
            this.grab_url_of_video.UseVisualStyleBackColor = true;
            this.grab_url_of_video.Click += new System.EventHandler(this.grab_url_of_video_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Blue;
            this.button8.Image = global::TubeQueue.Properties.Resources.min;
            this.button8.Location = new System.Drawing.Point(158, 13);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 22);
            this.button8.TabIndex = 33;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // YoutubeWebsiteControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 45);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.grab_url_of_video);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YoutubeWebsiteControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controls";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.YoutubeWebsiteControls_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button grab_url_of_video;
        private System.Windows.Forms.Button button8;
    }
}