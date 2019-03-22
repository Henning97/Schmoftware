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
            this.Calc = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(12, 38);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(159, 23);
            this.Calc.TabIndex = 1;
            this.Calc.Text = "Fakultät berechnen";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(159, 20);
            this.Input.TabIndex = 2;
            // 
            // Output
            // 
            this.Output.Enabled = false;
            this.Output.Location = new System.Drawing.Point(12, 67);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(159, 20);
            this.Output.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 98);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Calc);
            this.Name = "Form1";
            this.Text = "Fakultät";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
    }
}

