#O programa funcionou melhor no pycharm, se encontra na pasta projectwithfabio.

def cabeça(cor,msg,l,cor_limpa):
    print(cor, f'-' * l)
    print(f'{msg}'.center(l))
    print(f'-' * l)
    print(cor_limpa)


# Progama Principal
from time import sleep
cores = {'limpa': '\033[m',
         'azul': '\033[34m',
         'amarelo': '\033[33m',
         'pretobranco': '\033[7;30m',
         'vermelho': '\033[31m',
         'branco': '\033[7;30m',
         'back_amarelo': '\033[42m',
         'back_azul': '\033[44m',
         'back_branco': '\033[7;40m',
         'back_vermelho':'\033[41m'}

comando = ''

while True:
    cabeça(cores['back_amarelo'], 'SISTEMA DE AJUDA PYHELP', 30, cores['limpa'])
    comando = str(input('\nFunção ou Biblioteca > '))

    if comando == 'exit':
        break

    cabeça(cores['back_azul'], f'Acessando o manual do comando {comando}', 40,
           cores['limpa'])
    sleep(3)
    print(cores['back_branco'])
    help(comando)
    print(cores['limpa'])

cabeça(cores['back_vermelho'], f'ATE LOGO!', 30,
           cores['limpa'])