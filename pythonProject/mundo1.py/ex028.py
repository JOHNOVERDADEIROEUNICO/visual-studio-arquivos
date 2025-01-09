import random
from time import sleep

print('Vou pensar em um número entre 0 e 5. Tente adivinhar...')
n1 = random.randint(0,5)
n2 = int(input('Em que número eu pensei? '))
print('PROCESSANDO...')
sleep(3)
if n1 == n2:
    print('ACERTOU! Eu pensei no número {} e você adivinhou!'.format(n1))
else:
    print('ERROW! Eu pensei no número {} e não no número {}'.format(n1,n2))