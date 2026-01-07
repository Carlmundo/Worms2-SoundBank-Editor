
namespace DWARand
{
    partial class HelpDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpDialog));
            this.titleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bankedBtn = new System.Windows.Forms.Button();
            this.dailyBtn = new System.Windows.Forms.Button();
            this.mainBtn = new System.Windows.Forms.Button();
            this.randHelp = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.contentPanel = new DWARand.UI.DPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(11, 15);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(42, 20);
            this.titleLbl.TabIndex = 5;
            this.titleLbl.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.bankedBtn);
            this.panel1.Controls.Add(this.dailyBtn);
            this.panel1.Controls.Add(this.mainBtn);
            this.panel1.Controls.Add(this.randHelp);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Location = new System.Drawing.Point(-2, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 375);
            this.panel1.TabIndex = 8;
            // 
            // bankedBtn
            // 
            this.bankedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bankedBtn.ForeColor = System.Drawing.Color.White;
            this.bankedBtn.Location = new System.Drawing.Point(9, 93);
            this.bankedBtn.Name = "bankedBtn";
            this.bankedBtn.Size = new System.Drawing.Size(75, 23);
            this.bankedBtn.TabIndex = 18;
            this.bankedBtn.Text = "Bank Editor";
            this.bankedBtn.UseVisualStyleBackColor = true;
            this.bankedBtn.Click += new System.EventHandler(this.bankedBtn_Click);
            // 
            // dailyBtn
            // 
            this.dailyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyBtn.ForeColor = System.Drawing.Color.White;
            this.dailyBtn.Location = new System.Drawing.Point(9, 64);
            this.dailyBtn.Name = "dailyBtn";
            this.dailyBtn.Size = new System.Drawing.Size(75, 23);
            this.dailyBtn.TabIndex = 17;
            this.dailyBtn.Text = "Daily";
            this.dailyBtn.UseVisualStyleBackColor = true;
            this.dailyBtn.Click += new System.EventHandler(this.dailyBtn_Click);
            // 
            // mainBtn
            // 
            this.mainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainBtn.ForeColor = System.Drawing.Color.White;
            this.mainBtn.Location = new System.Drawing.Point(10, 6);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(75, 23);
            this.mainBtn.TabIndex = 16;
            this.mainBtn.Text = "Launcher";
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // randHelp
            // 
            this.randHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randHelp.ForeColor = System.Drawing.Color.White;
            this.randHelp.Location = new System.Drawing.Point(9, 35);
            this.randHelp.Name = "randHelp";
            this.randHelp.Size = new System.Drawing.Size(75, 23);
            this.randHelp.TabIndex = 15;
            this.randHelp.Text = "Randomize";
            this.randHelp.UseVisualStyleBackColor = true;
            this.randHelp.Click += new System.EventHandler(this.randHelp_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(10, 341);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Close";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(91, 50);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(661, 369);
            this.contentPanel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(753, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // HelpDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HelpDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveBtn;
        private UI.DPanel contentPanel;
        private System.Windows.Forms.Button randHelp;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.Button dailyBtn;
        private System.Windows.Forms.Button bankedBtn;
    }
}