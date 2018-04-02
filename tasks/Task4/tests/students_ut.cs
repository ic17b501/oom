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

	}
}
