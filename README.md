🧩 Jogo da Velha — .NET MAUI
Este projeto é uma implementação simples e funcional do clássico Jogo da Velha (Tic-Tac-Toe) desenvolvida em .NET MAUI, permitindo execução em dispositivos móveis e desktop.
O objetivo é demonstrar a construção de interfaces com XAML, manipulação de eventos, lógica de jogo e estilização visual dentro do ecossistema MAUI.

🎮 Funcionalidades
 - Alternância automática entre jogadores X e O
 - Verificação completa de vitória (linhas, colunas e diagonais)
 - Detecção de empate (velha)
 - Reinício automático da partida após vitória ou empate
 - Interface estilizada com degradê rosa e elementos roxos
 - Botões desabilitados após jogada para evitar sobreposição
 - Layout responsivo utilizando Grid

🖼️ Interface
A interface foi construída em XAML utilizando:
 - LinearGradientBrush para o fundo em tons claros de rosa
 - Grid 3x3 representando o tabuleiro
 - Label centralizado para o título
 - Estilos globais para botões, com bordas e fonte roxa
 - Layout simples, limpo e visualmente agradável

🧠 Lógica do Jogo
A lógica principal está no arquivo .xaml.cs:
 - Button_Clicked: controla cada jogada, alterna o jogador e chama as verificações.
 - VerificarVitoria: checa todas as combinações possíveis de vitória.
 - VerificarVelha: identifica empate quando todos os botões estão desabilitados.
 - Zerar: reinicia o tabuleiro e retorna a vez para “X”.
 - Os botões são armazenados em uma lista para facilitar verificações e reinicialização.

🎥 Vídeo Explicativo (YouTube):  https://youtu.be/nPSKOiPSb4g
