
namespace DWARand
{
    partial class Chronom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chronom));
            this.titleLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.d0 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.customBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(94)))), ((int)(((byte)(18)))));
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(10, 14);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(79, 16);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Select date:";
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.Location = new System.Drawing.Point(336, 151);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 15;
            this.okBtn.Text = "Finish";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // d1
            // 
            this.d1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d1.ForeColor = System.Drawing.Color.White;
            this.d1.Location = new System.Drawing.Point(255, 52);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(75, 64);
            this.d1.TabIndex = 16;
            this.d1.Text = "Previous Day";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // d0
            // 
            this.d0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d0.ForeColor = System.Drawing.Color.White;
            this.d0.Location = new System.Drawing.Point(336, 52);
            this.d0.Name = "d0";
            this.d0.Size = new System.Drawing.Size(75, 64);
            this.d0.TabIndex = 17;
            this.d0.Text = "Today";
            this.d0.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d2.ForeColor = System.Drawing.Color.White;
            this.d2.Location = new System.Drawing.Point(174, 52);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(75, 64);
            this.d2.TabIndex = 18;
            this.d2.Text = "Previous Day";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // d3
            // 
            this.d3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d3.ForeColor = System.Drawing.Color.White;
            this.d3.Location = new System.Drawing.Point(93, 52);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(75, 64);
            this.d3.TabIndex = 19;
            this.d3.Text = "Previous Day";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // d4
            // 
            this.d4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d4.ForeColor = System.Drawing.Color.White;
            this.d4.Location = new System.Drawing.Point(12, 52);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(75, 64);
            this.d4.TabIndex = 20;
            this.d4.Text = "Previous Day";
            this.d4.UseVisualStyleBackColor = true;
            // 
            // customBtn
            // 
            this.customBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBtn.ForeColor = System.Drawing.Color.White;
            this.customBtn.Location = new System.Drawing.Point(14, 151);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(75, 23);
            this.customBtn.TabIndex = 21;
            this.customBtn.Text = "Custom";
            this.customBtn.UseVisualStyleBackColor = true;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // Chronom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(94)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(424, 184);
            this.Controls.Add(this.customBtn);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d0);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.titleLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Chronom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chronom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button d0;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button customBtn;
    }
}

