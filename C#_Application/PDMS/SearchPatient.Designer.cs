namespace PDMS
{
    partial class SearchPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPatient));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MaximizeIcon = new System.Windows.Forms.PictureBox();
            this.MinimizeIcon = new System.Windows.Forms.PictureBox();
            this.CloseIcon = new System.Windows.Forms.PictureBox();
            this.RestoreDonwIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDonwIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(129)))), ((int)(((byte)(133)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(555, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownHeight = 500;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Items.AddRange(new object[] {
            "Mariana Afonso",
            "Mariana Rocha",
            "Mariana Ferreira",
            "Mariana Rodrigues",
            "Laura Rodrigues",
            "Laura Pires"});
            this.comboBox1.Location = new System.Drawing.Point(182, 306);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(354, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MaximizeIcon
            // 
            this.MaximizeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeIcon.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeIcon.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeIcon.Image")));
            this.MaximizeIcon.Location = new System.Drawing.Point(835, 12);
            this.MaximizeIcon.Name = "MaximizeIcon";
            this.MaximizeIcon.Size = new System.Drawing.Size(17, 19);
            this.MaximizeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizeIcon.TabIndex = 10;
            this.MaximizeIcon.TabStop = false;
            // 
            // MinimizeIcon
            // 
            this.MinimizeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeIcon.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeIcon.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeIcon.Image")));
            this.MinimizeIcon.Location = new System.Drawing.Point(812, 12);
            this.MinimizeIcon.Name = "MinimizeIcon";
            this.MinimizeIcon.Size = new System.Drawing.Size(17, 19);
            this.MinimizeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeIcon.TabIndex = 8;
            this.MinimizeIcon.TabStop = false;
            // 
            // CloseIcon
            // 
            this.CloseIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseIcon.BackColor = System.Drawing.Color.Transparent;
            this.CloseIcon.Image = ((System.Drawing.Image)(resources.GetObject("CloseIcon.Image")));
            this.CloseIcon.Location = new System.Drawing.Point(858, 12);
            this.CloseIcon.Name = "CloseIcon";
            this.CloseIcon.Size = new System.Drawing.Size(17, 19);
            this.CloseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseIcon.TabIndex = 9;
            this.CloseIcon.TabStop = false;
            // 
            // RestoreDonwIcon
            // 
            this.RestoreDonwIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreDonwIcon.BackColor = System.Drawing.Color.Transparent;
            this.RestoreDonwIcon.Image = ((System.Drawing.Image)(resources.GetObject("RestoreDonwIcon.Image")));
            this.RestoreDonwIcon.Location = new System.Drawing.Point(835, 12);
            this.RestoreDonwIcon.Name = "RestoreDonwIcon";
            this.RestoreDonwIcon.Size = new System.Drawing.Size(17, 19);
            this.RestoreDonwIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RestoreDonwIcon.TabIndex = 11;
            this.RestoreDonwIcon.TabStop = false;
            this.RestoreDonwIcon.Visible = false;
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 628);
            this.Controls.Add(this.MaximizeIcon);
            this.Controls.Add(this.MinimizeIcon);
            this.Controls.Add(this.CloseIcon);
            this.Controls.Add(this.RestoreDonwIcon);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchPatient";
            this.Text = "SearchPatient";
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDonwIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox MaximizeIcon;
        private System.Windows.Forms.PictureBox MinimizeIcon;
        private System.Windows.Forms.PictureBox CloseIcon;
        private System.Windows.Forms.PictureBox RestoreDonwIcon;
    }
}