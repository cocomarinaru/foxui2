namespace FoxUi
{
    partial class FoxUI
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
            this.exportButton = new System.Windows.Forms.Button();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.stopDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.stopDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(116, 150);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(110, 40);
            this.exportButton.TabIndex = 0;
            this.exportButton.Text = "Exporta";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(183, 41);
            this.startDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.startDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(106, 20);
            this.startDatePicker.TabIndex = 1;
            this.startDatePicker.Value = new System.DateTime(2017, 12, 25, 23, 59, 59, 0);
            // 
            // stopDatePicker
            // 
            this.stopDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stopDatePicker.Location = new System.Drawing.Point(183, 89);
            this.stopDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.stopDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.stopDatePicker.Name = "stopDatePicker";
            this.stopDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stopDatePicker.Size = new System.Drawing.Size(106, 20);
            this.stopDatePicker.TabIndex = 2;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(113, 47);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Start Date:";
            // 
            // stopDateLabel
            // 
            this.stopDateLabel.AutoSize = true;
            this.stopDateLabel.Location = new System.Drawing.Point(117, 95);
            this.stopDateLabel.Name = "stopDateLabel";
            this.stopDateLabel.Size = new System.Drawing.Size(55, 13);
            this.stopDateLabel.TabIndex = 4;
            this.stopDateLabel.Text = "End Date:";
            // 
            // FoxUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 319);
            this.Controls.Add(this.stopDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.stopDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.exportButton);
            this.Name = "FoxUI";
            this.Text = "FoxUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker stopDatePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label stopDateLabel;
    }
}

