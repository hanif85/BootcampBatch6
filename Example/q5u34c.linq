<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Parsing with TryParse
void Main()
{
	string myString = "351";
	bool statusParsing = int.TryParse(myString, out int result);
	result.Dump();
	statusParsing.Dump();
}