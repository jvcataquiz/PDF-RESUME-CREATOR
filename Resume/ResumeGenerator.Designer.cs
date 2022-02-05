
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelfile = new System.Windows.Forms.Label();
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
            this.richTextBoxSonfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSonfile.Location = new System.Drawing.Point(5, 32);
            this.richTextBoxSonfile.Name = "richTextBoxSonfile";
            this.richTextBoxSonfile.Size = new System.Drawing.Size(518, 293);
            this.richTextBoxSonfile.TabIndex = 1;
            this.richTextBoxSonfile.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "File:";
            // 
            // labelfile
            // 
            this.labelfile.AutoSize = true;
            this.labelfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfile.Location = new System.Drawing.Point(44, 5);
            this.labelfile.Name = "labelfile";
            this.labelfile.Size = new System.Drawing.Size(60, 24);
            this.labelfile.TabIndex = 3;
            this.labelfile.Text = "label2";
            // 
            // ResumeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 407);
            this.Controls.Add(this.labelfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxSonfile);
            this.Controls.Add(this.buttonOne);
            this.Name = "ResumeGenerator";
            this.Text = "PDF RESUME CREATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.RichTextBox richTextBoxSonfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelfile;
    }
}

