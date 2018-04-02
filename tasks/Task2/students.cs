/* 
 * =====================================================================================
 *
 *       Filename:  student.cs
 *
 *    Description:  Student Class definitions 
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

namespace Students
{
    public class Student
    {
	private string firstName;
	private string lastName;
	private string matNumber;
	private string telNumber;
	private DateTime birthday;
	private DateTime created;
	private double gold;
	private string email;
	private bool humor;
	
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
	    this.firstName = firstName;
	    this.lastName = lastName;
	    this.matNumber = matNumber;
	    this.telNumber = telNumber;
	    this.gold = gold;
	    this.email = mail;
	    this.humor = humor;
	}

	private void initEmpty()
	{
	    this.firstName = "";
	    this.lastName = "";
	    this.matNumber = "";
	    this.telNumber = "";
	    this.email = "<none>";
	    this.humor = false;
	    this.birthday = DateTime.Now;
	    this.created = DateTime.Now;
	    this.gold = 0;
	}

	public string FirstName
	{
	    get {return this.firstName;}
	    set {this.firstName = value;}
	}

	public string LasName
	{
	    get {return this.lastName;}
	    set {this.lastName = value;}
	}

	public string FullName
	{
	    get {return this.firstName + " " + this.lastName;}
	}
	
	public string MatriculationNumber
	{
	    get {return this.matNumber;}
	    set {this.matNumber = value;}
	}

	public DateTime Immatriculated
	{
	    get {return this.created;}
	    set {this.created = value;}
	}

	public DateTime BirthDay
	{
	    get {return this.birthday;}
	    set {this.birthday = value;}
	}
	
	public string TelNumber
	{
	    get {return this.telNumber;}
	    set {this.telNumber = value;}
	}

	public double Gold
	{
	    get	{return this.gold;}
	    set {this.gold += value;}
	}

	public string Email
	{
	    get {return this.email;}
	    set {this.email = value;}
	}
	
	public bool Humor
	{
	    get {return this.humor;}
	    set {this.humor = value;}
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
	    Console.WriteLine("     humor: " + this.humor);
	    Console.WriteLine("      gold: " + this.gold);
	    Console.WriteLine("<<-----Student record end------>>");
	}


    }
}
