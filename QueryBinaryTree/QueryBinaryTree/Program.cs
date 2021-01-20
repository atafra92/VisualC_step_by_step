using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace QueryBinaryTree
{
    class Program
    {
        static void doWork()
        {
            Tree<Employee> empTree = new Tree<Employee>(
                new Employee { Id = 1, FirstName = "Antonio", LastName = "Tafra", Department = "IT" });

            empTree.Insert(new Employee { Id = 2, FirstName = "Marija", LastName = "Tafra", Department = "Marketing" });
            empTree.Insert(new Employee { Id = 4, FirstName = "Nikolina", LastName = "Juras", Department = "IT" });
            empTree.Insert(new Employee { Id = 6, FirstName = "Antonija", LastName = "Tafra", Department = "Sales" });
            empTree.Insert(new Employee { Id = 3, FirstName = "Deni", LastName = "Juras", Department = "Sales" });
            empTree.Insert(new Employee { Id = 5, FirstName = "Grgo", LastName = "Tafra", Department = "Marketing" });

            Console.WriteLine("List of departments");
            var depts = empTree.Select(d => d.Department); //select method returns entire row 

            // var deptsDistinct = empTree.Select(d => d.Department).Distinct(); 
            //using select...from statement
            var deptsDistinct = (from d in empTree
                        select d.Department).Distinct();

            foreach (var dept in deptsDistinct)
            {
                Console.WriteLine($"Department: {dept}"); //orders list by Id because of CompareTo method in Employee class
                Console.WriteLine($"Distinct Departments: {dept}");
            }

            Console.WriteLine();
            Console.WriteLine("Employyes in IT Department:");
            //var employeesInIT = empTree.Where(e => e.Department == "IT").Select(e => e); //..ILI
            //var employeesInIt = empTree.Where(e => String.Equals(e.Department, "IT")).Select(e => e);

            //using select...from
            var employeesInIT = from emp in empTree
                                where String.Equals(emp.Department, "IT")
                                select emp;

            foreach (var emp in employeesInIT)
            {
                Console.WriteLine(emp);
            }

            //Group the employees found in the binary tree by department. The outer foreach loop iterates 
            //throught each group, displaying name of department. The inner foreach displays the names of emmployees 
            //in each department
            Console.WriteLine();
            Console.WriteLine("All employees grouped by department:");

            //var employeesByDept = empTree.GroupBy(e => e.Department);

            //using select...from
            var employeesByDept = from dept in empTree
                                  group dept by dept.Department;

            foreach (var dept in employeesByDept)
            {
                Console.WriteLine();
                Console.WriteLine($"Department: { dept.Key }");

                foreach (var emp in dept)
                {
                    Console.WriteLine($"{ emp.FirstName } { emp.LastName }");
                }
            }

        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

            Console.ReadLine();
        }
    }
}
