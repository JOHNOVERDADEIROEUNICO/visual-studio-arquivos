def arqExiste(nome):
    try:
        a = open(nome, 'rt')
        #rt significa read text.
        a.close()
    
    except FileNotFoundError:
        return False
    
    else:
        return True
    
#OBS TODO O EXERCICIO FOI TERMINADO NO PYCHARM DEVIDO A DIFICULDADE DE SE TRABALHAR COM ARQUIVOS DE PYTHON EM VISUAL STUDIO.