from math import sqrt,floor
num = int(input('digite um numero: '))
raiz = sqrt(num)
print('A raiz de {} é igual {:.2f}'.format(num,raiz))
print('A raiz de {} é igual {}'.format(num,floor(raiz)))