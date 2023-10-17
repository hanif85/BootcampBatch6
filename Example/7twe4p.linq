<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Static
void Main()
{
	int a = 2;
	int b = 3;
	Calculator myCalc = new();
	int result = myCalc.NonStaticAdder(a,b);
	result.Dump();
}
class Calculator {
	public static int Add(int left, int right) {
		return left+right;
	}
	public int NonStaticAdder(int left, int right) {
		return left+right;
	}
	//all must be static
}