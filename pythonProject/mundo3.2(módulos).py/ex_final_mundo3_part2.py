from dado import choise

from arquivo_for_exfinal import *

arq = 'cursoemvideo.txt'

if arqExiste(arq):
    print('Arquivo encontrado com sucesso!')
else:
    print('Arquivo encontrado com sucesso!')

while True:
    c = choise(['Criar arquivo', 'Listar pessoas', 'Cadastrar pessoa', 'Sair do sistema'])

    match c:
        case 1:
            print('Criar arquivo')
        
        case 2:
            print('Listar pessoa')
        
        case 3:
            print('Cadastrar pessoa')

        case 4:
            break
#OBS TODO O EXERCICIO FOI TERMINADO NO PYCHARM DEVIDO A DIFICULDADE DE SE TRABALHAR COM ARQUIVOS DE PYTHON EM VISUAL STUDIO.