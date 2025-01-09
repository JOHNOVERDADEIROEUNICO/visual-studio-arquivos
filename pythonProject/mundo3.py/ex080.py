from time import sleep

lista = []

for c in range (0,5):
    n = int(input('Digite um valor: '))

    if c == 0 or n > max(lista):
        lista.append(n)
        print('Valor adicionado ao final da lista..')
        sleep(2)

    elif n < min(lista):
        lista.insert(0,n)
        print('Valor adicionado a posição 0 da lista..')
        sleep(2)

    elif len(lista) == 2 and n > min(lista) and n < max(lista):
        lista.insert(1,n)
        print('Valor adicionado a posição 1 da lista..')
        sleep(2)

    elif n >= lista[1] and n < lista[2]:
        lista.insert(1,n)
        print('Valor adicionado a posição 1 da lista..')
        sleep(2)

    elif n >= lista[2] and n < max(lista):
        lista.insert(2,n)
        print('Valor adicionado a posição 2 da lista..')
        sleep(2)    

print('Os valores digitados em ordem foram: ',lista)