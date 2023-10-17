<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Reference Type, why dont need Ref
void Main() {
	Car car = new Car(2000); //Reference Type
	MultiplyByTwoCar(car);
	car.Dump(); // 4000
}

void MultiplyByTwoCar(Car input)
{
	input.price = input.price * 2;
}

class Car {
	public int price;
	public Car(int value)
	{
		price = value;
	}
}
