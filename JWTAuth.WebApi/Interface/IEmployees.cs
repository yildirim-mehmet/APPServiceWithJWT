using APP.Service.Models;

namespace APP.Service.Interface
{
    public interface IEmployees
    {
        public List<Employee> GetEmployeeDetails();

        public Employee GetEmployeeDetails(int id);

        public void AddEmployee(Employee employee);

        public void UpdateEmployee(Employee employee);

        public Employee DeleteEmployee(int id);

        public bool CheckEmployee(int id);
    }
}
