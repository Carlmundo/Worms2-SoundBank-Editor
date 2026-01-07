
namespace DWARand
{
    partial class RandomizeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomizeDialog));
            this.titleLbl = new System.Windows.Forms.Label();
            this.seedBox = new System.Windows.Forms.TextBox();
            this.seedLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.replaceChkBox = new System.Windows.Forms.CheckBox();
            this.sndbankListbox = new System.Windows.Forms.CheckedListBox();
            this.randomizeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shareBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.selallBtn = new System.Windows.Forms.Button();
            this.deselallBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.titleLbl.Size = new System.Drawing.Size(90, 20);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Randomize";
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(53, 86);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(100, 20);
            this.seedBox.TabIndex = 5;
            // 
            // seedLbl
            // 
            this.seedLbl.AutoSize = true;
            this.seedLbl.ForeColor = System.Drawing.Color.White;
            this.seedLbl.Location = new System.Drawing.Point(12, 89);
            this.seedLbl.Name = "seedLbl";
            this.seedLbl.Size = new System.Drawing.Size(35, 13);
            this.seedLbl.TabIndex = 6;
            this.seedLbl.Text = "Seed:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(12, 63);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 7;
            this.nameLbl.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(53, 60);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 8;
            // 
            // replaceChkBox
            // 
            this.replaceChkBox.AutoSize = true;
            this.replaceChkBox.ForeColor = System.Drawing.Color.White;
            this.replaceChkBox.Location = new System.Drawing.Point(36, 112);
            this.replaceChkBox.Name = "replaceChkBox";
            this.replaceChkBox.Size = new System.Drawing.Size(104, 17);
            this.replaceChkBox.TabIndex = 9;
            this.replaceChkBox.Text = "Replace if Exists";
            this.replaceChkBox.UseVisualStyleBackColor = true;
            // 
            // sndbankListbox
            // 
            this.sndbankListbox.FormattingEnabled = true;
            this.sndbankListbox.Location = new System.Drawing.Point(172, 56);
            this.sndbankListbox.Name = "sndbankListbox";
            this.sndbankListbox.Size = new System.Drawing.Size(163, 199);
            this.sndbankListbox.TabIndex = 10;
            // 
            // randomizeBtn
            // 
            this.randomizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomizeBtn.ForeColor = System.Drawing.Color.White;
            this.randomizeBtn.Location = new System.Drawing.Point(262, 4);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(75, 23);
            this.randomizeBtn.TabIndex = 11;
            this.randomizeBtn.Text = "Randomize!";
            this.randomizeBtn.UseVisualStyleBackColor = true;
            this.randomizeBtn.Click += new System.EventHandler(this.randomizeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.shareBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.randomizeBtn);
            this.panel1.Location = new System.Drawing.Point(-2, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 35);
            this.panel1.TabIndex = 12;
            // 
            // shareBtn
            // 
            this.shareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shareBtn.ForeColor = System.Drawing.Color.White;
            this.shareBtn.Location = new System.Drawing.Point(181, 4);
            this.shareBtn.Name = "shareBtn";
            this.shareBtn.Size = new System.Drawing.Size(75, 23);
            this.shareBtn.TabIndex = 14;
            this.shareBtn.Text = "Share";
            this.shareBtn.UseVisualStyleBackColor = true;
            this.shareBtn.Click += new System.EventHandler(this.shareBtn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selallBtn
            // 
            this.selallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selallBtn.ForeColor = System.Drawing.Color.White;
            this.selallBtn.Location = new System.Drawing.Point(10, 232);
            this.selallBtn.Name = "selallBtn";
            this.selallBtn.Size = new System.Drawing.Size(75, 23);
            this.selallBtn.TabIndex = 12;
            this.selallBtn.Text = "Select all";
            this.selallBtn.UseVisualStyleBackColor = true;
            this.selallBtn.Click += new System.EventHandler(this.selallBtn_Click);
            // 
            // deselallBtn
            // 
            this.deselallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deselallBtn.ForeColor = System.Drawing.Color.White;
            this.deselallBtn.Location = new System.Drawing.Point(91, 232);
            this.deselallBtn.Name = "deselallBtn";
            this.deselallBtn.Size = new System.Drawing.Size(75, 23);
            this.deselallBtn.TabIndex = 13;
            this.deselallBtn.Text = "Deselect all";
            this.deselallBtn.UseVisualStyleBackColor = true;
            this.deselallBtn.Click += new System.EventHandler(this.deselallBtn_Click);
            // 
            // previewBtn
            // 
            this.previewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previewBtn.ForeColor = System.Drawing.Color.White;
            this.previewBtn.Location = new System.Drawing.Point(91, 203);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(75, 23);
            this.previewBtn.TabIndex = 14;
            this.previewBtn.Text = "Preview";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // RandomizeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(94)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(347, 296);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.deselallBtn);
            this.Controls.Add(this.selallBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sndbankListbox);
            this.Controls.Add(this.replaceChkBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.seedLbl);
            this.Controls.Add(this.seedBox);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RandomizeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randomize";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RandomizeDialog_FormClosed);
            this.Load += new System.EventHandler(this.RandomizeDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox seedBox;
        private System.Windows.Forms.Label seedLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.CheckBox replaceChkBox;
        private System.Windows.Forms.CheckedListBox sndbankListbox;
        private System.Windows.Forms.Button randomizeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button selallBtn;
        private System.Windows.Forms.Button deselallBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button shareBtn;
        private System.Windows.Forms.Button previewBtn;
    }
}