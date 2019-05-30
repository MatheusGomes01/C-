using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrex
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool terminada { get; set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;
        public bool xeque { get; private set; }
        public Peca vulneravelEnPassan { get; private set; }

        public PartidaDeXadrex()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            JogadorAtual = Cor.Branca;
            terminada = false;
            xeque = false;
            vulneravelEnPassan = null;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            colocarPecas();
        }

        public Peca executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdMovimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);

            if (pecaCapturada != null)
            {
                capturadas.Add(pecaCapturada);
            }

            //#jogada especial roque pequeno
            if (p is Rei && destino.coluna == origem.coluna + 2)
            {
                Posicao origemTorre = new Posicao(origem.linha, origem.coluna + 3);
                Posicao destinoTorre = new Posicao(origem.linha, origem.coluna + 1);
                Peca T = tab.retirarPeca(origemTorre);
                T.incrementarQtdMovimento();
                tab.colocarPeca(T, destinoTorre);
            }

            //#jogada especial roque grande 
            if (p is Rei && destino.coluna == origem.coluna - 2)
            {
                Posicao origemTorre = new Posicao(origem.linha, origem.coluna - 4);
                Posicao destinoTorre = new Posicao(origem.linha, origem.coluna - 1);
                Peca T = tab.retirarPeca(origemTorre);
                T.incrementarQtdMovimento();
                tab.colocarPeca(T, destinoTorre);
            }

            //#jogada especial en passant
            if (p is Peao)
            {
                if (origem.coluna != destino.coluna && pecaCapturada == null)
                {
                    Posicao posPeao;
                    if (p.cor == Cor.Branca)
                    {
                        posPeao = new Posicao(destino.linha + 1, destino.coluna);
                    }
                    else
                    {
                        posPeao = new Posicao(destino.linha - 1, destino.coluna);
                    }
                    pecaCapturada = tab.retirarPeca(posPeao);
                    capturadas.Add(pecaCapturada);
                }
            }
            return pecaCapturada;
        }

        public void desfazMovimento(Posicao origem, Posicao destino, Peca pecaCapturada)
        {
            Peca p = tab.retirarPeca(destino);
            p.decrementarQtdMovimento();
            if (pecaCapturada != null)
            {
                tab.colocarPeca(pecaCapturada, destino);
                capturadas.Remove(pecaCapturada);
            }
            tab.colocarPeca(p, origem);

            //#jogada especial roque pequeno
            if (p is Rei && destino.coluna == origem.coluna + 2)
            {
                Posicao origemTorre = new Posicao(origem.linha, origem.coluna + 3);
                Posicao destinoTorre = new Posicao(origem.linha, origem.coluna + 1);
                Peca T = tab.retirarPeca(destinoTorre);
                T.incrementarQtdMovimento();
                tab.colocarPeca(T, origemTorre);
            }

            //#jogada especial roque grande 
            if (p is Rei && destino.coluna == origem.coluna - 2)
            {
                Posicao origemTorre = new Posicao(origem.linha, origem.coluna - 4);
                Posicao destinoTorre = new Posicao(origem.linha, origem.coluna - 1);
                Peca T = tab.retirarPeca(destinoTorre);
                T.incrementarQtdMovimento();
                tab.colocarPeca(T, origemTorre);
            }

            //#jogada especial en passant
            if (p is Peao)
            {
                if (origem.coluna != destino.coluna && pecaCapturada == vulneravelEnPassan)
                {
                    Peca peao = tab.retirarPeca(destino);
                    Posicao posPeao;
                    if (p.cor == Cor.Branca)
                    {
                        posPeao = new Posicao(3, destino.coluna);
                    }
                    else
                    {
                        posPeao = new Posicao(4, destino.coluna);
                    }
                    tab.colocarPeca(peao, posPeao);
                }
            }
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            Peca pecaCapturada = executaMovimento(origem, destino);

            if (estaEmXeque(JogadorAtual))
            {
                desfazMovimento(origem, destino, pecaCapturada);
                throw new TabulerioException("Você não pode se colocar em xeque!");
            }

            if (estaEmXeque(adversaria(JogadorAtual)))
            {
                xeque = true;
            }
            else
            {
                xeque = false;
            }

            if (testeXequemate(adversaria(JogadorAtual)))
            {
                terminada = true;
            }
            else
            {
                turno++;
                mudaJogador();
            }

            Peca p = tab.peca(destino);
            //#jogada especial en passant
            if (p is Peao && (destino.linha == origem.linha -2 || destino.linha == origem.linha + 2))
            {
                vulneravelEnPassan = p;
            }
            else
            {
                vulneravelEnPassan = null;
            }
        }

        public void validarPosicaoOrigem(Posicao pos)
        {
            if (tab.peca(pos) == null)
            {
                throw new TabulerioException("Não existe peça na posição de origem escolhida");
            }
            if (JogadorAtual != tab.peca(pos).cor)
            {
                throw new TabulerioException("A peça de origem escolhida não é sua");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabulerioException("Não há movimentos possiveis para a peça escolhida");
            }
        }

        public void validarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).movimentoPossivel(destino))
            {
                throw new TabulerioException("Posição de destino inválida;");
            }
        }

        private void mudaJogador()
        {
            if (JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }

        public HashSet<Peca> pecasCapturas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in capturadas)
            {
                if (x.cor == cor)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in pecas)
            {
                if (x.cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(pecasCapturas(cor));
            return aux;

        }

        private Cor adversaria(Cor cor)
        {
            if (cor == Cor.Branca)
            {
                return Cor.Preta;
            }
            else
            {
                return Cor.Branca;
            }
        }

        private Peca rei(Cor cor)
        {
            foreach (Peca x in pecasEmJogo(cor))
            {
                if (x is Rei)
                {
                    return x;
                }
            }
            return null;
        }

        public bool estaEmXeque(Cor cor)
        {
            Peca R = rei(cor);

            if(R == null)
            {
                throw new TabulerioException("Não tem rei da cor " + cor + " no tabuleiro!");
            }

            foreach (Peca x in pecasEmJogo(adversaria(cor)))
            {
                bool[,] mat = x.movimentosPossiveis();
                if (mat[R.posicao.linha, R.posicao.coluna])
                {
                    return true;
                }
            }
            return false;
        }

        public bool testeXequemate(Cor cor)
        {
            if (!estaEmXeque(cor))
            {
                return false;
            }
            foreach (Peca x in pecasEmJogo(cor))
            {
                bool[,] mat = x.movimentosPossiveis();
                for (int i = 0; i < tab.linhas; i++)
                {
                    for (int j = 0; j < tab.colunas; j++)
                    {
                        if (mat[i,j])
                        {
                            Posicao origem = x.posicao;
                            Posicao destino = new Posicao(i, j);
                            Peca pecaCapturada = executaMovimento(origem, destino);
                            bool testeXeque = estaEmXeque(cor);
                            desfazMovimento(origem, destino, pecaCapturada);
                            if (!testeXeque)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

        public void colorcarNovaPeca(char coluna, int linha, Peca peca)
        {
            tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            pecas.Add(peca); 
        }
        private void colocarPecas()
        {
      
            colorcarNovaPeca('a', 1, new Torre(tab, Cor.Branca));
            colorcarNovaPeca('b', 1, new Cavalo(tab, Cor.Branca));
            colorcarNovaPeca('c', 1, new Bispo(tab, Cor.Branca));
            colorcarNovaPeca('d', 1, new Dama(tab, Cor.Branca));
            colorcarNovaPeca('e', 1, new Rei(tab, Cor.Branca, this));
            colorcarNovaPeca('f', 1, new Bispo(tab, Cor.Branca));
            colorcarNovaPeca('g', 1, new Cavalo(tab, Cor.Branca));
            colorcarNovaPeca('h', 1, new Torre(tab, Cor.Branca));
            colorcarNovaPeca('b', 2, new Peao(tab, Cor.Branca, this));
            colorcarNovaPeca('c', 2, new Peao(tab, Cor.Branca, this));
            colorcarNovaPeca('d', 2, new Peao(tab, Cor.Branca, this));
            colorcarNovaPeca('e', 2, new Peao(tab, Cor.Branca, this));
            colorcarNovaPeca('f', 2, new Peao(tab, Cor.Branca, this));
            colorcarNovaPeca('g', 2, new Peao(tab, Cor.Branca, this));
            colorcarNovaPeca('a', 2, new Peao(tab, Cor.Branca, this));
            colorcarNovaPeca('h', 2, new Peao(tab, Cor.Branca, this));


            colorcarNovaPeca('a', 8, new Torre(tab, Cor.Preta));
            colorcarNovaPeca('b', 8, new Cavalo(tab, Cor.Preta));
            colorcarNovaPeca('c', 8, new Bispo(tab, Cor.Preta));
            colorcarNovaPeca('d', 8, new Dama(tab, Cor.Preta));
            colorcarNovaPeca('e', 8, new Rei(tab, Cor.Preta, this));
            colorcarNovaPeca('f', 8, new Bispo(tab, Cor.Preta));
            colorcarNovaPeca('g', 8, new Cavalo(tab, Cor.Preta));
            colorcarNovaPeca('h', 8, new Torre(tab, Cor.Preta));
            colorcarNovaPeca('a', 7, new Peao(tab, Cor.Preta, this));
            colorcarNovaPeca('b', 7, new Peao(tab, Cor.Preta, this));
            colorcarNovaPeca('c', 7, new Peao(tab, Cor.Preta, this));
            colorcarNovaPeca('d', 7, new Peao(tab, Cor.Preta, this));
            colorcarNovaPeca('e', 7, new Peao(tab, Cor.Preta, this));
            colorcarNovaPeca('f', 7, new Peao(tab, Cor.Preta, this));
            colorcarNovaPeca('g', 7, new Peao(tab, Cor.Preta, this));
            colorcarNovaPeca('h', 7, new Peao(tab, Cor.Preta, this));
                                                            
        }
    }
}
