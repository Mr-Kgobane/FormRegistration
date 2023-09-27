using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Kgobane_Kagiso_PRG282_ST
{
    internal class DataHandler
    {
        public DataHandler() { }
        string con = "Data Source=DESKTOP-I2J8MUI;Initial Catalog=VacineApplicantDB;Integrated Security=True";
        
        public DataTable displayApplicants()
        {
            SqlConnection connection = new SqlConnection(con);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetApplicants", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public void registerApplicant(int id, string name, string surname, string idnum, string phone)
        { 
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand("spAddApplicant", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name",name);
                command.Parameters.AddWithValue("@Surame", surname);
                command.Parameters.AddWithValue("@IDNum", idnum);
                command.Parameters.AddWithValue("@Phone", phone);
                connection.Open();
                command.ExecuteNonQuery();
            }
           
        }

        public void updateApplicant(int id, string name, string surname, string idnum, string phone)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand("spUpdateApplicant", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surame", surname);
                command.Parameters.AddWithValue("@IDNum", idnum);
                command.Parameters.AddWithValue("@Phone", phone);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public DataTable SearchApplicant(int Appid)
        {
            SqlConnection connection = new SqlConnection(con);
            SqlDataAdapter adapter = new SqlDataAdapter("spSearchApplicants", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void DeleteApplicant(int appid)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand("spDeleteApplicants", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", appid);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }


}
