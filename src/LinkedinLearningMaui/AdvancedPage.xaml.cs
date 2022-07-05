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

    private async void Button_Clicked_FilePicker(object sender, EventArgs e)
    {
        var result = await FilePicker.Default.PickAsync(new PickOptions
        {
            PickerTitle = "Mon sélecteur de fichier",
            FileTypes = new FilePickerFileType(
                new Dictionary<DevicePlatform, IEnumerable<string>>
                {
                    { DevicePlatform.WinUI, new[] { ".png" }},
                    { DevicePlatform.Android, new[] { ".jpg" }}
                })
        });

        if(result != null)
            this.FilenameLabel.Text = result.FileName;
    }

    private void Button_Clicked_DeviceInfo(object sender, EventArgs e)
    {
        modelLabel.Text = DeviceInfo.Current.Model;
        manufacturerLabel.Text = DeviceInfo.Current.Manufacturer;
        nameLabel.Text = DeviceInfo.Current.Name;
        osVersionLabel.Text = DeviceInfo.Current.VersionString;
        idiomLabel.Text = DeviceInfo.Current.Idiom.ToString();
        platformLabel.Text = DeviceInfo.Current.Platform.ToString();
    }
}