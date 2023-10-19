//AFTER using Delegate
public delegate void MyDelegate(string message);

public class GameController 
{
	private MyDelegate _myDel;
	public void AddSubscriber(MyDelegate add) {
		_myDel += add;
	}
	public void EndGame() {
		_myDel?.Invoke("data");
	}
}