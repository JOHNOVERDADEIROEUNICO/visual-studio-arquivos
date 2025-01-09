nome ='John'
cores ={'limpa':'\033[m',
        'azul':'\033[34m',
        'amarelo':'\033[33m',    
        'pretobranco':'\033[7;30m',
        'vermelho':'\033[31m]'}

print('\033[1;31;43m Olá, Mundo\033[m')

print('Olá muito prazer em te conhecer, {}{}{}'.format('\033[1;31m', nome,'\033[m'))

print('Olá muito prazer em te conhecer, {}{}{}'.format(cores['amarelo'], nome, cores['limpa']))