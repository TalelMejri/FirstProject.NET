namespace FirstProject.Models
{
    public class Repository
    {
        private static List<Employee> employeeList = new List<Employee>();

        public static IEnumerable<Employee> GETEmployees()
        {
            return employeeList; 
        }

        public static void AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }
    }
}
