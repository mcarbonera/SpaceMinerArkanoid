Um Arkanoid bugado, porém feito inteiramente por mim. Programação, Sprites usando Inkscape e edição de audio usando Audacity.

Alguns detalhes de configuração do git com Unity:

	-> É necessário remover arquivos temporários específicos do editor do Unity e específicos de sistema operacional. Url [1] e [2].

	-> Algumas configurações são necessárias no editor do Unity: 

	Em Edit > Project Settings > Editor, Setar Version Control/Mode  para "Visible Meta Files". Setar Asset Serialization/Mode para "Force text". Pra mim já veio setado, mas o tutorial mandou olhar.

	Por baixo dos panos o Unity cria um arquivo de configuração YAML. Deve ter uma forma mais elegante de editar. Por enquanto vou fazer sem elegância mesmo.

	-> Tenho que verificar depois o tal do git lfs, pra gerenciar arquivos grandes. Para jogos maiores, modelos 3d, imagens, audios e fontes podem ser problemáticos para o git.

	-> Talvez tenha algum outro detalhe que me escapa... Tô começando! (=

[1] https://github.com/github/gitignore/blob/master/Unity.gitignore
[2] https://github.com/github/gitignore/blob/master/Global/Windows.gitignore