using System;
using Students;

namespace Task2
{
    public class Task2
    {
	public static void Main(string[] args)
	{
	    Random rnd = new Random();
	    Student[] s = new Student[6];
	    string[,] names = new String[6,2]; // index1 firstName, index2 lastName
	    names[0,0] = "John"; names[0,1] = "Silver";
	    names[1,0] = "Bart"; names[1,1] = "Simpson";
	    names[2,0] = "Harry"; names[2,1] = "Potter";
	    names[3,0] = "Donald"; names[3,1] = "Duck";
	    names[4,0] = "Marcel"; names[4,1] = "Hirscher";

	    s[0] = new Student("Billy",
			       "Bones",
			       "x"+rnd.Next(0, 1000000).ToString("D7"),
			       "x"+rnd.Next(0, 1000000).ToString("D7"));

	    for(int i=1;i<6;++i)
		{
		    s[i] = new Student(names[i-1,0],
				       names[i-1,1],
				       "x"+rnd.Next(0, 1000000).ToString("D7"),
				       "x"+rnd.Next(0, 1000000).ToString("D7"));
		}
	    
	    listStudents(s);
	}

	public static void listStudents(Student[] l)
	{
	    foreach(Student n in l)
		{
		    n.print();
		}
	}
    }
}
