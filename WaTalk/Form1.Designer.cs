namespace WaTalk
{
    partial class Form1
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
            this.inputWindow = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.outputWindow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputWindow
            // 
            this.inputWindow.Location = new System.Drawing.Point(12, 394);
            this.inputWindow.Multiline = true;
            this.inputWindow.Name = "inputWindow";
            this.inputWindow.Size = new System.Drawing.Size(657, 44);
            this.inputWindow.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SendButton.Location = new System.Drawing.Point(686, 395);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(102, 43);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // outputWindow
            // 
            this.outputWindow.Location = new System.Drawing.Point(12, 12);
            this.outputWindow.Multiline = true;
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.ReadOnly = true;
            this.outputWindow.Size = new System.Drawing.Size(776, 376);
            this.outputWindow.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.inputWindow);
            this.Controls.Add(this.outputWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox inputWindow;
        internal System.Windows.Forms.Button SendButton;
        internal System.Windows.Forms.TextBox outputWindow;
    }
}

