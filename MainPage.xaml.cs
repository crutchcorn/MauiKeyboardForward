namespace KeyboardForward;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		hybridWebView.SetInvokeJavaScriptTarget(this);
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	
	private void OnSendMessageButtonClicked(object sender, EventArgs e)
	{
		hybridWebView.SendRawMessage($"Hello from C#!");
	}

	public async void UpArrow()
	{
		count++;

		CounterBtn.Text = $"Clicked {count} times";
	}
	
	public async void DownArrow()
	{
		count--;

		CounterBtn.Text = $"Clicked {count} times";	
	}
}
