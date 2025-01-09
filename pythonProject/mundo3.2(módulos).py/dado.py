def linha():
    print('-'*30)


def cabeçario():
    linha()
    print('MENU PRINCIPAL'.center(30))
    linha()


def leiadinheiro(msg):
    valido = False

    while not valido:
        entrada = str (input(msg)).replace(',','.').strip()
        if entrada.isalpha():
            print(f'ERRO: "{entrada}" é um preço inválido!')
        
        elif len(entrada) == 0:
            print(f'ERRO: "{entrada}" é um preço inválido!')

        else:
            valido = True
            return float(entrada)


def leiaint(a=0, msg='Usuario preferiu não digitar.'):
    while True:
        try:
            a = int(input('Digite um inteiro: '))

        except (ValueError, TypeError):
            print('ERRO: por favor, digite um número inteiro válido.')

        except (KeyboardInterrupt):
            print('Já que não quer digitar ok.')
            return msg

        else:    
            return a


def leiafloat(b=0, msg='Usuario preferiu não digitar.'):
    while True:
        try:
            b = float(input('Digite um real: '))

        except (ValueError, TypeError):
            print('ERRO: por favor, digite um número real válido.')
            continue

        except KeyboardInterrupt:
            print('Já que não quer digitar ok.')
            return msg

        else:    
            return b


def choise(lista):
    a = 0
    cabeçario()

    c =1
    for item in lista:
        print(f'{c} - {item}')
        c +=1

    linha()
    
    a = leiaint()
        
    if a != 1 and a != 2 and a != 3 and a != 4:
        while True:
            print('!ERRO, digite um valor correto!')
            a = leiaint()
            if a == 1 or 2 or 3 or 4:
                break
    return a
#OBS TODO O EXERCICIO FOI TERMINADO NO PYCHARM DEVIDO A DIFICULDADE DE SE TRABALHAR COM ARQUIVOS DE PYTHON EM VISUAL STUDIO.