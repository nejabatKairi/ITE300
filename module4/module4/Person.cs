namespace module4
{
	public class Person
	{
		public string fname;
		public string lname;

		public Person(string fname, string lname)
		{
			this.fname = fname;
			this.lname = lname;
		}

		public int yearsOld { get; internal set; }
	}
}