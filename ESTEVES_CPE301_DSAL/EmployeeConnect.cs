using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTEVES_CPE301_DSAL
{
    internal class EmployeeConnect
    {
        //
        public String emp_connectionString = null;
        public SqlConnection emp_sql_connection;
        public SqlCommand emp_sql_command;
        public DataSet emp_sql_dataset;
        public SqlDataAdapter emp_sql_dataadapter;
        public string emp_sql = null;

        public void emp_connString()
        {
            //
            emp_sql_connection = new SqlConnection();
            emp_connectionString = "Data Source = C203-24; Initial Catalog = CompanySystem; user id = SA; password = B1Admin123@";
            emp_sql_connection = new SqlConnection(emp_connectionString);
            emp_sql_connection.ConnectionString = emp_connectionString;
            emp_sql_connection.Open();
        }

        //
        public void emp_cmd()
        {
            emp_sql_command = new SqlCommand(emp_sql, emp_sql_connection);
            emp_sql_command.CommandType = CommandType.Text;
        }

        //
        public void emp_sqladapterSelect()
        {
            emp_sql_dataadapter = new SqlDataAdapter();
            emp_sql_dataadapter.SelectCommand = emp_sql_command;
            emp_sql_command.ExecuteNonQuery();
        }

        //
        public void emp_sqladapterInsert()
        {
            emp_sql_dataadapter = new SqlDataAdapter();
            emp_sql_dataadapter.InsertCommand = emp_sql_command;
            emp_sql_command.ExecuteNonQuery();
        }

        //
        public void emp_sqladapterDelete()
        {
            emp_sql_dataadapter = new SqlDataAdapter();
            emp_sql_dataadapter.DeleteCommand = emp_sql_command;
            emp_sql_command.ExecuteNonQuery();
        }

        //
        public void emp_sqladapterUpdate()
        {
            emp_sql_dataadapter = new SqlDataAdapter();
            emp_sql_dataadapter.UpdateCommand = emp_sql_command;
            emp_sql_command.ExecuteNonQuery();
        }

        //
        public void emp_sqldatasetSELECT()
        {
            emp_sql_dataset = new DataSet();
            emp_sql_dataadapter.Fill(emp_sql_dataset, "CompanySystem");
        }

        //
        public void emp_sqldatasetSELECTSALES()
        {
            emp_sql_dataset = new DataSet();
            emp_sql_dataadapter.Fill(emp_sql_dataset, "CompanySystem");
        }

      
    }
}
