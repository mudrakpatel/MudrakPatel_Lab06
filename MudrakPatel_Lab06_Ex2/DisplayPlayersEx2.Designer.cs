namespace MudrakPatel_Lab06_Ex2
{
    partial class DisplayPlayersEx2
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
            this.rangeLabel = new System.Windows.Forms.Label();
            this.minValueTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.maxValueTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(13, 44);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(153, 13);
            this.rangeLabel.TabIndex = 0;
            this.rangeLabel.Text = "Batting average range input -> ";
            // 
            // minValueTextBox
            // 
            this.minValueTextBox.Location = new System.Drawing.Point(173, 43);
            this.minValueTextBox.Name = "minValueTextBox";
            this.minValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.minValueTextBox.TabIndex = 1;
            this.minValueTextBox.Text = "0.000";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(281, 46);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(22, 13);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "TO";
            // 
            // maxValueTextBox
            // 
            this.maxValueTextBox.Location = new System.Drawing.Point(312, 42);
            this.maxValueTextBox.Name = "maxValueTextBox";
            this.maxValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxValueTextBox.TabIndex = 3;
            this.maxValueTextBox.Text = "1.000";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(424, 40);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // DisplayPlayersEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 313);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.maxValueTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.minValueTextBox);
            this.Controls.Add(this.rangeLabel);
            this.Name = "DisplayPlayersEx2";
            this.Text = "Display players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.TextBox minValueTextBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox maxValueTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

