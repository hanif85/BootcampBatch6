<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Ref, Out, In
void Main() {
	//Ref
	int myInt = 2;
	MultiplyByTwoRef(ref myInt);
	myInt.Dump(); // 4
	
	//Out
	MultiplyByTwoOut(out int myIntOut);
	myIntOut.Dump();
	
	//In
	int myIntIn = 4;
	MultiplyByTwoIn(in myIntIn);
}

//Ref = pass reference, harus diassign sebelum method
void  MultiplyByTwoRef(ref int input) {
	input = 4;
	input *= 2;
}

//Out = pass reference, harus diassign didalam method sebelum methodnya exit
void MultiplyByTwoOut(out int input)
{
	input = 4; //proses assign
	input = input * 2;
}

//In = pass reference, harus diassign, tapi readonly
void MultiplyByTwoIn(in int input)
{
	//input = 4 tidak bisa karena ini readonly
	int result = input * 4;
}