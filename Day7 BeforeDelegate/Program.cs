//BEFORE
class UI
{
	public void UpdateUI(string data) {}
}
class Database
{
	public void WriteToDb(string data) { }
}
class File 
{
	public void WriteToFile(string data) { }
}

class GameController {
	private UI _ui;
	private Database _db;
	private File _file;
	public GameController(UI ui, Database db, File file) {
		_ui = ui;
		_db = db;
		_file = file;
	}
	public void EndGame() {
		_ui.UpdateUI("DATA");
		_db.WriteToDb("DATA");
		_file.WriteToFile("DATA");
	}
}