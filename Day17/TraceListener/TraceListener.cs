using System.Diagnostics;
using System.IO;
namespace Day17.TraceListener;

public class TraceListener
{
		static void TraceList(string[] args)
		{
			
			Trace.Listeners.Clear();
			using(TextWriterTraceListener traceListener = new TextWriterTraceListener("myTraceOutput.txt")) 
			{
				Trace.Listeners.Add(traceListener);
			
				Trace.Assert(true, "This is a trace false.");
				Debug.Assert(false, "This is a DEBUG FALSE.");
				Trace.WriteLine("This is a trace statement.");
			
				traceListener.Flush();
				traceListener.Close();
			}
		}
}
