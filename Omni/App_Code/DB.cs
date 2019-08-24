using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Omni.App_Code
{
    public static class DB
    {
        public static string connectionString()
        {
            return "Data Source=(localdb)\\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        //Executes a sql Query and returns the DataTable of the result
        public static DataTable executeQueryD(string query, string[,] keyValue)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(DB.connectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                for (int i = 0; i < keyValue.GetLength(0); i++)
                    cmd.Parameters.AddWithValue(keyValue[i, 0], (object)keyValue[i, 1] ?? DBNull.Value);

                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
            }
            return table;

        }

        //Executes a sql Query, returns the value in the first row of the first column. if there is none, returns an empty string
        public static string executeQueryS(string query, string[,] keyValue)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(DB.connectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                for (int i = 0; i < keyValue.GetLength(0); i++)
                    cmd.Parameters.AddWithValue(keyValue[i, 0], (object)keyValue[i, 1] ?? DBNull.Value);

                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
            }
            if (table.Rows.Count != 0)
                return table.Rows[0][0].ToString();
            else
                return string.Empty;
        }

    }
}