using System;
using System.IO;
using System.Collections.Generic;


namespace ShowFile
{
	class People
	{
		public string FIO { set; get; }
		public string Vozrast { set; get; }
		public string Salary { set; get; }
		public People(string fio, string vozrast, string salary)
		{
			FIO = fio;
			Vozrast = vozrast;
			Salary = salary;
		}
		
	}
	class NameComparer : IComparer<People>
	{
		
		public int Compare(People item1, People item2)
		{
			return string.Compare(item1.FIO, item2.FIO);
		}
	}
		class AgeComparer : IComparer<People>
		{

			public int Compare(People item1, People item2)
			{
				return string.Compare(item1.Vozrast, item2.Vozrast);
			}
		}
		class SalaryComparer : IComparer<People>
		{

			public int Compare(People item1, People item2)
			{
				return string.Compare(item1.Salary, item2.Salary);
			}
		}
		

	class ShowFile
	{
		static void Main(string[] args)
		{
			List<People> People1 = new List<People>();
		
			try
			{
				string[] lines = File.ReadAllLines(args[0]);
				
					foreach (string s in lines)
					{
						string[] q = s.Split(';');
						People1.Add(new People(q[0], q[1], q[2]));

					}
					if (args[1].Equals("ФИО"))
					{

						People1.Sort(new NameComparer());
					for (int i = 0; i < People1.Count; i++)
						{
						People item = People1[i];
						Console.WriteLine("{0} {1} {2}", item.FIO, item.Vozrast, item.Salary);
						}
					}
				
					if (args[1].Equals("Возраст"))
					{
						People1.Sort(new AgeComparer());
					for (int i = 0; i < People1.Count; i++)
						{
						People item = People1[i];
						Console.WriteLine("{0} {1} {2}", item.FIO, item.Vozrast, item.Salary);
						}
					}
		
					if (args[1].Equals("Оклад"))
					{
						People1.Sort(new SalaryComparer());
					for (int i = 0; i < People1.Count; i++)
						{
						People item = People1[i];
						Console.WriteLine("{0} {1} {2}", item.FIO, item.Vozrast, item.Salary);
						}
					}
			}
			catch (IOException exc)
			{
				Console.WriteLine("Ошибка чтения файла");
				Console.WriteLine(exc.Message);
			}

		}
	}
}

