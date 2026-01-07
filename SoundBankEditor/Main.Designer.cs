
namespace DWARand
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.titleLbl = new System.Windows.Forms.Label();
            this.hintsLbl = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.PictureBox();
            this.bankeditorBtn = new System.Windows.Forms.PictureBox();
            this.dailyRandomizeBtn = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.PictureBox();
            this.randomizeBtn = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.helpBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankeditorBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyRandomizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(18, 26);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(147, 32);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "DWARand";
            // 
            // hintsLbl
            // 
            this.hintsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hintsLbl.AutoSize = true;
            this.hintsLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.hintsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hintsLbl.ForeColor = System.Drawing.Color.White;
            this.hintsLbl.Location = new System.Drawing.Point(15, 258);
            this.hintsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.hintsLbl.Name = "hintsLbl";
            this.hintsLbl.Size = new System.Drawing.Size(463, 29);
            this.hintsLbl.TabIndex = 5;
            this.hintsLbl.Text = "Hover your mouse over one of the buttons!";
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.helpBtn.Location = new System.Drawing.Point(568, 249);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(6);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(59, 59);
            this.helpBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpBtn.TabIndex = 10;
            this.helpBtn.TabStop = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            this.helpBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.helpBtn_MouseDown);
            this.helpBtn.MouseEnter += new System.EventHandler(this.helpBtn_MouseEnter);
            this.helpBtn.MouseLeave += new System.EventHandler(this.helpBtn_MouseLeave);
            // 
            // bankeditorBtn
            // 
            this.bankeditorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bankeditorBtn.Image = global::DWARand.Properties.Resources.soundbankicon;
            this.bankeditorBtn.Location = new System.Drawing.Point(337, 107);
            this.bankeditorBtn.Margin = new System.Windows.Forms.Padding(6);
            this.bankeditorBtn.Name = "bankeditorBtn";
            this.bankeditorBtn.Size = new System.Drawing.Size(117, 118);
            this.bankeditorBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bankeditorBtn.TabIndex = 9;
            this.bankeditorBtn.TabStop = false;
            this.bankeditorBtn.Click += new System.EventHandler(this.bankeditorBtn_Click);
            this.bankeditorBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bankeditorBtn_MouseDown);
            this.bankeditorBtn.MouseEnter += new System.EventHandler(this.bankeditorBtn_MouseEnter);
            this.bankeditorBtn.MouseLeave += new System.EventHandler(this.bankeditorBtn_MouseLeave);
            // 
            // dailyRandomizeBtn
            // 
            this.dailyRandomizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dailyRandomizeBtn.Image = global::DWARand.Properties.Resources.daily;
            this.dailyRandomizeBtn.Location = new System.Drawing.Point(174, 107);
            this.dailyRandomizeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.dailyRandomizeBtn.Name = "dailyRandomizeBtn";
            this.dailyRandomizeBtn.Size = new System.Drawing.Size(117, 118);
            this.dailyRandomizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dailyRandomizeBtn.TabIndex = 6;
            this.dailyRandomizeBtn.TabStop = false;
            this.dailyRandomizeBtn.Click += new System.EventHandler(this.dailyRandomizeBtn_Click);
            this.dailyRandomizeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dailyRandomizeBtn_MouseClick);
            this.dailyRandomizeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dailyRandomizeBtn_MouseDown);
            this.dailyRandomizeBtn.MouseEnter += new System.EventHandler(this.dailyRandomizeBtn_MouseEnter);
            this.dailyRandomizeBtn.MouseLeave += new System.EventHandler(this.dailyRandomizeBtn_MouseLeave);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.bottomPanel.Location = new System.Drawing.Point(-4, 249);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(6);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(629, 59);
            this.bottomPanel.TabIndex = 4;
            this.bottomPanel.TabStop = false;
            // 
            // randomizeBtn
            // 
            this.randomizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.randomizeBtn.Image = global::DWARand.Properties.Resources.randomizericon_4;
            this.randomizeBtn.Location = new System.Drawing.Point(13, 107);
            this.randomizeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(117, 118);
            this.randomizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.randomizeBtn.TabIndex = 3;
            this.randomizeBtn.TabStop = false;
            this.randomizeBtn.Click += new System.EventHandler(this.randomizeBtn_Click);
            this.randomizeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.randomizeBtn_MouseDown);
            this.randomizeBtn.MouseEnter += new System.EventHandler(this.randomizeBtn_MouseEnter);
            this.randomizeBtn.MouseLeave += new System.EventHandler(this.randomizeBtn_MouseLeave);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.topPanel.Location = new System.Drawing.Point(-4, -6);
            this.topPanel.Margin = new System.Windows.Forms.Padding(6);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(645, 92);
            this.topPanel.TabIndex = 2;
            this.topPanel.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(94)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(627, 301);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.bankeditorBtn);
            this.Controls.Add(this.dailyRandomizeBtn);
            this.Controls.Add(this.hintsLbl);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.randomizeBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.topPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DWARand";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.helpBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankeditorBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyRandomizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox topPanel;
        private System.Windows.Forms.PictureBox randomizeBtn;
        private System.Windows.Forms.PictureBox bottomPanel;
        private System.Windows.Forms.Label hintsLbl;
        private System.Windows.Forms.PictureBox dailyRandomizeBtn;
        private System.Windows.Forms.PictureBox bankeditorBtn;
        private System.Windows.Forms.PictureBox helpBtn;
    }
}

