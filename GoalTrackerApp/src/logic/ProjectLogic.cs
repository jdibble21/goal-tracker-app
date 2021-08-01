using System;
using GoalTrackerApp.GoalDatabaseDataSetTableAdapters;
using System.Data.SqlClient;
using System.Collections;

namespace GoalTrackerApp.src.logic
{
    class ProjectLogic
    {
        private SqlConnection conn;

        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GoalDatabase.mdf;Integrated Security=True
        //Database GETs

        public ProjectLogic()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jdtar\source\repos\goal-tracker-app\GoalTrackerApp\GoalDatabase.mdf;Integrated Security=True");
        }

        public ArrayList GetAllGoals()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Goals", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            ArrayList arlist = new ArrayList();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    String[] temp = new string[6];
                    temp[0] = Convert.ToString(dr.GetInt32(0));
                    temp[1] = dr.GetString(1);
                    temp[2] = dr.GetString(2);
                    temp[3] = dr.GetString(3);
                    temp[4] = dr.GetString(4);
                    temp[5] = dr.GetString(5);
                    arlist.Add(temp);
                }
            }
            return arlist;
        }
        //Database INSERTs
        public void InsertGoal(String title, String desc, String finishDate)
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
