namespace MegaDesk_3_JanaeFairbourn
{
    partial class SearchQuotes
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
            this.b1_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1_cancel
            // 
            this.b1_cancel.Location = new System.Drawing.Point(456, 254);
            this.b1_cancel.Name = "b1_cancel";
            this.b1_cancel.Size = new System.Drawing.Size(75, 23);
            this.b1_cancel.TabIndex = 0;
            this.b1_cancel.Text = "Cancel";
            this.b1_cancel.UseVisualStyleBackColor = true;
            this.b1_cancel.Click += new System.EventHandler(this.b1_cancel_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b1_cancel);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1_cancel;
    }
}