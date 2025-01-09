#importações
from random import randint
#funções
def lista_aleatoria(num):
    #variavel
    i = 0
    #while/enquanto
    while i < 5:
        #variavel crucial
        acu = 0
        ale = randint(1,10)
        #condicionais
        if len(num) > 0:
            for c in range (len(num)):
                if num[c] != ale:
                    acu +=1

            if acu == len(num):
                num.append(ale)
                i += 1

        else:
            num.append(ale)
            i += 1
    #resposta
    print('Sorteando 5 valores da lista: ', end='')

    for v in range(len(num)):
        print(num[v], end=' ')

    print('PRONTO!')

def soma_par(sp):
    #variavel
    s = 0
    #for/para
    for v in range(len(sp)):
        if sp[v] % 2 == 0:
            s += sp[v]
    #resposta
    print(f'Somando os valores de {sp} temos {s}.')
#progama principal
l = list()
lista_aleatoria(l)
soma_par(l)
#ACABOU.