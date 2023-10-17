<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

public delegate void Notify(string message);
class Program {
	static void Main()
	{
		Publisher pub = new Publisher();
		Subscriber sub1 = new Subscriber();
		sub1.SubscribeTo(pub);
		pub.UploadVideo();
		
		pub.ClearAllSubscriber();
		pub.UploadVideo();
	}
}
class Publisher
{
	private Notify subscriber;

	public void UploadVideo()
	{
		"Uploading Video...".Dump();
		"Finished".Dump();
		NotifyMySubscriber("Check my video");
	}
	public void NotifyMySubscriber(string message)
	{
		subscriber?.Invoke(message);
	}
	public void AddNewSubscriber(Notify newSubscriber) {
		subscriber += newSubscriber;
	}
	public void ClearAllSubscriber() {
		subscriber = null;
	}
}
class Subscriber
{
	public void Notification(string message)
	{
		$"Subscriber 1 got notif : {message}".Dump();
	}
	public void SubscribeTo(Publisher pub) {
		pub.AddNewSubscriber(Notification);
	}
}