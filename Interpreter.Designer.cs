namespace BrainfuckInterpreter
{
    partial class Interpreter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.AcceptsReturn = true;
            this.mainTextBox.AcceptsTab = true;
            this.mainTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.mainTextBox.Location = new System.Drawing.Point(38, 28);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mainTextBox.Size = new System.Drawing.Size(540, 262);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.Tag = "mainTextBox";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(460, 313);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(118, 33);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Tag = "button";
            this.buttonSend.Text = "Send";
            this.buttonSend.UseCompatibleTextRendering = true;
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.OnClick);
            // 
            // Interpreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 365);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.mainTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Interpreter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Interpreter";
            this.Text = "Interpreter";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox mainTextBox;
        public Button buttonSend;
    }
}