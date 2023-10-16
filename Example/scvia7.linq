<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

void Main()
{
	Parent p = new Child();
	Child c = (Child)new Parent();
	c.x.Dump();
}

class Parent { }
class Child : Parent { public int x = 3; }