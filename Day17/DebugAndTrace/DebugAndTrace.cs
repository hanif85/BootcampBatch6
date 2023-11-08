using System.Diagnostics;
namespace Day17.DebugAndTrace;

public class DebugAndTrace
{
		static void DebugNTrace()
	{
		int userID = 123123;
		string pass = "pass";
		Debug.WriteLine(userID + "	 " + pass);
		Trace.WriteLine("Userid and password inserted");
		Debug.Assert(false, "DebugAssert says, I am watching!");
		Trace.Assert(true, "TraceAssert says, I am watching!");
		Console.Read();
	}
}
