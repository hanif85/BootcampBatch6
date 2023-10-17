<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Generic Collector
void Main()
{
	GenericCollection<int> collection = new();
	collection.Add(3);
	collection.Add(4);
	collection.Add(5);
	int result = collection.myCollection[0];
	result.Dump();
	
	GenericCollection<bool> collectionOfBool = new();
	collectionOfBool.Add(true);
	collectionOfBool.Add(false);
	bool resultOfBool = collectionOfBool.myCollection[0];
	resultOfBool.Dump();
}
class GenericCollection<T>
{
	public T[] myCollection = new T[100];
	public int counter = 0;

	public bool Add(T input)
	{
		myCollection[counter] = input;
		counter++;
		return true;
	}
}