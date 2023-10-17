<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
  <RuntimeVersion>7.0</RuntimeVersion>
</Query>

//Array
void Main() {
	int[] myArray = {1,2,4};
	char[] myChar = new char[4];
	string[] myStrings = new string[] {"1","2","3"};
	
	int result = myArray[2]; 
	myArray[2] = 6;
	
	int length = myArray.Length;
}