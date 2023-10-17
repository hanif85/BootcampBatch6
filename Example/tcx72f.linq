<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

public delegate void Notify(string message);
class Program
{
	static void Main()
	{
		Subscriber sub1 = new();
		Subscriber sub2 = new();
		Subscriber sub3 = new();
		
		Publisher pub = new();
		pub.NotifyMySubscriber(sub1, "Check my video");
		pub.NotifyMySubscriber(sub2, "Check my video");
		pub.NotifyMySubscriber(sub3, "Check my video");
		
		pub.NotifyMySubscriber(sub1, "Donate");
		pub.NotifyMySubscriber(sub2, "Donate");
		pub.NotifyMySubscriber(sub3, "Donate");
	}
}
class Publisher
{

	public void UploadVideo()
	{
		"Uploading Video...".Dump();
		"Finished".Dump();
	}
	public void NotifyMySubscriber(Subscriber sub,string message)
	{
		sub.Notification(message);
	}
}
class Subscriber
{
	public void Notification(string message)
	{
		$"Subscriber 1 got notif : {message}".Dump();
	}
}