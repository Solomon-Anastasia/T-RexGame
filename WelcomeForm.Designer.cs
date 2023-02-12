
namespace T_RexGame
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.log_InButton = new System.Windows.Forms.Button();
            this.sign_UpButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.tRexLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // log_InButton
            // 
            this.log_InButton.BackColor = System.Drawing.Color.White;
            this.log_InButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.log_InButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_InButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.log_InButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_InButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_InButton.ForeColor = System.Drawing.Color.Black;
            this.log_InButton.Location = new System.Drawing.Point(76, 157);
            this.log_InButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.log_InButton.Name = "log_InButton";
            this.log_InButton.Size = new System.Drawing.Size(168, 46);
            this.log_InButton.TabIndex = 1;
            this.log_InButton.Text = "Log In";
            this.log_InButton.UseVisualStyleBackColor = false;
            this.log_InButton.Click += new System.EventHandler(this.log_InButton_Click);
            // 
            // sign_UpButton
            // 
            this.sign_UpButton.BackColor = System.Drawing.Color.White;
            this.sign_UpButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sign_UpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sign_UpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.sign_UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_UpButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_UpButton.ForeColor = System.Drawing.Color.Black;
            this.sign_UpButton.Location = new System.Drawing.Point(76, 237);
            this.sign_UpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sign_UpButton.Name = "sign_UpButton";
            this.sign_UpButton.Size = new System.Drawing.Size(168, 46);
            this.sign_UpButton.TabIndex = 2;
            this.sign_UpButton.Text = "Sign Up";
            this.sign_UpButton.UseVisualStyleBackColor = false;
            this.sign_UpButton.Click += new System.EventHandler(this.sign_UpButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.copyrightLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.ForeColor = System.Drawing.Color.White;
            this.copyrightLabel.Location = new System.Drawing.Point(13, 317);
            this.copyrightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(145, 16);
            this.copyrightLabel.TabIndex = 3;
            this.copyrightLabel.Text = "@Solomon Anastasia";
            // 
            // tRexLabel
            // 
            this.tRexLabel.AutoSize = true;
            this.tRexLabel.BackColor = System.Drawing.Color.Transparent;
            this.tRexLabel.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tRexLabel.Location = new System.Drawing.Point(35, 68);
            this.tRexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tRexLabel.Name = "tRexLabel";
            this.tRexLabel.Size = new System.Drawing.Size(142, 45);
            this.tRexLabel.TabIndex = 4;
            this.tRexLabel.Text = "T-Rex";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::T_RexGame.Properties.Resources.T_Rex_Welcome;
            this.pictureBox1.Location = new System.Drawing.Point(205, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(351, 354);
            this.Controls.Add(this.tRexLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.sign_UpButton);
            this.Controls.Add(this.log_InButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log_InButton;
        private System.Windows.Forms.Button sign_UpButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label tRexLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}