//Constant is static global
public class Program
{
        static void Main()
        {
            MyMath math = new MyMath();
            //math.phi.Dump(); cant call static variable from instance
            Console.WriteLine(MyMath.phi);
            
        }
}
class MyMath {
	public const float phi = 3.14f; //Const is static
}