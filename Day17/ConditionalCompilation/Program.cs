//For choose between different Testing or Lib
#define GAMETESTER
#define GAMERUNNER
namespace Day17.ConditionalCompilation;



class Program {
	static void Main() {
		#if GAMERUNNER
		Console.WriteLine("GameRunner.");
		//GameRunner gameRunner = new();
		#elif GAMETESTER
		Console.WriteLine("GameTester.");
		//GameTester gameTest = new();
		//methodTest(0);
		#else
		Console.WriteLine("Not anything.");
		#endif
		Console.WriteLine("Finish");
	}
}
