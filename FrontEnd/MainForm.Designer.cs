namespace FrontEnd
{
    partial class MainForm
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
            this.test1Button = new System.Windows.Forms.Button();
            this.test2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test1Button
            // 
            this.test1Button.Location = new System.Drawing.Point(320, 116);
            this.test1Button.Name = "test1Button";
            this.test1Button.Size = new System.Drawing.Size(94, 29);
            this.test1Button.TabIndex = 0;
            this.test1Button.Text = "Test 1";
            this.test1Button.UseVisualStyleBackColor = true;
            this.test1Button.Click += new System.EventHandler(this.Test1ButtonClick);
            // 
            // test2Button
            // 
            this.test2Button.Location = new System.Drawing.Point(320, 175);
            this.test2Button.Name = "test2Button";
            this.test2Button.Size = new System.Drawing.Size(94, 29);
            this.test2Button.TabIndex = 1;
            this.test2Button.Text = "Test 2";
            this.test2Button.UseVisualStyleBackColor = true;
            this.test2Button.Click += new System.EventHandler(this.Test2ButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test2Button);
            this.Controls.Add(this.test1Button);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test1Button;
        private System.Windows.Forms.Button test2Button;
    }
}

