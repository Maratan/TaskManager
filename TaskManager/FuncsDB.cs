using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class FuncsDB
    {
        //функция открытия сединения с БД
        //public static SqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        //{
        //    // Connection String.
        //    String connString = "Server=" + host + ";Database=" + database
        //        + ";port=" + port + ";User Id=" + username + ";password=" + password;

        //    MySqlConnection conn = new MySqlConnection(connString);

        //    return conn;
        //}

        //настройки подключения к серверу
        //public static SqlConnection GetDBConnection()
        //{
        //    //string host = "localhost";
        //    //int port = 3306;
        //    //string database = "taskdb";
        //    //string username = "root";
        //    //string password = "1234";

        //    return SqlConnection(TaskManager.Properties.Settings.Default.ConString);
        //}

        //выборка
        public static string SQLSelect(string cmd)
        {

            try
            {
                //MySqlConnection conn = GetDBConnection();
                SqlConnection conn = new SqlConnection(TaskManager.Properties.Settings.Default.ConString);
                conn.Open(); //открываем соединение с БД

                SqlCommand SQLCMD = new SqlCommand();
                SQLCMD.Connection = conn;
                SQLCMD.CommandText = cmd;

                var result = SQLCMD.ExecuteScalar();
                conn.Close(); //закрываем соединение

                if (result == null)
                    return "null";

                return result.ToString();
            }
            catch (Exception ex)
            {
                return "-1";
            }
        }

        //Вставка/Обновление/Удаление
        public static void SQLIUD(string cmd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(TaskManager.Properties.Settings.Default.ConString);
                conn.Open();

                SqlCommand SQLCMD = new SqlCommand();
                SQLCMD.Connection = conn;
                SQLCMD.CommandText = cmd;
                int count = SQLCMD.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                //return "Непредвиденная ошибка:\n" + ex;
            }
        }

        //множжественная выборка
        public static List<string> SQLSelect(string cmd, int columnCount)
        {
            List<string> result = new List<string> { };
            try
            {
                SqlConnection conn = new SqlConnection(TaskManager.Properties.Settings.Default.ConString);
                conn.Open();

                SqlCommand SQLCMD = new SqlCommand();
                SQLCMD.Connection = conn;
                SQLCMD.CommandText = cmd;
                SqlDataReader reader = SQLCMD.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < columnCount; i++)
                        result.Add(reader.GetString(i));
                }

                reader.Close();

                conn.Close();
            }
            catch (Exception ex)
            {
                //return "Непредвиденная ошибка:\n" + ex;
                result.Add("Ошибка");
            }

            return result;
        }

    }
}
