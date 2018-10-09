namespace MegaDesk_3_JanaeFairbourn
{
    partial class AddQuote
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
            this.b1_cancelAddQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1_cancelAddQuote
            // 
            this.b1_cancelAddQuote.Location = new System.Drawing.Point(358, 238);
            this.b1_cancelAddQuote.Name = "b1_cancelAddQuote";
            this.b1_cancelAddQuote.Size = new System.Drawing.Size(75, 23);
            this.b1_cancelAddQuote.TabIndex = 0;
            this.b1_cancelAddQuote.Text = "Cancel";
            this.b1_cancelAddQuote.UseVisualStyleBackColor = true;
            this.b1_cancelAddQuote.Click += new System.EventHandler(this.b1_cancelAddQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 343);
            this.Controls.Add(this.b1_cancelAddQuote);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1_cancelAddQuote;
    }
}