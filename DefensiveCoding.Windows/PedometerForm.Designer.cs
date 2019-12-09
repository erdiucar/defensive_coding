namespace DefensiveCoding.Windows
{
    partial class PedometerForm
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.GoalTextBox = new System.Windows.Forms.TextBox();
            this.StepsTextBox = new System.Windows.Forms.TextBox();
            this.GoalLabel = new System.Windows.Forms.Label();
            this.StepsLabel = new System.Windows.Forms.Label();
            this.PercentResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(155, 12);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 52);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // GoalTextBox
            // 
            this.GoalTextBox.Location = new System.Drawing.Point(49, 12);
            this.GoalTextBox.Name = "GoalTextBox";
            this.GoalTextBox.Size = new System.Drawing.Size(100, 23);
            this.GoalTextBox.TabIndex = 1;
            // 
            // StepsTextBox
            // 
            this.StepsTextBox.Location = new System.Drawing.Point(49, 41);
            this.StepsTextBox.Name = "StepsTextBox";
            this.StepsTextBox.Size = new System.Drawing.Size(100, 23);
            this.StepsTextBox.TabIndex = 2;
            // 
            // GoalLabel
            // 
            this.GoalLabel.AutoSize = true;
            this.GoalLabel.Location = new System.Drawing.Point(12, 15);
            this.GoalLabel.Name = "GoalLabel";
            this.GoalLabel.Size = new System.Drawing.Size(31, 15);
            this.GoalLabel.TabIndex = 3;
            this.GoalLabel.Text = "Goal";
            // 
            // StepsLabel
            // 
            this.StepsLabel.AutoSize = true;
            this.StepsLabel.Location = new System.Drawing.Point(12, 44);
            this.StepsLabel.Name = "StepsLabel";
            this.StepsLabel.Size = new System.Drawing.Size(35, 15);
            this.StepsLabel.TabIndex = 3;
            this.StepsLabel.Text = "Steps";
            // 
            // PercentResultLabel
            // 
            this.PercentResultLabel.AutoSize = true;
            this.PercentResultLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PercentResultLabel.Location = new System.Drawing.Point(12, 90);
            this.PercentResultLabel.Name = "PercentResultLabel";
            this.PercentResultLabel.Size = new System.Drawing.Size(0, 20);
            this.PercentResultLabel.TabIndex = 4;
            // 
            // PedometerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 134);
            this.Controls.Add(this.PercentResultLabel);
            this.Controls.Add(this.StepsLabel);
            this.Controls.Add(this.StepsTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.GoalLabel);
            this.Controls.Add(this.GoalTextBox);
            this.Name = "PedometerForm";
            this.Text = "Pedometer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox GoalTextBox;
        private System.Windows.Forms.TextBox StepsTextBox;
        private System.Windows.Forms.Label GoalLabel;
        private System.Windows.Forms.Label StepsLabel;
        private System.Windows.Forms.Label PercentResultLabel;
    }
}

