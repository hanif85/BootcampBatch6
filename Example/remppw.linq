<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

void Main()
{
	Child c = new Child();
	Parent p = c;
	Child result = (Child)p;
	result.x.Dump();
}

class Parent { }
class Child : Parent { public int x = 3; }