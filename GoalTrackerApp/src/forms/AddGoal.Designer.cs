namespace GoalTrackerApp.src.forms
{
    partial class AddGoal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddGoalButton = new System.Windows.Forms.Button();
            this.endGoalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.goalDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.goalTitleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a New Goal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Goal Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Goal Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Finish Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddGoalButton
            // 
            this.AddGoalButton.Location = new System.Drawing.Point(677, 532);
            this.AddGoalButton.Name = "AddGoalButton";
            this.AddGoalButton.Size = new System.Drawing.Size(212, 44);
            this.AddGoalButton.TabIndex = 8;
            this.AddGoalButton.Text = "Add Goal";
            this.AddGoalButton.UseVisualStyleBackColor = true;
            this.AddGoalButton.Click += new System.EventHandler(this.AddGoalButton_Click);
            // 
            // endGoalTimePicker
            // 
            this.endGoalTimePicker.Location = new System.Drawing.Point(582, 453);
            this.endGoalTimePicker.Name = "endGoalTimePicker";
            this.endGoalTimePicker.Size = new System.Drawing.Size(424, 31);
            this.endGoalTimePicker.TabIndex = 6;
            // 
            // goalDescriptionTextBox
            // 
            this.goalDescriptionTextBox.Location = new System.Drawing.Point(582, 241);
            this.goalDescriptionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.goalDescriptionTextBox.Name = "goalDescriptionTextBox";
            this.goalDescriptionTextBox.Size = new System.Drawing.Size(424, 158);
            this.goalDescriptionTextBox.TabIndex = 5;
            this.goalDescriptionTextBox.Text = "";
            this.goalDescriptionTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // goalTitleTextBox
            // 
            this.goalTitleTextBox.Location = new System.Drawing.Point(580, 160);
            this.goalTitleTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.goalTitleTextBox.Name = "goalTitleTextBox";
            this.goalTitleTextBox.Size = new System.Drawing.Size(424, 31);
            this.goalTitleTextBox.TabIndex = 1;
            // 
            // AddGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.AddGoalButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endGoalTimePicker);
            this.Controls.Add(this.goalDescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goalTitleTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddGoal";
            this.Text = "AddGoal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddGoalButton;
        private System.Windows.Forms.DateTimePicker endGoalTimePicker;
        private System.Windows.Forms.RichTextBox goalDescriptionTextBox;
        private System.Windows.Forms.TextBox goalTitleTextBox;
    }
}