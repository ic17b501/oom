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
	public string email;
	public bool humor;
	
	public Student()
	{
	    this.initEmpty();
	    Console.WriteLine("Empty student created");
	}

	public Student(string firstName,
		       string lastName,
		       string matNumber,
		       string telNumber,
		       double gold,
		       bool humor=false,
		       string mail="<none>"
		       )
	{
	    this.setFirstName(firstName);
	    this.setLastName(lastName);
	    this.setMatNumber(matNumber);
	    this.setTelNumber(telNumber);
	    this.setGold(gold);
	    this.setEmail(mail);
	    this.humor=humor;
	}

	private void initEmpty()
	{
	    this.setFirstName("");
	    this.setLastName("");
	    this.setMatNumber("");
	    this.setTelNumber("");		
	    this.setEmail("<none>");
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
	    Console.WriteLine("     email: " + this.email);
	    Console.WriteLine("  birthday: " + this.birthday);
	    Console.WriteLine("   created: " + this.created);
	    Console.WriteLine("     humor: " + this.hasHumor());
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

	public void setEmail(string mail)
	{
	    this.email = mail;
	}
	
	public string getEmail()
	{
	    return this.email;
	}
	
	public bool hasHumor()
	{
	    return this.humor;
	}

	public void setHumor(bool humor)
	{
	    this.humor = humor;
	}

    }
}
