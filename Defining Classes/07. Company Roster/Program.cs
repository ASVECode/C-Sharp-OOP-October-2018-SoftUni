using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CompanyRoster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(separator: " ");
                Employee employee = new Employee(tokens[0], double.Parse(tokens[1]), tokens[2], tokens[3]);
                if (tokens.Length == 5)
                {
                    if (tokens[4].Contains('@'))
                    {
                        employee.Email = tokens[4];
                    }
                    else
                    {
                        employee.Age = int.Parse(tokens[4]);
                    }
                }
                else if (tokens.Length == 6)
                {
                    employee.Email = tokens[4];
                    employee.Age = int.Parse(tokens[5]);
                }
                employees.Add(employee);
            }

            var topDepartement = employees.GroupBy(x => x.Department)
                                          .ToDictionary(x => x.Key, y => y.Select(s => s))
                                          .OrderByDescending(x => x.Value.Average(s => s.Salary))
                                          .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartement.Key}");

            foreach (Employee employee in topDepartement.Value.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
