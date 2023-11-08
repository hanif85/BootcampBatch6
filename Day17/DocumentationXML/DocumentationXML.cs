 
namespace Day17.DocumentationXML;

public class DocumentationXML
{
	static void TestDoc() 
	{
		double a = 4.5;
		double b = 2.5;
		double Add = TheLib.Add(a, b);
		double Mul = TheLib.Mul(a, b);
		double Div = TheLib.Div(a, b);
		double Sub = TheLib.Sub(a, b);
		string answer = $"{Add} {Mul} {Div} {Sub}";
		Console.WriteLine($"{a} + {b} = {answer}");
	}
}
