#IMPORTAÇÕES
from random import randint
from time import sleep
#LISTAS
ms = []
msc = []
#FIRULAS
print('-'*40)
print('JOGA NA MEGA SENA'.center(40))
print('-'*40)
sleep(1)
#RESPOSTA DO USUARIO
ndv = (int(input('Quantas vezes você quer que eu jogue? ')))
print(f' SORTEANDO {ndv} JOGOS '.center(40, '='))
sleep(1)
#ENQUANTOS/WHILES
acm = 0
while len(msc) < ndv:
    while acm < 6:
        ms.append(randint(1,60))
        acm += 1
    acm = 0
    ms.sort()
    msc.append(ms[:])
    ms.clear()

pos =0
while pos < len(msc):
    print(f'\nJogo {pos+1}: ', end='')
    print(msc[pos])
    sleep(1)
    pos += 1
#FIRULA
print(' < BOA SORTE! > '.center(40, '-'))
#ACABOU