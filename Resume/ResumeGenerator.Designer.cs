
namespace Resume
{
    partial class ResumeGenerator
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
            this.buttonOne = new System.Windows.Forms.Button();
            this.richTextBoxSonfile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(416, 372);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(107, 23);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.Text = "Convert to Pdf";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click_1);
            // 
            // richTextBoxSonfile
            // 
            this.richTextBoxSonfile.Location = new System.Drawing.Point(5, 21);
            this.richTextBoxSonfile.Name = "richTextBoxSonfile";
            this.richTextBoxSonfile.Size = new System.Drawing.Size(518, 304);
            this.richTextBoxSonfile.TabIndex = 1;
            this.richTextBoxSonfile.Text = "";
            // 
            // ResumeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 407);
            this.Controls.Add(this.richTextBoxSonfile);
            this.Controls.Add(this.buttonOne);
            this.Name = "ResumeGenerator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.RichTextBox richTextBoxSonfile;
    }
}

