<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Object -> Generic
void Main()
{
	MyCollection<string> myStringCollection = new();
	myStringCollection.SetValue(0, "hello");
	myStringCollection.SetValue(1, "world");
	
	myStringCollection.GetValue(0).Dump();
}

class MyCollection<T>
{
	private T[] collection = new T[100];
	public T GetValue(int index) {
		if(index < collection.Length-1) {
			return collection[index];
		}
		throw new IndexOutOfRangeException("Not found data");
	}
	public bool SetValue(int index, T data) {
		collection[index] = data;
		return true;
	}
}