using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace Resturant.Advanced
{
    internal class MainClass
    {
        public static readonly string con_string= @"(LocalDB)\MSSQLLocalDB  (DESKTOP-R428O8S\hp (57))";
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(con_string);
        public static bool Validation(string user, string password)
        {
            bool validation = false;
            string qry = @"select * from users where username  -' " + user + "' and upass - '" + password + "' ";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(qry, con);
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                validation = true;
                USER = dt.Rows[0][""].ToString();
            }


            return validation;


        }
        // create property for username
        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
        //method for crud operation
        public static int SQL(string qry, Hashtable ht) 
        {
            int res = 0;
            try
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht )
                {
                    cmd.Parameters.AddWithValue (item.Key.ToString() , item.Value);
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return 1;
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
                con.Close();
                return 0;
            }
        }
        //for loading data from database
        public static void LoadData(string qry , DataGridView gv , ListBox lb)
        {
            try
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand (qry, con);
                cmd.CommandType = CommandType.Text;
                System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill (dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn) lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }
                gv .DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                con.Close();
            }
        }
    } 
}
