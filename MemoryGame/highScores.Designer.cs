namespace MemoryGame
{
    partial class highScores
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
            this.highScoreGrid = new System.Windows.Forms.DataGridView();
            this.lbl_high_scores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // highScoreGrid
            // 
            this.highScoreGrid.AllowUserToAddRows = false;
            this.highScoreGrid.AllowUserToDeleteRows = false;
            this.highScoreGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.highScoreGrid.Location = new System.Drawing.Point(25, 46);
            this.highScoreGrid.Name = "highScoreGrid";
            this.highScoreGrid.ReadOnly = true;
            this.highScoreGrid.Size = new System.Drawing.Size(375, 275);
            this.highScoreGrid.TabIndex = 5;
            this.highScoreGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.highScoreGrid_CellContentClick);
            // 
            // lbl_high_scores
            // 
            this.lbl_high_scores.AutoSize = true;
            this.lbl_high_scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_high_scores.Location = new System.Drawing.Point(146, 9);
            this.lbl_high_scores.Name = "lbl_high_scores";
            this.lbl_high_scores.Size = new System.Drawing.Size(131, 24);
            this.lbl_high_scores.TabIndex = 4;
            this.lbl_high_scores.Text = "High Scores!";
            // 
            // highScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 344);
            this.Controls.Add(this.highScoreGrid);
            this.Controls.Add(this.lbl_high_scores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "highScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High Scores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosedEvent);
            this.Load += new System.EventHandler(this.formLoad);
            ((System.ComponentModel.ISupportInitialize)(this.highScoreGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView highScoreGrid;
        private System.Windows.Forms.Label lbl_high_scores;
    }
}