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
            List<DataLayer.Empleado> list = new List<DataLayer.Empleado>();

            using (DataLayer.BanorteBDEntities db = new DataLayer.BanorteBDEntities())
            {
                return db.Empleado.ToList();
            }

            return list;
        }
    }
}
