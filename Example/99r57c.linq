<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Generic Class Collector
void Main()
{
	GenericCollection<int,string> generic = new();
	generic.Add(3,"hello");
	generic.Add(4, "true");
}
class GenericCollection<T,T2>
{
	public T[] myCollection = new T[100];
	public T2[] myCollection2 = new T2[100];
	public int counter = 0;

	public bool Add(T input, T2 input2)
	{
		myCollection[counter] = input;
		myCollection2[counter] = input2;
		counter++;
		return true;
	}
}