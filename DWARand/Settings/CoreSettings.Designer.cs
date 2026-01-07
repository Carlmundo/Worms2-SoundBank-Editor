
namespace DWARand.Settings
{
    partial class CoreSettings
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
            this.registerCheckbox = new System.Windows.Forms.CheckBox();
            this.unregisterBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.logCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // registerCheckbox
            // 
            this.registerCheckbox.AutoSize = true;
            this.registerCheckbox.ForeColor = System.Drawing.Color.White;
            this.registerCheckbox.Location = new System.Drawing.Point(15, 15);
            this.registerCheckbox.Name = "registerCheckbox";
            this.registerCheckbox.Size = new System.Drawing.Size(227, 17);
            this.registerCheckbox.TabIndex = 0;
            this.registerCheckbox.Text = "Register DWARand on application start up";
            this.registerCheckbox.UseVisualStyleBackColor = true;
            this.registerCheckbox.CheckedChanged += new System.EventHandler(this.registerCheckbox_CheckedChanged);
            // 
            // unregisterBtn
            // 
            this.unregisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unregisterBtn.ForeColor = System.Drawing.Color.White;
            this.unregisterBtn.Location = new System.Drawing.Point(205, 209);
            this.unregisterBtn.Name = "unregisterBtn";
            this.unregisterBtn.Size = new System.Drawing.Size(122, 23);
            this.unregisterBtn.TabIndex = 15;
            this.unregisterBtn.Text = "Unregister DWARand";
            this.unregisterBtn.UseVisualStyleBackColor = true;
            this.unregisterBtn.Click += new System.EventHandler(this.unregisterBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(15, 209);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(122, 23);
            this.registerBtn.TabIndex = 16;
            this.registerBtn.Text = "Register DWARand";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // logCheckbox
            // 
            this.logCheckbox.AutoSize = true;
            this.logCheckbox.ForeColor = System.Drawing.Color.White;
            this.logCheckbox.Location = new System.Drawing.Point(15, 38);
            this.logCheckbox.Name = "logCheckbox";
            this.logCheckbox.Size = new System.Drawing.Size(104, 17);
            this.logCheckbox.TabIndex = 17;
            this.logCheckbox.Text = "Randomizer logs";
            this.logCheckbox.UseVisualStyleBackColor = true;
            this.logCheckbox.CheckedChanged += new System.EventHandler(this.logCheckbox_CheckedChanged);
            // 
            // CoreSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(94)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.logCheckbox);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.unregisterBtn);
            this.Controls.Add(this.registerCheckbox);
            this.Name = "CoreSettings";
            this.Size = new System.Drawing.Size(342, 244);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox registerCheckbox;
        private System.Windows.Forms.Button unregisterBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.CheckBox logCheckbox;
    }
}
