namespace LinkedinLearningMaui;

public partial class AdvancedPage : ContentPage
{
	public AdvancedPage()
	{
		InitializeComponent();
    }

	private async void Button_Clicked(object sender, EventArgs e)
	{
        var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
        var _cancelTokenSource = new CancellationTokenSource();

        var location = await Geolocation.Default.GetLocationAsync(request, _cancelTokenSource.Token);

        if (location != null)
        {
            LongitudeLabel.Text = location.Longitude.ToString();
            LatitudeLabel.Text = location.Latitude.ToString();
            AltitudeLabel.Text = location.Altitude.ToString();
        }
    }
}