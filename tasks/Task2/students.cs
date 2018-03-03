using System;

namespace Students
{
    public class Student
    {
	private string firstName;
	private string lastName;
	private string matNumber;
	private string telNumber;
	private DateTime   birthday;
	private DateTime   created;
	private double gold;
	public double ects; //todo
	public string email; //todo
	
	public Student()
	{
	    this.initEmpty();
	    Console.WriteLine("Empty student created");
	}

	public Student(string firstName,
		       string lastName,
		       string matNumber,
		       string telNumber,
		       double gold
		       )
	{
	    this.setFirstName(firstName);
	    this.setLastName(lastName);
	    this.setMatNumber(matNumber);
	    this.setTelNumber(telNumber);
	    this.setGold(gold);
	}

	private void initEmpty()
	{
	    this.setFirstName("");
	    this.setLastName("");
	    this.setMatNumber("");
	    this.setTelNumber("");		
	    this.birthday = DateTime.Now;
	    this.created = DateTime.Now;
	    this.gold = 0;
	}
	    
	private void setFirstName(string firstName)
	{
	    this.firstName = firstName;
	}

	public string getFirstName()
	{
	    return this.firstName;
	}

	private void setLastName(string lastName)
	{
	    this.lastName = lastName;
	}

	public string getLastName()
	{
	    return this.lastName;
	}

	private void setMatNumber(string matNumber)
	{
	    this.matNumber = matNumber;
	}

	public string getMatNumber()
	{
	    return this.matNumber;
	}

	private void setTelNumber(string telNumber)
	{
	    this.telNumber = telNumber;
	}

	public string getTelNumber()
	{
	    return this.telNumber;
	}

	public void print()
	{
	    Console.WriteLine("<<-----Student record start----->>");
	    Console.WriteLine("First Name: " + this.firstName);
	    Console.WriteLine(" Last Name: " + this.lastName);
	    Console.WriteLine(" matNumber: " + this.matNumber);
	    Console.WriteLine(" telNumber: " + this.telNumber);
	    Console.WriteLine("  birthday: " + this.birthday);
	    Console.WriteLine("   created: " + this.created);
	    Console.WriteLine("      gold: " + this.gold);
	    Console.WriteLine("<<-----Student record end------>>");
	}

	private void setGold(double g)
	{
	    this.gold=g;
	}

	public void updateGold(double g)
	{
	    gold+=g;
	}

	public double Gold
	{

	    get
		{
		    return this.gold;
		}
	}

    }
}
