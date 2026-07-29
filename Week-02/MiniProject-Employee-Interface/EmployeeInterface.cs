using System ;

namespace EmployeeManagement
{
    interface Iemployee
    {
        void Role();
    }

    class Jdeveloper : Iemployee
    {
        public void Role()
        {
            Console.WriteLine("THere are 25 Junior Developers Present");
        }
    }

    class Sdeveloper : Iemployee
    {
        public void Role()
        {
            Console.WriteLine("There are 11 Senior Developers Present");
        }
    }

    class HR : Iemployee
    {
        public void Role()
        {
            Console.WriteLine("There is 1 HR present in the company");
        }
    }

    class RoleManager
    {
        private Iemployee employee;

        public RoleManager(Iemployee employee)
        {
            this.employee = employee;
        }

        public void Manage()
        {
            employee.Role();
        }
    }

    class MainP
    {
        public static void Main()
        {
        RoleManager role = new RoleManager(new Sdeveloper());

        role.Manage();
        }
    }
}