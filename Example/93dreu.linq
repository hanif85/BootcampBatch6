<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Example of Static
void Main()
{
	Calculator.Add(3,4);
}
class Calculator {
	public static int Add(int a, int b) {
		(a+b).Dump();
		return a + b;
	}
}