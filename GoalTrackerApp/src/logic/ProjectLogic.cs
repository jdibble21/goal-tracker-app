using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalTrackerApp;
using GoalTrackerApp.GoalDatabaseDataSetTableAdapters;
using System.Data.SqlClient;

namespace GoalTrackerApp.src.logic
{
    class ProjectLogic
    {
        private GoalsTableAdapter dbConnection = new GoalsTableAdapter();
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jdtar\source\repos\goal-tracker-app\GoalTrackerApp\GoalDatabase.mdf;Integrated Security=True");

        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GoalDatabase.mdf;Integrated Security=True
        public void UploadGoal(String title, String desc, String finishDate)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Goals (title,description,goalDueTime,goalEnterDate,lastEditDate) VALUES(@Title, @Desc, @FinishDate,@EnterDate,@EditDate)", conn);
            String localDate = Convert.ToString(DateTime.Now);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Desc", desc);
            cmd.Parameters.AddWithValue("@FinishDate", finishDate);
            cmd.Parameters.AddWithValue("@EnterDate", localDate);
            cmd.Parameters.AddWithValue("@EditDate", localDate);

            try
            {
                conn.Open();

                // execute the query and return number of rows affected, should be one
                int RowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully in: " + Convert.ToString(RowsAffected));
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
        }

    }
}
