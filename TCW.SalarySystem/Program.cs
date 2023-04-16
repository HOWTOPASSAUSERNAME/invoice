using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCW.SalarySystem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Employee> employees = new List<Employee>();

			employees.Add(new Employee{
									Name = "KIN" , 
									BadgeNumber="A012",
									Salary=28000});
			employees.Add(new Sales{
									Name = "JIN",
									BadgeNumber = "B035",
									Salary = 30000,
									PerformanceBonus = 4000});
			employees.Add(new Engineer { 
									Name = "SIN",
									BadgeNumber = "E088",
									Salary = 100000, 
									OvertimePay = 10 });
			employees.Add(new Manager { 
									Name = "MIN",
									BadgeNumber="U001",
									Salary = 200000, 
									SalesBonus =100000});

			foreach(Employee employee in employees)
			{
				Console.WriteLine(employee);
			}

		}
	}

	class Person{
        public string Name { get; set; }


        public Person()
        {
			
        }
		public override string ToString()
		{
			return $"{Name}";
		}
	}
	/// <summary>
	/// 沒有任何獎金或加給的員工
	/// </summary>
	class Employee:Person { 
		public string BadgeNumber { get; set; }
        public int Salary { get; set; }
		
		

        public Employee()
        {
		
            
        }
        public virtual int GetSalary()
		{
			
			return Salary;
		}
		public override string ToString()
		{
			return $"Name:{Name},BadgeNumner:{BadgeNumber},Salary:{GetSalary()}";
		}

	}
	class Sales:Employee	{
        
		public int PerformanceBonus { get; set; }

        public Sales()
        {
            
        }
		public override int GetSalary()
		{
			return Salary + PerformanceBonus;
		}

	}

	class Engineer:Employee	{

        public int OvertimePay { get; set; }

		public override int GetSalary()
		{
			return Salary + OvertimePay;
		}
	}

	class Manager : Employee	{
        public int SalesBonus { get; set; }

		public override int GetSalary()
		{
			return Salary+ SalesBonus;
		}
	}

}
