import math
import random

num = int(input('digite um numero: '))
raiz = math.sqrt(num)
print('A raiz de {} é igual {:.2f}'.format(num,raiz))
print('A raiz de {} é igual {}'.format(num,math.ceil(raiz)))
print('A raiz de {} é igual {}'.format(num,math.floor(raiz)))
#um numero aleatorio que vai de 0 a 1
num2 = random.random()
print('numero aleatorio ',num2)
#um numero aleatorio de 0 a 10
num3 = random.randint(1, 10)
print('Outro aleatorio ',num3)
#no site do python.org voce encontra na aba pypi mais bibliotecas que podem ser baixadas e carregadas no nosso python, um exemplo é uma biblioteca de emoji que adiciona emojis ao nosso python, acho que o melhor exemplo que podemos ter é os mods que voce baixa nos jogos é a mesma coisa.
