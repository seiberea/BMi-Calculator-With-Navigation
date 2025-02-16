namespace CalculateArea;

public partial class BMICalculationPage : ContentPage
{
    private double bmi;
    private string bmiCategory;
    private string recommendations;

    public BMICalculationPage(double bmi, string bmiCategory, string recommendations)
    {
        InitializeComponent();
        this.bmi = bmi;
        this.bmiCategory = bmiCategory;
        this.recommendations = recommendations;
        BindingContext = this;
    }

    public double BMI => bmi;
    public string BMICategory => bmiCategory;

    private async void BtnRecommendations_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HealthRecommendationsPage(recommendations));
    }

    private async void BtnBackToInput_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
