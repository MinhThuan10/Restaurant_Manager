using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RestaurantManager.DAO
{
    internal class DataProvider
    {
        public static string ConnectionString;
        public static string Username;
        public static string Password;
        public static SqlConnection Connection;

        public static string UserName { get; set; }
        public static string PassWord { get; set; }
      
        public static void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }
            }
        }
        public static void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        public static void SetLoggedInUsername(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public static DataTable ExecuteQuery(string Query, ref string ErrMsg, object[] ParameterValues = null)
        {
            ConnectionString = $@"Data Source=.;Initial Catalog=QLNH; User ID={Username}; Password={Password}";
            DataTable Table = new DataTable();
            try
            {
                using (Connection = new SqlConnection(ConnectionString))
                {
                    OpenConnection();
                    SqlCommand cmd = new SqlCommand(Query, Connection);
                    if (ParameterValues != null)
                    {
                        string[] Parameters = Query.Split(' ');
                        int i = 0;
                        foreach (string param in Parameters)
                        {
                            if (param.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(param, ParameterValues[i++]);
                            }
                        }
                    }
                    SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
                    DataAdapter.Fill(Table);
                }
            }
            catch (Exception e) { ErrMsg = e.Message; }
            finally { CloseConnection(); }
            return Table;
        }
        public static int ExecuteNonQuery(string Query, ref string ErrMsg, object[] ParameterValues = null)
        {
            ConnectionString = $@"Data Source=.;Initial Catalog=QLNH; User ID={Username}; Password={Password}";
            int rowsAffected = 0;
            try
            {
                using(Connection = new SqlConnection(ConnectionString))
                {
                    OpenConnection();
                    SqlCommand cmd = new SqlCommand(Query, Connection);
                    if (ParameterValues != null)
                    {
                        string[] Parameters = Query.Split(' ');
                        int i = 0;
                        foreach(string param in Parameters)
                        {
                            if(param.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(param, ParameterValues[i++]);
                            }
                        }
                    }
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch(Exception e) { ErrMsg = e.Message;}
            finally 
            {
                Connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
                {
                    //if(e.Message != "")
                    //{
                    //}
                       // MessageBox.Show(e.Message);
                };
                CloseConnection(); 
            }
            return rowsAffected;
        }
        public static object ExecuteScalar(string Query, ref string ErrMsg, object[] ParameterValues = null)
        {
            ConnectionString = $@"Data Source=.;Initial Catalog=QLNH; User ID={Username}; Password={Password}";
            object Data = null;
            try
            {
                using (Connection = new SqlConnection(ConnectionString))
                {
                    OpenConnection();
                    SqlCommand cmd = new SqlCommand(Query, Connection);
                    if (ParameterValues != null)
                    {
                        string[] Parameters = Query.Split(' ');
                        int i = 0;
                        foreach (string param in Parameters)
                        {
                            if (param.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(param, ParameterValues[i++]);
                            }
                        }
                    }
                    Data = cmd.ExecuteScalar();
                }
            }
            catch (Exception e) { ErrMsg = e.Message; }
            finally { CloseConnection(); }
            return Data;
        }
        public static int NextID(string TableName)
        {
            ConnectionString = $@"Data Source=.;Initial Catalog=QLNH; User ID={Username}; Password={Password}";
            int LastId = 0;

            using (Connection = new SqlConnection(ConnectionString))
            {
            OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('" + TableName + "')", Connection);
                LastId = Convert.ToInt32(cmd.ExecuteScalar());

                CloseConnection();
            }

            return LastId;
        }
    }
}
