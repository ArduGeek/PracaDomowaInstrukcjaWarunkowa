using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        entry1.Text += "1";
    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
        entry1.Text += "2";
    }

    protected void OnButton3Clicked(object sender, EventArgs e)
    {
        entry1.Text += "3";
    }

    protected void OnButton4Clicked(object sender, EventArgs e)
    {
        entry1.Text += "4";
    }

    protected void OnButton5Clicked(object sender, EventArgs e)
    {
        entry1.Text += "5";
    }

    protected void OnButton6Clicked(object sender, EventArgs e)
    {
        entry1.Text += "6";
    }

    protected void OnButton7Clicked(object sender, EventArgs e)
    {
        entry1.Text += "7";
    }

    protected void OnButton8Clicked(object sender, EventArgs e)
    {
        entry1.Text += "8";
    }

    protected void OnButton9Clicked(object sender, EventArgs e)
    {
        entry1.Text += "9";
    }

    protected void OnButtonClicked(object sender, EventArgs e)
    {
        entry1.Text += "0";
    }

    protected void OnButtonEnterClicked(object sender, EventArgs e)
    {
        if (entry1.Text == "1234")
        {
            entry1.Text = "Poprawny PIN";

        }
        else
        {
            entry1.Text = "Nie Poprawny PIN";
        }
    }

    protected void OnButtonResetClicked(object sender, EventArgs e)
    {
        entry1.Text = "";
    }
}
