/* 
 * =====================================================================================
 *
 *       Filename:  task2.cs
 *
 *    Description:  isntantiiert und manipuliert Objekte vom typ Student
 *
 *        Version:  1.0
 *        Created:  03/03/2018 04:17:17 PM
 *       Revision:  none
 *       Compiler:  mcs -- Mono C# compiler version 4.4.1.0
 *
 *         Author:  Ovidiu - Dan Bogat [ic17b501], ic17b501@technikum-wien.at
 *   Organization:  -
 *
 * =====================================================================================
 */

using System;
using System.Collections.Generic;
using Students;
using Persons;
using Items;

public class Task2
{
	public static void Main(string[] args)
    {
			Random rnd = new Random();
			//	Student[] s = new Student[6];
			List<Student> s = new List<Student>();
			List<IPerson> crew = new List<IPerson>();
			string[,] names = new String[6,2]; // index1 firstName, index2 lastName
			names[0,0] = "John"; names[0,1] = "Silver";
			names[1,0] = "Bart"; names[1,1] = "Simpson";
			names[2,0] = "Harry"; names[2,1] = "Potter";
			names[3,0] = "Donald"; names[3,1] = "Duck";
			names[4,0] = "Marcel"; names[4,1] = "Hirscher";

			s.Add(new Student("Billy",
												"Bones",
												"x"+rnd.Next(0, 1000000).ToString("D7"),
												"x"+rnd.Next(0, 1000000).ToString("D7"),
												Math.Round(rnd.NextDouble()*100,2)
							)
	      );

	

			for(int i=1;i<6;++i)
	    {
				s.Add(new Student(names[i-1,0],
													names[i-1,1],
													"x"+rnd.Next(0, 1000000).ToString("D7"),
													"x"+rnd.Next(0, 1000000).ToString("D7"),
													Math.Round(rnd.NextDouble()*100,2),
													rnd.Next(100) <= 20 ? true : false
								)
		      );
	    }

			Student king = findStudentByName(s,"John Silver");
			if(king != null)
	    {
				king.setEmail("king@kong.tld");
				king.setHumor(true);
	    }


			listStudents(s);
			Console.WriteLine("");
			listGold(s);

			if(king != null)
	    {
				king.setEmail("king@kong.tld");
				Console.Write("King's gold: " + king.Gold.ToString("0.00") + " -> ");		
				king.updateGold(king.Gold * 1000);
				Console.WriteLine(king.FullName + "'s gold after adjustment: " + king.Gold.ToString("0.00"));
	    }

			
			
			foreach(Student a in s)
	    {
				crew.Add(a);
	    }

			crew.Add(new Assistant("John", "Doe"));
			crew.Add(new Assistant("Helpfull", "Donny"));
			crew.Add(new Assistant("Lefty", "Two-Guns"));

			listCrew(crew);
			
    }

	public static void listCrew(List<IPerson> l)
		{
			Console.WriteLine("The crew consists of:");
			foreach(IPerson p in l)
			{
				Console.WriteLine(p.FullName);
			}
		}
	
	public static Student findStudentByName(List<Student> l, string name)
    {
			foreach(Student s in l)
	    {
				if(s.FullName == name)
		    {
					Student tmp = s;
					return tmp;
		    }
	    }

			return null;
    }

	public static void listStudents(List<Student> l)
    {
			foreach(Student n in l)
	    {
				n.print();
	    }
    }

	public static void listGold(List<Student> l)
    {
			foreach(Student s in l)
	    {
				Console.WriteLine(s.getFirstName() + 
													" " +
													s.getLastName() + 
													" has " +
													s.Gold.ToString("0.00") + 
													" gold pieces.");
				  
	    }
    }
}
