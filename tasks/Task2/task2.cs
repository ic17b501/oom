using System;
using System.Collections.Generic;
using Students;

public class Task2
{
    public static void Main(string[] args)
    {
	Random rnd = new Random();
	//	Student[] s = new Student[6];
	List<Student> s = new List<Student>();
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
				  Math.Round(rnd.NextDouble()*100,2)
				  )
		      );
	    }


	listStudents(s);
	Console.WriteLine("");
	listGold(s);

	Student king = findStudentByName(s,"John Silver");
	if(king != null)
	    {
		Console.Write("King's gold: " + king.Gold.ToString("0.00") + " -> ");		
		king.updateGold(king.Gold * 1000);
		Console.WriteLine(" king's gold after adjustment: " + king.Gold.ToString("0.00"));
	    }

    }

    public static Student findStudentByName(List<Student> l, string name)
    {
	foreach(Student s in l)
	    {
		if(s.getFirstName() + " "+ s.getLastName() == name)
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
