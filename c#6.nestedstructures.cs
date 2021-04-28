using System;
    struct Employee
    {
        public string EmployeeName;
        public int EmployeeId;
        public Salary sal;
    }
    struct Salary
    {
        public int monthly;
        public int yearly;

    }
   public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the Number of Employees : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Employee[] emp = new Employee[num];
            for (int i=0; i<num; i++)
            {
                Console.Write("Enter EmployeeName : ");
                emp[i].EmployeeName = Console.ReadLine();
                Console.Write("Enter EmployeeId : ");
                emp[i].EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the monthly Salary : ");
                emp[i].sal.monthly = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the annual Salary : ");
                emp[i].sal.yearly = Convert.ToInt32(Console.ReadLine());
            }
           
        }
    }