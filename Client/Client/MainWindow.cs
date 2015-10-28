using System;
using Gtk;

using System.Threading;

using Client;

public partial class MainWindow: Gtk.Window
{	
	Connection connection;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		connection = new Connection ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void joinButtonClicked (object sender, EventArgs e)
	{
		connection.Send ("JOIN#");

		var readingThread = new Thread (connection.Listen);
		readingThread.Start ();

	}

	protected void UpButtonCliced (object sender, EventArgs e)
	{
		connection.Send ("UP#");
	}

	protected void RightButtonCliced (object sender, EventArgs e)
	{
		connection.Send ("RIGHT#");
	}

	protected void DownButtonCliced (object sender, EventArgs e)
	{
		connection.Send ("DOWN#");
	}

	protected void LeftButtonCliced (object sender, EventArgs e)
	{
		connection.Send ("LEFT#");
	}

	protected void ShootButonClicked (object sender, EventArgs e)
	{
		connection.Send ("SHOOT#");
	}
}
