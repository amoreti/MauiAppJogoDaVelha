namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        List<Button> botoes;

        public MainPage()
        {
            InitializeComponent();

            botoes = new List<Button>()
            {
                btn10, btn11, btn12,
                btn20, btn21, btn22,
                btn30, btn31, btn32
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;
            btn.Text = vez;

            string jogadorAtual = vez;

            // Alterna jogador
            vez = (vez == "X") ? "O" : "X";

            // Verifica vitória
            if (VerificarVitoria(jogadorAtual))
            {
                DisplayAlertAsync("Fim de jogo", $"O jogador {jogadorAtual} venceu!", "OK");
                Zerar();
                return;
            }

            // Verifica velha
            if (VerificarVelha())
            {
                DisplayAlertAsync("Velha!", "Ninguém ganhou!", "OK");
                Zerar();
            }
        }

        bool VerificarVitoria(string jogador)
        {
            // Linhas
            if (btn10.Text == jogador && btn11.Text == jogador && btn12.Text == jogador) return true;
            if (btn20.Text == jogador && btn21.Text == jogador && btn22.Text == jogador) return true;
            if (btn30.Text == jogador && btn31.Text == jogador && btn32.Text == jogador) return true;

            // Colunas
            if (btn10.Text == jogador && btn20.Text == jogador && btn30.Text == jogador) return true;
            if (btn11.Text == jogador && btn21.Text == jogador && btn31.Text == jogador) return true;
            if (btn12.Text == jogador && btn22.Text == jogador && btn32.Text == jogador) return true;

            // Diagonais
            if (btn10.Text == jogador && btn21.Text == jogador && btn32.Text == jogador) return true;
            if (btn12.Text == jogador && btn21.Text == jogador && btn30.Text == jogador) return true;

            return false;
        }

        bool VerificarVelha()
        {
            return botoes.All(b => !b.IsEnabled);
        }

        void Zerar()
        {
            foreach (var b in botoes)
            {
                b.Text = "";
                b.IsEnabled = true;
            }

            vez = "X";
        }
    }
}
