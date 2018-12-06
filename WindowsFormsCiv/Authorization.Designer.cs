namespace WindowsFormsCiv
{
    partial class Authorization
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
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.tbCivilzation = new System.Windows.Forms.TextBox();
            this.bSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNickname
            // 
            this.tbNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNickname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNickname.Location = new System.Drawing.Point(12, 28);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(270, 24);
            this.tbNickname.TabIndex = 0;
            this.tbNickname.Text = "Nickname";
            // 
            // tbCivilzation
            // 
            this.tbCivilzation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCivilzation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCivilzation.Location = new System.Drawing.Point(12, 83);
            this.tbCivilzation.Name = "tbCivilzation";
            this.tbCivilzation.Size = new System.Drawing.Size(270, 24);
            this.tbCivilzation.TabIndex = 1;
            this.tbCivilzation.Text = "Youre Civilization";
            // 
            // bSignIn
            // 
            this.bSignIn.Location = new System.Drawing.Point(106, 123);
            this.bSignIn.Name = "bSignIn";
            this.bSignIn.Size = new System.Drawing.Size(79, 29);
            this.bSignIn.TabIndex = 2;
            this.bSignIn.Text = "Sign In";
            this.bSignIn.UseVisualStyleBackColor = true;
            this.bSignIn.Click += new System.EventHandler(this.bSignIn_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 164);
            this.Controls.Add(this.bSignIn);
            this.Controls.Add(this.tbCivilzation);
            this.Controls.Add(this.tbNickname);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.TextBox tbCivilzation;
        private System.Windows.Forms.Button bSignIn;
    }
}