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
using System.Collections.Generic;
using Items;
using Persons;

namespace Items
{
	public interface IItem
	{
		/* Some shall have setters, other shallen't */
		/* Defined at random by me */
		/* Deal with it */
		string Description {get;}
		decimal Value {get;}
		int Count {get;}
		bool Legendary {get;}
		bool Unique {get;}
		bool Consumable {get;set;}
	}

	public class Boots : IItem
	{
		private decimal value;
		private int count;
		private bool legendary;
		private bool unique;
		
		public Boots()
		{
			Random rnd = new Random(Guid.NewGuid().GetHashCode());
			this.value = rnd.Next(0,100);
			this.count = 2;
			this.legendary = rnd.Next(100) <= 20 ? true : false;
			this.unique =	rnd.Next(100) <= 20 ? true : false;
			this.Consumable =	rnd.Next(100) <= 20 ? true : false;
		}
		
		public string Description
		{
			get { return "Boots to boot your feet.";}
		}
		public decimal Value
		{
			get { return this.value; }
		}

		public int Count
		{
			get { return this.count; }
		}

		public bool Legendary
		{
			get { return this.legendary; } 
		}

		public bool Unique
		{
			get { return this.unique; }
		}

		public bool Consumable
		{
			get { return this.Consumable; }
			set { this.Consumable = value; }
		}
	}
	
}

namespace Persons
{
	public interface IPerson
	{
		string FirstName {get;set;}
		string LastName {get;set;}
		string FullName {get;}
	}

}

namespace Students
{
	public class Student : IPerson
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

		public string FirstName
		{
			get {return this.firstName;}
			set {this.firstName = value;}
		}

		public string LastName
		{
			get {return this.lastName;}
			set {this.lastName = value;}
		}

		public string FullName
		{
			get {return this.firstName + " " + this.lastName;}
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

	public class Assistant : IPerson
	{
		private string firstName;
		private string lastName;

		public Assistant(string fName, string lName)
		{
			this.firstName = fName;
			this.lastName = lName;
		}
		
		public string FirstName
		{
			get {return this.firstName;}
			set {this.firstName = value;}
		}
		
		public string LastName
		{
			get {return this.lastName;}
			set {this.lastName = value;}
		}
		
		public string FullName
		{
			get {return this.firstName + " " + this.lastName;}
		}

	}
}
