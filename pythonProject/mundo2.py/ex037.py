#variavel
n1 = int(input('Digite um número inteiro: '))
#escolha caso
print('Escolha uma base de conversão: ')
print('[1] converter para Binário')
print('[2] converter para Octal')
print('[3] converter para Hexadecimal')
#resposta do programa
escolha = int(input('Sua opção: '))
match escolha:
    case 1:
        n2 = bin(n1)
        print('{} convertido para Binário é igual a {}'.format(n1,n2 [2:]))
    case 2:
        n2 = oct(n1)
        print('{} convertido para Octal é igual a {}'.format(n1,n2 [2:]))
    case 3:
        n2 = hex(n1)
        print('{} convertido para Hexadecimal é igual a {}'.format(n1,n2 [2:]))
    case _:
        print('Valor invalido, tente novamente')
#ACABOU.