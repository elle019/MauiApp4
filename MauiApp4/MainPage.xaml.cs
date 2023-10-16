namespace MauiApp4;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	void OnVerticalStart(object sender, EventArgs e)
	{
		target.VerticalOptions = LayoutOptions.Start;
	}
    void OnVerticalCenter(object sender, EventArgs e)
    {
        target.VerticalOptions = LayoutOptions.Center;
    }
    void OnVerticalEnd(object sender, EventArgs e)
    {
        target.VerticalOptions = LayoutOptions.End;
    }
    void OnHorizontalStart(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.Start;
    }
    void OnHorizontalCenter(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.Center;
    }
    void OnHorizontalEnd(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.End;
    }
}

