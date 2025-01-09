#dicionario
cores ={'limpa':'\033[m',
        'azul':'\033[34m',
        'amarelo':'\033[33m',    
        'pretobranco':'\033[7;30m',
        'vermelho':'\033[31m'}
#variaveis
contdiv = 0
n = int(input("Digite um numero: "))
#para/for
for i in range (1,n+1):

    if n % i == 0:
        print(cores ['azul'], i, cores['limpa'], end=' ')
        contdiv = contdiv+1
    else:
        print(cores ['vermelho'], i, cores['limpa'], end=' ') 
#resposta
if contdiv > 2:
    print("\no valor ", n, " nao é primo.")
else:
    print("\no valor ", n, " é primo")
#outra maneira de adicionar cores:
# if num % i == 0:
#   print('\033[34m', end=' ') 
# else:
#   print('\033[31m', end=' ')
# print('{} '.format(i),end=' ')
#ACABOU.