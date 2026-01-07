
namespace DWARand.Settings
{
    partial class DailySettings
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.sndbanksChckBox = new UI.DCheckedListBox();
            this.selallBnt = new System.Windows.Forms.Button();
            this.deselallBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sndbanksChckBox
            // 
            this.sndbanksChckBox.FormattingEnabled = true;
            this.sndbanksChckBox.Location = new System.Drawing.Point(3, 3);
            this.sndbanksChckBox.Name = "sndbanksChckBox";
            this.sndbanksChckBox.Size = new System.Drawing.Size(336, 214);
            this.sndbanksChckBox.TabIndex = 1;
            this.sndbanksChckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.sndbanksChckBox_ItemCheck);
            // 
            // selallBnt
            // 
            this.selallBnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selallBnt.ForeColor = System.Drawing.Color.White;
            this.selallBnt.Location = new System.Drawing.Point(264, 218);
            this.selallBnt.Name = "selallBnt";
            this.selallBnt.Size = new System.Drawing.Size(75, 23);
            this.selallBnt.TabIndex = 13;
            this.selallBnt.Text = "Select all";
            this.selallBnt.UseVisualStyleBackColor = true;
            this.selallBnt.Click += new System.EventHandler(this.selallBnt_Click);
            // 
            // deselallBtn
            // 
            this.deselallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deselallBtn.ForeColor = System.Drawing.Color.White;
            this.deselallBtn.Location = new System.Drawing.Point(183, 218);
            this.deselallBtn.Name = "deselallBtn";
            this.deselallBtn.Size = new System.Drawing.Size(75, 23);
            this.deselallBtn.TabIndex = 14;
            this.deselallBtn.Text = "Deselect all";
            this.deselallBtn.UseVisualStyleBackColor = true;
            this.deselallBtn.Click += new System.EventHandler(this.deselallBtn_Click);
            // 
            // DailySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(94)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.deselallBtn);
            this.Controls.Add(this.selallBnt);
            this.Controls.Add(this.sndbanksChckBox);
            this.Name = "DailySettings";
            this.Size = new System.Drawing.Size(342, 244);
            this.Load += new System.EventHandler(this.DailySettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.DCheckedListBox sndbanksChckBox;
        private System.Windows.Forms.Button selallBnt;
        private System.Windows.Forms.Button deselallBtn;
    }
}
