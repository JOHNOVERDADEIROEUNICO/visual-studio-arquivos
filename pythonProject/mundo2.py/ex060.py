#variaveis
f = 1
n = int(input('Digite um número para saber o seu fatorial: '))
c = n
#prints/while
print(end='Calculando {}! = '.format(n))
while c != 0:
    f = f * c
    print(end='{} '.format(c))
    if c > 1:
        print(end=' x ')
    c -= 1
print(end=f' = {f}\n')
#OBS: TEM UM MODULO COM O CALCULO PRONTO:
from math import factorial
n = int(input('Digite um número para saber o seu fatorial: '))
f = factorial(n)
print(f'O fatorial de {n} é {f}.')
#ACABOU.