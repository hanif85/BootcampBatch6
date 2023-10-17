<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

public delegate void MyDelegate(); //wadah dari method

class Program {
	static void Main() {
		MyDelegate myDelegate = Printer;
		myDelegate += Layangan;
		myDelegate += Printer2;
		myDelegate += Layangan2;
		
		myDelegate(); //Invoke
	}
	static void Printer() {
		"Printer".Dump();
	}
	static void Layangan() {
		"Layangan".Dump();
	}
	static void Printer2()
	{
		"Printer".Dump();
	}
	static void Layangan2()
	{
		"Layangan".Dump();
	}
}