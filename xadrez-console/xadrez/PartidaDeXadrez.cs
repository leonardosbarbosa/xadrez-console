using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementarQtdeMovimentos();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('c', 1).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('c', 2).ToPosicao());
            tab.ColocarPeca(new Rei(Cor.Branca, tab), new PosicaoXadrez('d', 1).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('d', 2).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('e', 1).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('e', 2).ToPosicao());

            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('c', 7).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('c', 8).ToPosicao());
            tab.ColocarPeca(new Rei(Cor.Preta, tab), new PosicaoXadrez('d', 8).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('d', 7).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('e', 7).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('e', 8).ToPosicao());

        }
    }
}
