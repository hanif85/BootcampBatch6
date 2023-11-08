namespace Day17.ConditionalCompilation3;
//Jika dirun pasti akan ke Debug
//dotnet build -c PRODUCTION

class Program {
	static void Main() {
		#if (DEBUG)
		Console.WriteLine("Mode DEBUG diaktifkan.");
		#elif (PRODUCTION)
		Console.WriteLine("PRODUCTION mode aktif");
		#elif (DEVELOPMENT)
		Console.WriteLine("DEVELOP mode aktif");
		#elif (FEATURETEST)
		Console.WriteLine("FEATURE mode aktif");
		#else
		Console.WriteLine("No define found");
		#endif
		
		Console.WriteLine("Program berjalan...");
		Console.Read();
	}
}
