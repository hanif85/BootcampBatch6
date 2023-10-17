<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Object Collector
void Main()
{
	ObjectCollection collection = new();
	collection.Add(1);
	collection.Add(true);
	collection.Add(1.0f);
	collection.Add(null);
	collection.Add("yusuf");
	collection.Add(1000000M);
	
	int result = (int)collection.myCollection[0];
	int result2 = (int)collection.myCollection[1];
}
class ObjectCollection {
	public object[] myCollection = new object[100];
	public int counter = 0;
	
	public bool Add(object input) {
		myCollection[counter] = input;
		counter++;
		return true;
	}
}