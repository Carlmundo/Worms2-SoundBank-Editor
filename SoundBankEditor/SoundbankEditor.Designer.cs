
namespace DWARand
{
    partial class SoundbankEditor
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundbankEditor));
            this.titleLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveasBtn = new System.Windows.Forms.Button();
            this.sndbankBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.setBtn = new System.Windows.Forms.Button();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.finishBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.ttsBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dSoundListbox = new DWARand.UI.DSoundListbox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(10, 14);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(137, 20);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Soundbank Editor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.saveasBtn);
            this.groupBox1.Controls.Add(this.sndbankBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(186, 46);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveasBtn
            // 
            this.saveasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveasBtn.ForeColor = System.Drawing.Color.White;
            this.saveasBtn.Location = new System.Drawing.Point(65, 46);
            this.saveasBtn.Name = "saveasBtn";
            this.saveasBtn.Size = new System.Drawing.Size(75, 23);
            this.saveasBtn.TabIndex = 13;
            this.saveasBtn.Text = "Save as";
            this.saveasBtn.UseVisualStyleBackColor = true;
            this.saveasBtn.Click += new System.EventHandler(this.saveasBtn_Click);
            // 
            // sndbankBox
            // 
            this.sndbankBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sndbankBox.FormattingEnabled = true;
            this.sndbankBox.Location = new System.Drawing.Point(127, 19);
            this.sndbankBox.Name = "sndbankBox";
            this.sndbankBox.Size = new System.Drawing.Size(134, 21);
            this.sndbankBox.TabIndex = 4;
            this.sndbankBox.SelectedIndexChanged += new System.EventHandler(this.sndbankBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scheme";
            // 
            // playBtn
            // 
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Location = new System.Drawing.Point(271, 160);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 23);
            this.playBtn.TabIndex = 15;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.ForeColor = System.Drawing.Color.White;
            this.stopBtn.Location = new System.Drawing.Point(271, 189);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 16;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // setBtn
            // 
            this.setBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setBtn.ForeColor = System.Drawing.Color.White;
            this.setBtn.Location = new System.Drawing.Point(271, 218);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(75, 23);
            this.setBtn.TabIndex = 17;
            this.setBtn.Text = "Set";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Enabled = false;
            this.restoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreBtn.ForeColor = System.Drawing.Color.White;
            this.restoreBtn.Location = new System.Drawing.Point(271, 247);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(75, 23);
            this.restoreBtn.TabIndex = 18;
            this.restoreBtn.Text = "Restore";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishBtn.ForeColor = System.Drawing.Color.White;
            this.finishBtn.Location = new System.Drawing.Point(271, 333);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(75, 23);
            this.finishBtn.TabIndex = 19;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.ForeColor = System.Drawing.Color.White;
            this.helpBtn.Location = new System.Drawing.Point(271, 276);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(75, 23);
            this.helpBtn.TabIndex = 22;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // ttsBtn
            // 
            this.ttsBtn.Enabled = false;
            this.ttsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ttsBtn.ForeColor = System.Drawing.Color.White;
            this.ttsBtn.Location = new System.Drawing.Point(271, 305);
            this.ttsBtn.Name = "ttsBtn";
            this.ttsBtn.Size = new System.Drawing.Size(75, 23);
            this.ttsBtn.TabIndex = 23;
            this.ttsBtn.Text = "TTS";
            this.ttsBtn.UseVisualStyleBackColor = true;
            this.ttsBtn.Click += new System.EventHandler(this.ttsBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dSoundListbox
            // 
            this.dSoundListbox.BackColor = System.Drawing.Color.Black;
            this.dSoundListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dSoundListbox.FormattingEnabled = true;
            this.dSoundListbox.ItemHeight = 16;
            this.dSoundListbox.Location = new System.Drawing.Point(12, 160);
            this.dSoundListbox.Name = "dSoundListbox";
            this.dSoundListbox.Size = new System.Drawing.Size(251, 196);
            this.dSoundListbox.TabIndex = 21;
            this.dSoundListbox.SelectedIndexChanged += new System.EventHandler(this.dSoundListbox_SelectedIndexChanged);
            // 
            // SoundbankEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(94)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(358, 369);
            this.Controls.Add(this.ttsBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.dSoundListbox);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SoundbankEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soundbank Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sndbankBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveasBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.Button finishBtn;
        private UI.DSoundListbox dSoundListbox;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button ttsBtn;
    }
}

