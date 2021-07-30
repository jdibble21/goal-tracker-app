using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoalTrackerApp.src.forms;
using GoalTrackerApp.src.logic;

namespace GoalTrackerApp

{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Goal Tracker App";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddGoal newGoalForm = new AddGoal();
            newGoalForm.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
