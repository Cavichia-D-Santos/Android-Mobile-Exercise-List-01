using Microsoft.Extensions.Options;

namespace listaMobile01_CalcBasica
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClickSomar(object sender, EventArgs e)
        {
            float valorUm = float.Parse(etrVal1.Text);
            float valorDois = float.Parse(etrVal2.Text);
            float resultado = valorUm + valorDois;
            DisplayAlert("SOMA", $"{valorUm} + {valorDois} = {resultado}", "VOLTAR");
        }

        private void OnClickSubtrair(object sender, EventArgs e)
        {
            float valorUm = float.Parse(etrVal3.Text);
            float valorDois = float.Parse(etrVal4.Text);
            float resultado = valorUm - valorDois;
            DisplayAlert("SUBTRAÇÃO", $"{valorUm} - {valorDois} = {resultado}", "VOLTAR");
        }

        private void OnClickMultiplicar(object sender, EventArgs e)
        {
            float valorUm = float.Parse(etrVal5.Text);
            float valorDois = float.Parse(etrVal6.Text);
            float resultado = valorUm * valorDois;
            DisplayAlert("MULTIPLICAÇÃO", $"{valorUm} * {valorDois} = {resultado}", "VOLTAR");
        }

        private void OnClickDividir(object sender, EventArgs e)
        {
            float valorUm = float.Parse(etrVal7.Text);
            float valorDois = float.Parse(etrVal8.Text);
            float resultado = valorUm / valorDois;
            DisplayAlert("DIVISÃO", $"{valorUm} / {valorDois} = {resultado}", "VOLTAR");
        }

    }

}
