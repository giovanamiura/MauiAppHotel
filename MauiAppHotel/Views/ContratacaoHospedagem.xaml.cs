namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

		dtpck_checkin.MinimumDate = DateTime.Now; // define o dia mínimo que pode realizar o checkin
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day); //define tempo máximo

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1); //pessoa pode ficar no mínimo 1 dia
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6); //pessoa pode ficar no máximo 6 meses
		{
			
		}
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

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = elemento.Date;

		dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
		dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}