namespace NUnit.Tests
{
    using System;
    using NUnit.Framework;
    using Students;

    [TestFixture]
	public class Tests
	{
	    [Test]
		public void Students1()
	    {
		Assert.That(new Student(), Is.Not.Null);
		Student s = new Student(
					"Helpful",
					"Marty",
					"x1234567890",
					"x0987654321",
					99,
					false,
					"mail@box.com"
					);
		Assert.That(s,Is.Not.Null);
		Assert.That(s.FullName, Is.EqualTo("Helpful Marty"));
		Assert.That(s.Gold, Is.InstanceOf(typeof(double)));
	    }
	
	    [Test]
		public void Students2()
	    {
		Student s = new Student(
					"Helpful",
					"Marty",
					"x1234567890",
					"x0987654321",
					99,
					false,
					"mail@box.com"
					);
		s.Humor = true;
		Assert.That(s.Humor, Is.True);

	    }

	    [Test]
		public void Assistants1()
	    {
		Assistant a = new Assistant();
		Assert.That(a, Is.Not.Null);
	    }

	    [Test]
		public void Assitants2()
	    {
		Assistant a = new Assistant(
					"Helpful",
					"Marty",
					"a1234567890",
					"x0987654321",
					199,
					false,
					"mail@box.com"
					);
		Assert.That(a, Is.Not.Null);
		Assert.That(a.MatriculationNumber, Does.StartWith("a"));
		Assert.That(a.TelNumber, Does.Not.StartWith("a"));
		Assert.That(a.FullName, Does.Contain("Mar"));
		Assert.That(a.Email, Does.Not.Contain("non"));
		
	    }



	    [Test]
		public void Assitants3()
	    {
		Assistant a = new Assistant(
					"Helpful",
					"Marty",
					"a1234567890",
					"x0987654321",
					199,
					false,
					"mail@box.com"
					);
		Assert.That(a, Is.Not.Null);
		Assert.That(a.MatriculationNumber, Does.StartWith("a"));
		Assert.That(a.TelNumber, Does.Not.StartWith("a"));
		Assert.That(a.FullName, Does.Contain("Mar"));
		Assert.That(a.Email, Does.Not.Contain("non"));
		Assert.That(a.DoNothing, Throws.InstanceOf<NotSupportedException>());
	    }
	}
}
