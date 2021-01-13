
using System.Linq;

namespace EntityFramework1.Demo
{
    internal class EmployeeProvider : IEmployeeProvider
    {
        private readonly EmployeeContext employeeContext;
        public EmployeeProvider(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public Employee Get(int id) 
        {
            try
            {
                var employe = employeeContext.Employees.Where(e => e.Id == id).FirstOrDefault();
                return employe;
            }
            catch (System.Exception e)
            {

                throw e;
            }
          
        }
    }
}
