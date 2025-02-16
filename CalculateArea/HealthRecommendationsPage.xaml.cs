namespace CalculateArea;

public partial class HealthRecommendationsPage : ContentPage
{
    private string recommendations;

    public HealthRecommendationsPage(string recommendations)
    {
        InitializeComponent();
        this.recommendations = recommendations;
        BindingContext = this;
    }

    public string Recommendations => recommendations;

    private async void BtnBackToBMIResult_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void BtnBackToInput_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
