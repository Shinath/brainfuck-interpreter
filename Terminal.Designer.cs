namespace BrainfuckInterpreter
{
    partial class Terminal
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
            this.terminalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // terminalLabel
            // 
            this.terminalLabel.Location = new System.Drawing.Point(12, 9);
            this.terminalLabel.Name = "terminalLabel";
            this.terminalLabel.Size = new System.Drawing.Size(591, 169);
            this.terminalLabel.TabIndex = 0;
            this.terminalLabel.Tag = "label";
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(615, 187);
            this.Controls.Add(this.terminalLabel);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Terminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Terminal";
            this.Text = "Terminal";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public Label terminalLabel;
    }
}