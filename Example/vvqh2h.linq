<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

public delegate string MyDelegate(); //wadah dari method

class Program
{
	static void Main()
	{
		MyDelegate myDelegate = Printer;
		myDelegate += Layangan;

		string result = myDelegate(); //Invoke
		result.Dump();
	}
	static string Printer()
	{
		return "Printer";
	}
	static string Layangan()
	{
		return "Layangan";
	}
}