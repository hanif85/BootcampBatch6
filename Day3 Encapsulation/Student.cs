using System.IO.Pipes;

namespace Day3_Encapsulation;

public class Student
{
	private string _studentName= "";
	private int _idNumberStudent;
	private int _studentAge;
	private int _levelStudent;
	
	public string name
	{
		get 
		{
			return _studentName;
		}
		set
		{
			_studentName = value;
		}
	}
	//you can set get or set with private for read or write only
	public int idNumber
	{
		get 
		{
			return _idNumberStudent;
		}
		set
		{
			_idNumberStudent = value;
		}
	}
	public int Age
	{
		get{return _studentAge; }
		set{ _studentAge = value; }
	}
	
}
