
from time import sleep

lista = []

for c in range (0,5):
    n = int(input('Digite um valor: '))
    lista.append(n)
    lista.sort()

    if len(lista) == 1:
        print('Valor adicionado ao final da lista...')
    elif n == max(lista):
        print('Valor adicionado ao final da lista...')
    else:
        print(f'Valor adicionado na posição {lista.index(n)} da lista...')

print('Os valores digitados em ordem foram: ',lista)