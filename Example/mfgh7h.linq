<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>


class Program {
	static void Main(){
		Publisher pub = new Publisher();
		
		Subscriber sub1 = new Subscriber();
		Subscriber2 sub2 = new Subscriber2();
		Subscriber3 sub3 = new Subscriber3();
		
		pub.AddSubscriber(sub1.Notification);
		pub.AddSubscriber(sub2.Notification);
		pub.AddSubscriber(sub3.Notification);
		
		pub.UploadVideo();
		
		pub.RemoveSubscriber(sub1.Notification);
		
		pub.UploadVideo();
		
	}
}
class Publisher {
	public delegate void Notify(string message);
	private Notify subscriber;
	
	public void UploadVideo() {
		"Uploading Video...".Dump();
		"Finished".Dump();
		NotifyMySubscriber("Check my video");
	}
	public void NotifyMySubscriber(string message) {
		subscriber.Invoke(message);
	}
	public void AddSubscriber(Notify sub) {
		subscriber += sub;
	}
	public void RemoveSubscriber(Notify sub)
	{
		subscriber -= sub;
	}
}
class Subscriber {
	public void Notification(string message) {
		$"Subscriber 1 got notif : {message}".Dump();
	}
}
class Subscriber2
{
	public void Notification(string message)
	{
		$"Subscriber 2 got notif : {message}".Dump();
	}
}
class Subscriber3
{
	public void Notification(string message)
	{
		$"Subscriber 3 got notif : {message}".Dump();
	}
}