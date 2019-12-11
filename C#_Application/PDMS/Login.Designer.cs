namespace PDMS
{
    
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordEnter = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.IDCard_button = new System.Windows.Forms.Button();
            this.ECard_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(180)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.PasswordEnter);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Login_button);
            this.panel1.Controls.Add(this.IDCard_button);
            this.panel1.Controls.Add(this.ECard_button);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(304, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 477);
            this.panel1.TabIndex = 2;
            // 
            // PasswordEnter
            // 
            this.PasswordEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(180)))), ((int)(((byte)(183)))));
            this.PasswordEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.PasswordEnter.Location = new System.Drawing.Point(44, 197);
            this.PasswordEnter.Name = "PasswordEnter";
            this.PasswordEnter.Size = new System.Drawing.Size(223, 26);

            this.PasswordEnter.TabIndex = 10;
            // 
            // Username
            // 


            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(180)))), ((int)(((byte)(183)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Location = new System.Drawing.Point(13, 98);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(232, 26);


            this.Username.TabIndex = 9;
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.Gray;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_button.Location = new System.Drawing.Point(86, 210);
            this.Login_button.Margin = new System.Windows.Forms.Padding(2);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(76, 29);
            this.Login_button.TabIndex = 8;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // IDCard_button
            // 
            this.IDCard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(133)))));
            this.IDCard_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IDCard_button.Location = new System.Drawing.Point(41, 392);
            this.IDCard_button.Margin = new System.Windows.Forms.Padding(2);
            this.IDCard_button.Name = "IDCard_button";
            this.IDCard_button.Size = new System.Drawing.Size(166, 43);
            this.IDCard_button.TabIndex = 5;
            this.IDCard_button.Text = "ID-Card";
            this.IDCard_button.UseVisualStyleBackColor = false;
            this.IDCard_button.Click += new System.EventHandler(this.IDCard_button_Click);
            // 
            // ECard_button
            // 
            this.ECard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(133)))));
            this.ECard_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ECard_button.Location = new System.Drawing.Point(41, 329);
            this.ECard_button.Margin = new System.Windows.Forms.Padding(2);
            this.ECard_button.Name = "ECard_button";
            this.ECard_button.Size = new System.Drawing.Size(166, 43);
            this.ECard_button.TabIndex = 4;
            this.ECard_button.Text = "E-Card";
            this.ECard_button.UseVisualStyleBackColor = false;
            this.ECard_button.Click += new System.EventHandler(this.ECard_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "or connect with";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(29, 137);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(82, 11);
            this.Welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(91, 24);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome";


            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);


            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(855, 469);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button IDCard_button;
        private System.Windows.Forms.Button ECard_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TextBox PasswordEnter;
        private System.Windows.Forms.TextBox Username;
    }
}