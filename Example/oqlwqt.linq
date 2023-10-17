<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Static
void Main() {
	Car carA = new Car();
	Car carB = new Car();
	carB.PriceHandler(10);
	carA.PriceHandler(11);
	
	carA.GetPrice().Dump();
	carB.GetPrice().Dump();
	Car.StaticPrice.Dump();
}

class Car {
	public static int StaticPrice;
	
	public void PriceHandler(int price) {
		StaticPrice = price;
	}
	public int GetPrice()
	{
		return StaticPrice;
	}
}