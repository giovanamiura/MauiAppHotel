namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();

	}

    public void Button_Clicked(object sender, EventArgs e)
    {
        
        try
        {
            Navigation.PushAsync(new sobre());             //muda de página
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}