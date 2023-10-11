using Day3_Encapsulation;
class Program
{
	static void Main(string[] args)
	{
		Student student1 = new Student();
		student1.name = "Budi";
		student1.Age = 19;
		student1.idNumber =1234;
		Console.WriteLine($"Name {student1.name} with ID Number {student1.idNumber} and age {student1.Age} years old");
	}
	
}
