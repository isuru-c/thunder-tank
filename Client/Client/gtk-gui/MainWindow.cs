
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.Frame frame2;
	private global::Gtk.Alignment GtkAlignment;
	private global::Gtk.Fixed fixed2;
	private global::Gtk.Button joinButton;
	private global::Gtk.Button up;
	private global::Gtk.Button down;
	private global::Gtk.Button left;
	private global::Gtk.Button right;
	private global::Gtk.Button shoot;
	private global::Gtk.Label GtkLabel5;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(6));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.frame2 = new global::Gtk.Frame ();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.fixed2 = new global::Gtk.Fixed ();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.joinButton = new global::Gtk.Button ();
		this.joinButton.CanFocus = true;
		this.joinButton.Name = "joinButton";
		this.joinButton.UseUnderline = true;
		this.joinButton.Label = global::Mono.Unix.Catalog.GetString ("Join");
		this.fixed2.Add (this.joinButton);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.joinButton]));
		w1.X = 157;
		w1.Y = 38;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.up = new global::Gtk.Button ();
		this.up.CanFocus = true;
		this.up.Name = "up";
		this.up.UseUnderline = true;
		this.up.Label = global::Mono.Unix.Catalog.GetString ("Up");
		this.fixed2.Add (this.up);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.up]));
		w2.X = 308;
		w2.Y = 30;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.down = new global::Gtk.Button ();
		this.down.CanFocus = true;
		this.down.Name = "down";
		this.down.UseUnderline = true;
		this.down.Label = global::Mono.Unix.Catalog.GetString ("Down");
		this.fixed2.Add (this.down);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.down]));
		w3.X = 301;
		w3.Y = 99;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.left = new global::Gtk.Button ();
		this.left.CanFocus = true;
		this.left.Name = "left";
		this.left.UseUnderline = true;
		this.left.Label = global::Mono.Unix.Catalog.GetString ("Left");
		this.fixed2.Add (this.left);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.left]));
		w4.X = 255;
		w4.Y = 65;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.right = new global::Gtk.Button ();
		this.right.CanFocus = true;
		this.right.Name = "right";
		this.right.UseUnderline = true;
		this.right.Label = global::Mono.Unix.Catalog.GetString ("Right");
		this.fixed2.Add (this.right);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.right]));
		w5.X = 352;
		w5.Y = 64;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.shoot = new global::Gtk.Button ();
		this.shoot.CanFocus = true;
		this.shoot.Name = "shoot";
		this.shoot.UseUnderline = true;
		this.shoot.Label = global::Mono.Unix.Catalog.GetString ("Shoot");
		this.fixed2.Add (this.shoot);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.shoot]));
		w6.X = 287;
		w6.Y = 152;
		this.GtkAlignment.Add (this.fixed2);
		this.frame2.Add (this.GtkAlignment);
		this.GtkLabel5 = new global::Gtk.Label ();
		this.GtkLabel5.Name = "GtkLabel1";
		this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>GtkFrame</b>");
		this.GtkLabel5.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel5;
		this.Add (this.frame2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 453;
		this.DefaultHeight = 336;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.joinButton.Clicked += new global::System.EventHandler (this.joinButtonClicked);
		this.up.Clicked += new global::System.EventHandler (this.UpButtonCliced);
		this.down.Clicked += new global::System.EventHandler (this.DownButtonCliced);
		this.left.Clicked += new global::System.EventHandler (this.LeftButtonCliced);
		this.right.Clicked += new global::System.EventHandler (this.RightButtonCliced);
		this.shoot.Clicked += new global::System.EventHandler (this.ShootButonClicked);
	}
}
