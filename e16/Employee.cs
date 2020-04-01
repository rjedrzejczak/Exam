namespace e16
{
    public class Employee
    {
        protected string EmployeeType { get; private set; }

        private void test()
        {
            Employee employee = new Employee();
            employee.EmployeeType = "dupa";
        }
    }
}