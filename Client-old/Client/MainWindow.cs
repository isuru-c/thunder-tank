using System;
using Gtk;

using Client;

public partial class MainWindow: Gtk.Window
{	
	Tank myTank;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		myTank = new Tank ();

		pictureBox.

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void joinButtonClicked (object sender, EventArgs e)
	{
		myTank.Connect ();

	}

	protected void UpButtonCliced (object sender, EventArgs e)
	{
		myTank.MoveUp ();
	}

	protected void RightButtonCliced (object sender, EventArgs e)
	{
		myTank.MoveRight ();
	}

	protected void DownButtonCliced (object sender, EventArgs e)
	{
		myTank.MoveDown ();
	}

	protected void LeftButtonCliced (object sender, EventArgs e)
	{
		myTank.MoveLeft ();
	}

	protected void ShootButonClicked (object sender, EventArgs e)
	{
		myTank.Shoot ();
	}
}
