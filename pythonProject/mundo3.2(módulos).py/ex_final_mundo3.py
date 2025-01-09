from dado import choise

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