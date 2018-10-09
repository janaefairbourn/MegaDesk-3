namespace MegaDesk_3_JanaeFairbourn
{
    partial class ViewAllQuotes
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
            this.b1_cancelViewAllQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1_cancelViewAllQuotes
            // 
            this.b1_cancelViewAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1_cancelViewAllQuotes.Location = new System.Drawing.Point(453, 281);
            this.b1_cancelViewAllQuotes.Name = "b1_cancelViewAllQuotes";
            this.b1_cancelViewAllQuotes.Size = new System.Drawing.Size(89, 27);
            this.b1_cancelViewAllQuotes.TabIndex = 0;
            this.b1_cancelViewAllQuotes.Text = "Cancel";
            this.b1_cancelViewAllQuotes.UseVisualStyleBackColor = true;
            this.b1_cancelViewAllQuotes.Click += new System.EventHandler(this.b1_cancelViewAllQuotes_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b1_cancelViewAllQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1_cancelViewAllQuotes;
    }
}