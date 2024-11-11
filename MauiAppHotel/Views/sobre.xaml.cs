namespace MauiAppHotel.Views;

public partial class sobre : ContentPage
{
	public sobre()
	{
		InitializeComponent();
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());   //muda de página
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}