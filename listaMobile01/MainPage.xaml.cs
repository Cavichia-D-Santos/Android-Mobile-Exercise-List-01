namespace listaMobile01
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClickCalcularDiasVividos(object sender, EventArgs e)
        {
            int diasVividos = int.Parse(etrIdade.Text) * 365;
            DisplayAlert("DIAS VIVIDOS:", $"Você viveu {diasVividos} dias!", "OK");
        }

        private void OnClickLimpar(object sender, EventArgs e)
        {
            etrNome.Text = "";
            etrIdade.Text = "";
        }
    }
}
