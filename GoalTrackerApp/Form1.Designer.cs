namespace GoalTrackerApp
{
    partial class Form1
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
            this.currentGoalList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.addGoalButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(624, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Track your Goals!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentGoalList
            // 
            this.currentGoalList.HideSelection = false;
            this.currentGoalList.Location = new System.Drawing.Point(504, 138);
            this.currentGoalList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.currentGoalList.Name = "currentGoalList";
            this.currentGoalList.Size = new System.Drawing.Size(848, 562);
            this.currentGoalList.TabIndex = 1;
            this.currentGoalList.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Goals";
            // 
            // addGoalButton
            // 
            this.addGoalButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGoalButton.Location = new System.Drawing.Point(108, 169);
            this.addGoalButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addGoalButton.Name = "addGoalButton";
            this.addGoalButton.Size = new System.Drawing.Size(240, 44);
            this.addGoalButton.TabIndex = 3;
            this.addGoalButton.Text = "Add Goal";
            this.addGoalButton.UseVisualStyleBackColor = true;
            this.addGoalButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(108, 250);
            this.resetButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(240, 44);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset Goals";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(108, 323);
            this.helpButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(240, 44);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addGoalButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentGoalList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView currentGoalList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addGoalButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button helpButton;
    }
}

