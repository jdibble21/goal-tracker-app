using System;
using System.Collections;
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
        private ProjectLogic pl = new ProjectLogic();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Goal Tracker App";
            ArrayList currentGoals = pl.GetAllGoals();
            PrintGoals(currentGoals);
           
        }
        public void PrintGoals(ArrayList goals)
        {
            foreach(Array goalRow in goals)
            {
                Console.WriteLine(goalRow);
            }
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
