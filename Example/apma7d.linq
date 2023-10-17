<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//String
void Main()
{
	string myString = "Hello";
	StringAppender(ref myString);
	myString.Dump();
}

void StringAppender(ref string input)
{
	input = input + "!!!!";
}
