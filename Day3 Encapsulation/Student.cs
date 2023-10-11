using System.IO.Pipes;

namespace Day3_Encapsulation;

public class Student
{
	private string studentName= "";
	private int idNumberStudent;
	private int studentAge;
	private int levelStudent;
	
	public string name
	{
		get 
		{
			return studentName;
		}
		set
		{
			studentName = value;
		}
	}
	public int idNumber
	{
		get 
		{
			return idNumberStudent;
		}
		set
		{
			idNumberStudent = value;
		}
	}
	public int Age
	{
		get{return studentAge; }
		set{ studentAge = value; }
	}
	
}
