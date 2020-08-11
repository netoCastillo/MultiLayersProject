using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Employe
    {
        public static List<DataLayer.Empleado> Get()
        {            
            using (DataLayer.BanorteBDEntities db = new DataLayer.BanorteBDEntities())
            {
                return db.Empleado.ToList();
            }            
        }

        public static List<EmployeeEntity> GetByPage(int indexPage)
        {
            DataLayer.EmployeeDAL employee = new DataLayer.EmployeeDAL();
            return employee.GetEmployeeByPage(indexPage);
            
        }
    }
}
