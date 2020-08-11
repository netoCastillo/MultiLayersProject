using DataLayer.Connection;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EmployeeDAL
    {
        public List<EmployeeEntity> GetEmployeeByPage(int indexPage)
        {
            List<EmployeeEntity> employees = new List<EmployeeEntity>();
            IDbConnection dbConnection = DBCommon.Connection();
            try
            {
                dbConnection.Open();
                SqlCommand command = new SqlCommand("SP_GetEmpleadosByPage", dbConnection as SqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@INDEXPAGE", indexPage));
                IDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    employees.Add(new EmployeeEntity()
                    {
                        Id = result.GetInt64(0),
                        Name = result.GetString(1),
                        LastName = result.GetString(2),
                        Address = result.GetString(3),
                        Age = result.GetInt32(4),
                        Telephone = result.GetString(5),
                        Gender = result.GetString(6),
                        AddmissionDate = result.GetDateTime(7),
                        Salary = result.GetDecimal(8),
                        IdOfficeBrach = result.GetInt32(9),
                        OfficeBrach = result.GetString(10)
                    });
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                dbConnection.Close();
            }




            return employees;

        }
    }
}
