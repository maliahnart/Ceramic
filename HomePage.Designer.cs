namespace Cera
{
    partial class HomePage
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
            this.btn_Signout = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btn_Signout
            // 
            this.btn_Signout.AutoRoundedCorners = true;
            this.btn_Signout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Signout.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Signout.BorderRadius = 21;
            this.btn_Signout.BorderThickness = 2;
            this.btn_Signout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Signout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Signout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Signout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Signout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btn_Signout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Signout.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_Signout.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btn_Signout.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Signout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Signout.Location = new System.Drawing.Point(596, 379);
            this.btn_Signout.Name = "btn_Signout";
            this.btn_Signout.PressedColor = System.Drawing.Color.Bisque;
            this.btn_Signout.Size = new System.Drawing.Size(143, 45);
            this.btn_Signout.TabIndex = 35;
            this.btn_Signout.Text = "Sign Out";
            this.btn_Signout.Click += new System.EventHandler(this.btn_Signout_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Signout);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Signout;
    }
}