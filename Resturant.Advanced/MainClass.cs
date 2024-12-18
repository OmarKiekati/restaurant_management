using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Advanced
{
    internal class MainClass
    {
        public static readonly string con_string- "(LocalDB)\MSSQLLocalDB  (DESKTOP-R428O8S\hp (57))";
        public static SqlConnection con = new SqlConnection(con_string);
        public static bool Validation(string user, string password)
        {
            bool validation = false;
            string qry = @"select * from users where username  -' " + user + "' and upass - '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
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
                sqlCommand cmd = new sqlCommand(qry, ht);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht )
                {
                    cmd.parametrs.AddWithValue (item.Key.ToString() , item.Value);
                }
                if (con.state == ConnectionState.Closed)
                {
                    con.open();
                }
                res = cmd.ExecuteNonQuery();
                if (con.state == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
        //for loading data from database
        public static void LoadData(string qry , DataGridView gv , ListBox lb)
        {
            try
            {
                sqlCommand cmd = new sqlCommand (qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
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
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
    } 
}
