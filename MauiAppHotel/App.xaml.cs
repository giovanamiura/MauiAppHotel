
using MauiAppHotel.NovaPasta2;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 300.00,
                ValorDiariaCrianca = 150.00
            },
            new Quarto()
            {
                Descricao = "Suíte Comum",
                ValorDiariaAdulto = 90.00,
                ValorDiariaCrianca = 45.00      
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 45.00,
                ValorDiariaCrianca = 22.00
            },
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
           
        }

    protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400; //largura janela
            window.Height = 600; //altura janela
            return window;
        }
    }
}
