namespace GuessingGame
{
    partial class ResultScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberofGuesses = new System.Windows.Forms.Label();
            this.sortedOrder = new System.Windows.Forms.Label();
            this.originalOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberofGuesses
            // 
            this.numberofGuesses.AutoSize = true;
            this.numberofGuesses.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numberofGuesses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.numberofGuesses.Location = new System.Drawing.Point(45, 38);
            this.numberofGuesses.Name = "numberofGuesses";
            this.numberofGuesses.Size = new System.Drawing.Size(109, 13);
            this.numberofGuesses.TabIndex = 0;
            this.numberofGuesses.Text = "Number of Guesses:  ";
            // 
            // sortedOrder
            // 
            this.sortedOrder.AutoSize = true;
            this.sortedOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sortedOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sortedOrder.Location = new System.Drawing.Point(49, 179);
            this.sortedOrder.Name = "sortedOrder";
            this.sortedOrder.Size = new System.Drawing.Size(76, 13);
            this.sortedOrder.TabIndex = 1;
            this.sortedOrder.Text = "Sorted Order:  ";
            // 
            // originalOrder
            // 
            this.originalOrder.AutoSize = true;
            this.originalOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.originalOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.originalOrder.Location = new System.Drawing.Point(45, 103);
            this.originalOrder.Name = "originalOrder";
            this.originalOrder.Size = new System.Drawing.Size(80, 13);
            this.originalOrder.TabIndex = 2;
            this.originalOrder.Text = "Original Order:  ";
            // 
            // ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.originalOrder);
            this.Controls.Add(this.sortedOrder);
            this.Controls.Add(this.numberofGuesses);
            this.Name = "ResultScreen";
            this.Size = new System.Drawing.Size(300, 279);
            this.Load += new System.EventHandler(this.ResultScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberofGuesses;
        private System.Windows.Forms.Label sortedOrder;
        private System.Windows.Forms.Label originalOrder;
    }
}
