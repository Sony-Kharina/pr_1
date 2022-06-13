using System;
using System.IO;
using System.Collections.Generic;


namespace ShowFile
{
	class Name : IComparer<Name>
	{
		public string FIO { set; get; }
		public int Vozrast { set; get; }
		public int Oklad { set; get; }


		public int Compare(Name item1, Name item2)
		{
			return string.Compare(item1.FIO, item2.FIO);
		}
	}
	class Age : IComparer<Age>
	{
		public string FIO1 { set; get; }
		public string Vozrast1 { set; get; }
		public string Oklad1 { set; get; }


		public int Compare(Age item1, Age item2)
		{
			return string.Compare(item1.Vozrast1, item2.Vozrast1);
		}
	}
	class Money : IComparer<Money>
	{
		public string FIO2 { set; get; }
		public string Vozrast2 { set; get; }
		public string Oklad2 { set; get; }

	
		public int Compare(Money item1, Money item2)
		{
			return string.Compare(item1.Oklad2, item2.Oklad2);
		}
	}

	class ShowFile
	{
		static void Main(string[] args)
		{
			List<Name> People = new List<Name>();
			List<Age> People1 = new List<Age>();
			List<Money> People2 = new List<Money>();
			

			try
			{
				string[] lines = File.ReadAllLines(args[0]);
				if (args[1].Equals("ФИО"))
				{
					foreach (string s in lines)
				{
					string[] q = s.Split(';');
					bool success = int.TryParse(q[1], out var age);
					bool success1 = int.TryParse(q[2], out var oklad);
					
					People.Add(new Name() { FIO = q[0], Vozrast = age, Oklad = oklad });
					
				}
				
				
					People.Sort(new Name());
					for (int i = 0; i < People.Count; i++)
					{
						Name item = People[i];
						Console.WriteLine("{0} {1} {2}", item.FIO, item.Vozrast, item.Oklad);
					}
				}
				if (args[1].Equals("Возраст"))
				{
					foreach (string s in lines)
					{
						string[] q = s.Split(';');
				
						People1.Add(new Age() { FIO1 = q[0], Vozrast1 = q[1], Oklad1 = q[2] });

					}


					People1.Sort(new Age());
					for (int i = 0; i < People1.Count; i++)
					{
						Age item = People1[i];
						Console.WriteLine("{0} {1} {2}", item.FIO1, item.Vozrast1, item.Oklad1);
					}
				}

				if (args[1].Equals("Оклад"))
				{
					foreach (string s in lines)
					{
						string[] q = s.Split(';');
					
						People2.Add(new Money() { FIO2 = q[0], Vozrast2 = q[1], Oklad2 = q[2] });

					}


					People2.Sort(new Money());
					for (int i = 0; i < People2.Count; i++)
					{
						Money item = People2[i];
						Console.WriteLine("{0} {1} {2}", item.FIO2, item.Vozrast2, item.Oklad2);
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
