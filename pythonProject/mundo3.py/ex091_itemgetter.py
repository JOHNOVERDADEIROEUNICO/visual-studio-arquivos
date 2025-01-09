from random import randint
from time import sleep
from operator import itemgetter

dado = dict()
ranking = dict()

print('Valores sorteados: ')

dado['jogador1'] = randint(1,4)
dado['jogador2'] = randint(1,4)
dado['jogador3'] = randint(1,4)
dado['jogador4'] = randint(1,4)
ranking = sorted(dado.items(), key= itemgetter(1), reverse= True)


for k,v in dado.items():
    print(f'{k} tirou {v} no dado.')
    sleep(1)

print('-='*40)

print('  == RANKING DOS JOGADORES ==')

for i,v in enumerate(ranking):
    print(f'     {i+1}° lugar: {v[0]} com {v[1]}.')
    sleep(1)