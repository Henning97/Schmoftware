namespace Schmoftware
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.MaxSchmax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MaxSchmax
            // 
            this.MaxSchmax.Location = new System.Drawing.Point(35, 12);
            this.MaxSchmax.Name = "MaxSchmax";
            this.MaxSchmax.Size = new System.Drawing.Size(152, 89);
            this.MaxSchmax.TabIndex = 0;
            this.MaxSchmax.Text = "MaxSchmax";
            this.MaxSchmax.UseVisualStyleBackColor = true;
            this.MaxSchmax.Click += new System.EventHandler(this.MaxSchmax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaxSchmax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MaxSchmax;
    }
}

