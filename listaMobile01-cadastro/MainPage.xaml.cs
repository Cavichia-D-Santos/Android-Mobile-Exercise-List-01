namespace listaMobile01_cadastro
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClickEnviaMensagemConfirmacao(object sender, EventArgs e)
        {
            DisplayAlert("DADOS RECEBIDOS", "Dados do usuário salvos com sucesso.", "VOLTAR");
        }

        private void OnClickLimpar(object sender, EventArgs e)
        {
            etrRegistro.Text = "";
            etrNome.Text = "";
            etrData.Text = "";
            etrEmail.Text = "";
            etrCpf.Text = "";
            etrRg.Text = "";
            cboxAuxilio.IsChecked = false;
            pckSexo.SelectedIndex = -1;
        }
    }

}
